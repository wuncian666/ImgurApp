using ImgurAPI;
using ImgurApp.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgurApp.Presenters
{
    internal class AlbumImagesPresenter : IAlbumImagesPresenter
    {
        private readonly IAlbumImagesView _view;

        public AlbumImagesPresenter(IAlbumImagesView view)
        {
            _view = view;
        }

        public async Task GetAlbumImagesAsync(string id)
        {
            ImgurContext context = new ImgurContext();
            var response = await context.Album.GetAllOfImageInAlbum(id);
            if (!response.success)
            {
                throw new Exception("Failed to load album images");
            }

            _view.AlbumImagesLoaded(response);
        }
    }
}