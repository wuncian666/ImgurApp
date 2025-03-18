using ImgurAPI.Models;
using ImgurAPI.Models.Params;
using ImgurApp.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgurApp.Presenters
{
    internal class GalleryPresenter : IGalleryPresenter
    {
        private readonly IGalleryView _view;

        public GalleryPresenter(IGalleryView view)
        {
            this._view = view;
        }

        public async Task SearchGalleryAsync(GallerySearchParam param)
        {
            ImgurAPI.ImgurContext context = new ImgurAPI.ImgurContext();
            GallerySearchModel response =
                await context.Gallery.GallerySearch(param);
            this._view.ShowGallery(response);
        }
    }
}