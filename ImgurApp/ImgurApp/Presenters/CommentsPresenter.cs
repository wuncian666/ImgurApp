using ImgurAPI.Models;
using ImgurApp.Contracts;
using ImgurApp.Models;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace ImgurApp.Presenters
{
    internal class CommentsPresenter : ICommentsPresenter
    {
        private readonly ICommentsView _view;

        public CommentsPresenter(ICommentsView view)
        {
            this._view = view;
        }

        public async Task GetCommentsAsync(string galleryId)
        {
            ImgurAPI.ImgurContext context = new ImgurAPI.ImgurContext();
            try
            {
                CommentsModel response =
                await context.Comment.GetComments(galleryId);
                this._view.ShowComments(response);
            }
            catch (JsonReaderException ex)
            {
                Console.WriteLine($"JSON Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public async Task PostCommentsAsync(string imageId, string comment, string parentId)
        {
            if (imageId != parentId)
            {
                await this.ReplyCreationAsync(imageId, parentId, comment);
                return;
            }
            Console.WriteLine("add main");

            parentId = null;
            ImgurAPI.ImgurContext context = new ImgurAPI.ImgurContext();
            _ = await context.Comment.CommentCreation(imageId, comment, parentId);

            var commentModel = new CommentsModel.Datum
            {
                image_id = imageId,
                comment = comment,
                author = AccountModel.Account_url,
            };
            this._view.AddCommentToContainer(commentModel);
        }

        public async Task ReplyCreationAsync(string imageId, string commentId, string comment)
        {
            ImgurAPI.ImgurContext context = new ImgurAPI.ImgurContext();
            var response = await context.Comment.ReplyCreation(imageId, commentId, comment);

            long.TryParse(commentId, out long parentId);
            var commentModel = new CommentsModel.Datum
            {
                image_id = imageId,
                comment = comment,
                author = AccountModel.Account_url,
                parent_id = parentId,
                id = response.data.id,
            };

            this._view.AddReplyToSelectedComment(commentModel);
        }
    }
}