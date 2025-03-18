using ImgurAPI.Models;
using ImgurApp.Components.GalleryItemComponent;
using ImgurApp.Contracts;
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

namespace ImgurApp.Forms
{
    public partial class GalleryDetailForm : Form, IGalleryItemView
    {
        private readonly GalleryItemModel _item;

        private readonly IGalleryItemPresenter _galleryPresenter;

        public GalleryDetailForm(GalleryItemModel item)
        {
            InitializeComponent();
            this._item = item;
            this._galleryPresenter = new GalleryItemPresenter(this);
            this.InitGalleryDetailForm();
        }

        public void UpdateGalleryItem(GalleryItemModel item)
        {
            this.upLabel.ForeColor = item.UpLabelColor;
            this.downLabel.ForeColor = item.DownLabelColor;
            scoreLabel.Text = item.Score.ToString();
        }

        private void InitGalleryDetailForm()
        {
            this.userNameLabel.Text = _item.Data.account_url;
            this.titleLabel.Text = _item.Data.title;
            this.scoreLabel.Text = _item.Data.score.ToString();
            this.upLabel.ForeColor = _item.UpLabelColor;
            this.upLabel.Tag = Vote.Up;
            this.downLabel.ForeColor = _item.DownLabelColor;
            this.downLabel.Tag = Vote.Down;
            foreach (var image in _item.Data.images)
            {
                PictureBox picture = new PictureBox
                {
                    Size = new Size(image.width / 4, image.height / 4),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                picture.LoadAsync($"https://imgur.com/{image.id}.jpg");
                imageContainer.Controls.Add(picture);
            }
        }

        private void Vote_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            this._item.NewVote = (Vote)label.Tag;
            this._galleryPresenter.AlbumOrImageVoting(this._item);
        }
    }
}