using ImgurAPI.Models;
using ImgurApp.Components.GalleryItemComponent;
using ImgurApp.Components.VoteComponent;
using ImgurApp.Contracts;
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

namespace ImgurApp.Forms
{
    public partial class GalleryDetailForm : Form
    {
        private readonly GalleryDetailModel _detailModel;
        private readonly GalleryVoteModel _voteModel;

        public GalleryDetailForm(
            GalleryDetailModel detailModel,
            GalleryVoteModel voteModel)
        {
            InitializeComponent();
            this._detailModel = detailModel;
            this._voteModel = voteModel;

            var voteConfig = new VoteConfig
            {
                Direction = VoteDirection.Vertical,
                RefSize = commentLabel.Size,
                FrontSize = commentLabel.Font,
                IConSize = commentLabel.Font
            };
            var voteComponent = new VoteComponent(voteModel, voteConfig);
            this.voteContainer.Controls.Add(voteComponent);

            this.InitGalleryDetailForm();
        }

        private void InitGalleryDetailForm()
        {
            this.userNameLabel.Text = this._detailModel.Account_url;
            this.titleLabel.Text = this._detailModel.Title;
            foreach (var image in this._detailModel.Images)
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

        private void commentLabel_Click(object sender, EventArgs e)
        {
        }
    }
}