using ImgurAPI.Models;
using ImgurAPI.Models.Params;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgurApp.Contracts
{
    public interface IImageUploadPresenter
    {
        Task ImageUpload(ImageUploadParam uploadParam);
    }

    public interface IImageUploadView
    {
        void GetImageUploadResponse(ImageUploadModel image);
    }
}