using ImgurAPI.Models;
using ImgurApp.Components.GalleryItemComponent;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgurApp.Contracts
{
    public interface IGalleryItemPresenter
    {
        void AlbumOrImageVoting(GalleryItemModel item);
    }

    public interface IGalleryItemView
    {
        void UpdateGalleryItem(GalleryItemModel item);
    }
}