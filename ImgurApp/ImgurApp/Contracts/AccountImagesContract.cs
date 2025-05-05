using ImgurAPI.Models;
using ImgurApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgurApp.Contracts
{
    public interface IAlbumsPresenter
    {
        Task GetAlbumsAsync();
    }

    public interface IAlbumsView
    {
        void AlbumsLoaded(List<AlbumsModelWithVote> response);
    }
}