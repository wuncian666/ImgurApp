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
    internal class GalleryItemPresenter : IGalleryItemPresenter
    {
        private readonly IGalleryItemView _view;

        public GalleryItemPresenter(IGalleryItemView view)
        {
            this._view = view;
        }

        public void AlbumOrImageVoting(GalleryItemModel item)
        {
            // 處理投票結果
            item.HandleVoteAction();

            // 發送 API 請求
            ImgurAPI.ImgurContext context = new ImgurAPI.ImgurContext();
            string voteStr = item.NewVote.ToString().ToLower();
            context.Album.AlbumImageVoting(item.Data.id, voteStr);

            _view.UpdateGalleryItem(item);
        }
    }
}