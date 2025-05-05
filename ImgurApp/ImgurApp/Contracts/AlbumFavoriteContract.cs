using ImgurAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgurApp.Contracts
{
    public interface IAlbumFavoritePresenter
    {
        Task AddToFavoritesAsync(string albumId);
    }

    public interface IAlbumFavoriteView
    {
        void FavoriteUpdated();
    }
}