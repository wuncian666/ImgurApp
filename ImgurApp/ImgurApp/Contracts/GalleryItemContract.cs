using ImgurAPI.Models;
using ImgurApp.Components.GalleryItemComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgurApp.Contracts
{
    public interface IGalleryItemPresenter
    {
        Task AlbumOrImageVoting(String galleryHash, Vote vote);
    }

    public interface IGalleryItemView
    {
        void UpdateGalleryItem(Vote vote);
    }
}