using ImgurAPI.Models;
using ImgurApp.Components.GalleryItemComponent;
using ImgurApp.Contracts;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgurApp.Presenters
{
    internal class GalleryItemPresenter : IGalleryVotePresenter
    {
        private readonly IGalleryVoteView _view;

        public GalleryItemPresenter(IGalleryVoteView view)
        {
            this._view = view;
        }

        public void AlbumOrImageVoting(GalleryVoteModel item)
        {
            // 處理投票結果
            item.HandleVoteAction();

            // 發送 API 請求
            ImgurAPI.ImgurContext context = new ImgurAPI.ImgurContext();
            string voteStr = item.NewVote.ToString().ToLower();
            context.Album.AlbumImageVoting(item.ItemId, voteStr);

            _view.UpdateGalleryItem(item);
        }
    }
}