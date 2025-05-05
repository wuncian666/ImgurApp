using ImgurAPI.Models;
using ImgurAPI.Models.Params;
using ImgurApp.Contracts;
using System;
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
            try
            {
                ImgurAPI.ImgurContext context = new ImgurAPI.ImgurContext();
                GallerySearchModel response = await context.Gallery.GallerySearch(param);
                this._view.ShowGallery(response);
            }
            catch (System.IndexOutOfRangeException ex)
            {
                // Log the exception or handle it as needed
                Console.WriteLine($"IndexOutOfRangeException: {ex.Message}");
            }
        }
    }
}