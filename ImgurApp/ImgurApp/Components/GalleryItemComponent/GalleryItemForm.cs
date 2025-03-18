using ImgurAPI.Models;
using ImgurApp.Components.GalleryItemComponent;
using ImgurApp.Contracts;
using ImgurApp.Forms;
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

namespace ImgurApp.Components
{
    public partial class GalleryItemForm : UserControl, IGalleryItemView
    {
        private readonly IGalleryItemPresenter _presenter;

        private readonly GalleryItemModel _item;

        public GalleryItemForm(GallerySearchModel.Datum item)
        {
            InitializeComponent();
            imgurPicture.LoadAsync($"https://imgur.com/{item.cover}.jpg");
            this._presenter = new GalleryItemPresenter(this);

            this._item = new GalleryItemModel
            {
                Data = item,
                Score = item.score,
                UpLabelColor = Color.Black,
                DownLabelColor = Color.Black
            };

            this.InitGalleryItem(item);
        }

        public void UpdateGalleryItem(GalleryItemModel item)
        {
            this.upLabel.ForeColor = item.UpLabelColor;
            this.downLabel.ForeColor = item.DownLabelColor;
            score.Text = item.Score.ToString();
        }

        private void InitGalleryItem(GallerySearchModel.Datum item)
        {
            titleLabel.Text = item.title;
            score.Text = item.score.ToString();
            commentCount.Text = item.comment_count.ToString();
            views.Text = item.views.ToString();

            this.upLabel.Tag = Vote.Up;
            this.downLabel.Tag = Vote.Down;
        }

        private void Vote_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            this._item.NewVote = (Vote)label.Tag;
            this._presenter.AlbumOrImageVoting(this._item);
        }

        private void OpenGalleryDetail_Click(object sender, EventArgs e)
        {
            GalleryDetailForm form = new GalleryDetailForm(this._item);
            form.Show();
        }
    }
}