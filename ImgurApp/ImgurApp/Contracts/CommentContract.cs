using ImgurAPI.Models;
using System.Threading.Tasks;

namespace ImgurApp.Contracts
{
    public interface ICommentsPresenter
    {
        Task GetCommentsAsync(string galleryId);

        Task PostCommentsAsync(string imageId, string comment, string parentId);

        Task ReplyCreationAsync(string imageId, string commentId, string comment);
    }

    public interface ICommentsView
    {
        void ShowComments(CommentsModel comment);

        void AddCommentToContainer(CommentsModel.Datum comment);

        void AddReplyToSelectedComment(CommentsModel.Datum comment);
    }
}