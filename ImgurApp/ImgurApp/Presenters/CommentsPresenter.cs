using ImgurAPI.Models;
using ImgurApp.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            CommentsModel response =
                await context.Comment.GetComments(galleryId);
            this._view.ShowComments(response);
        }
    }
}