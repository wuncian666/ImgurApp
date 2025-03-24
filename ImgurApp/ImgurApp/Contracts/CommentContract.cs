using ImgurAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgurApp.Contracts
{
    public interface ICommentsPresenter
    {
        Task GetCommentsAsync(string galleryId);
    }

    public interface ICommentsView
    {
        void ShowComments(CommentsModel comment);
    }
}