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
    public interface IGalleryVotePresenter
    {
        void AlbumOrImageVoting(GalleryVoteModel item);
    }

    public interface IGalleryVoteView
    {
        void UpdateGalleryItem(GalleryVoteModel item);
    }
}