using ImgurAPI.Models;
using ImgurApp.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgurApp.Presenters
{
    internal class AlbumFavoritePresenter : IAlbumFavoritePresenter
    {
        private readonly IAlbumFavoriteView _view;

        public AlbumFavoritePresenter(IAlbumFavoriteView view)
        {
            _view = view;
        }

        public async Task AddToFavoritesAsync(string albumId)
        {
            ImgurAPI.ImgurContext context = new ImgurAPI.ImgurContext();
            BasicResponseModel response = await context.Album.AlbumImageFavorite(albumId);
            if (response.success)
            {
                _view.FavoriteUpdated();
            }
        }
    }
}