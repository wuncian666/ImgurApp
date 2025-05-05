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
    public class ImageUploadPresenter : IImageUploadPresenter
    {
        private readonly IImageUploadView _view;

        public ImageUploadPresenter(IImageUploadView view)
        {
            this._view = view;
        }

        public async Task ImageUpload(ImageUploadParam uploadParam)
        {
            ImgurAPI.ImgurContext context = new ImgurAPI.ImgurContext();
            ImageUploadModel response = await context.Image.UploadImage(uploadParam);
            this._view.GetImageUploadResponse(response);
        }
    }
}