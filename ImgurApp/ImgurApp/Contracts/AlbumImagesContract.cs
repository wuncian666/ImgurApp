using ImgurAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgurApp.Contracts
{
    public interface IAlbumImagesPresenter
    {
        Task GetAlbumImagesAsync(string id);
    }

    public interface IAlbumImagesView
    {
        void AlbumImagesLoaded(AlbumImagesModel response);
    }
}