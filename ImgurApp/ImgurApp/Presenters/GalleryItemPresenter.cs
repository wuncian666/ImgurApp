using ImgurAPI.Models;
using ImgurApp.Components.GalleryItemComponent;
using ImgurApp.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgurApp.Presenters
{
    internal class GalleryItemPresenter : IGalleryItemPresenter
    {
        private readonly IGalleryItemView _view;

        public GalleryItemPresenter(IGalleryItemView view)
        {
            this._view = view;
        }

        public async Task AlbumOrImageVoting(string galleryHash, Vote vote)
        {
            ImgurAPI.ImgurContext context = new ImgurAPI.ImgurContext();
            string voteStr = vote.ToString().ToLower();
            AlbumImageVotingModel response =
                await context.Album.AlbumImageVoting(galleryHash, voteStr);
            if (response != null && response.success && response.status == 200)
            {
                Console.WriteLine("vote success");
                this._view.UpdateGalleryItem(vote);
            }
        }
    }
}