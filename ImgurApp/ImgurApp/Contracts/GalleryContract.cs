using ImgurAPI.Models;
using ImgurAPI.Models.Params;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgurApp.Contracts
{
    public interface IGalleryPresenter
    {
        Task SearchGalleryAsync(GallerySearchParam param);
    }

    public interface IGalleryView
    {
        void ShowGallery(GallerySearchModel response);
    }
}