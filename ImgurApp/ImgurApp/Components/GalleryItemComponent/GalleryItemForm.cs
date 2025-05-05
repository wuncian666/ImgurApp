using ImgurAPI.Models;
using ImgurApp.Contracts;
using ImgurApp.Forms;
using ImgurApp.Models;
using ImgurApp.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImgurApp.Components.VoteComponent;

namespace ImgurApp.Components
{
    public partial class GalleryItemForm : UserControl
    {
        private readonly GalleryDetailModel _detailModel;
        private readonly VoteModel _voteModel;

        public GalleryItemForm(GallerySearchModel.Datum item)
        {
            InitializeComponent();
            imgurPicture.LoadAsync($"https://imgur.com/{item.cover}.jpg");

            this._detailModel = new GalleryDetailModel
            {
                Id = item.id,
                Title = item.title,
                Account_url = item.account_url,
                Images = item.images,
                Favorite = item.favorite,
            };
            this._voteModel = new VoteModel
            {
                VoteTarget = VoteTarget.AlbumOrImage,
                NewScore = item.score,
                OldScore = item.score,
                UpLabelColor = Color.Black,
                DownLabelColor = Color.Black
            };

            this.InitGalleryItem(item);
            this.InitVoteComponent();
        }

        private void InitVoteComponent()
        {
            var voteConfig = new VoteComponentConfig
            {
                Direction = VoteDirection.Horizontal,
                RefContainerSize = voteContainer.Size,
                FontSize = voteContainer.Font
            };
            var voteComponent =
                new VoteComponent.VoteComponent(_voteModel, voteConfig);
            this.voteContainer.Controls.Add(voteComponent);
        }

        private void InitGalleryItem(GallerySearchModel.Datum item)
        {
            titleLabel.Text = item.title;
            commentCount.Text = item.comment_count.ToString();
            views.Text = item.views.ToString();
        }

        private void OpenGalleryDetail_Click(object sender, EventArgs e)
        {
            GalleryDetailForm form =
                new GalleryDetailForm(
                    this._detailModel,
                    this._voteModel);
            form.Show();
        }
    }
}