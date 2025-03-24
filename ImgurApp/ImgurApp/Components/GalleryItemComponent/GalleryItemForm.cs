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
        private readonly GalleryVoteModel _voteModel;

        public GalleryItemForm(GallerySearchModel.Datum item)
        {
            InitializeComponent();
            imgurPicture.LoadAsync($"https://imgur.com/{item.cover}.jpg");

            this._detailModel = new GalleryDetailModel
            {
                Id = item.id,
                Title = item.title,
                Account_url = item.account_url,
                Images = item.images
            };
            this._voteModel = new GalleryVoteModel
            {
                NewScore = item.score,
                OldScore = item.score,
                UpLabelColor = Color.Black,
                DownLabelColor = Color.Black
            };

            var voteConfig = new VoteConfig
            {
                Direction = VoteDirection.Horizontal,
                RefSize = viewsIcon.Size,
                FrontSize = views.Font,
                IConSize = viewsIcon.Font
            };
            var voteComponent =
                new ImgurApp.Components.VoteComponent.VoteComponent(_voteModel, voteConfig);
            this.voteContainer.Controls.Add(voteComponent);

            this.InitGalleryItem(item);
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