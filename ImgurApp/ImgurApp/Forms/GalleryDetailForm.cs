using ImgurAPI.Models;
using ImgurApp.Components.CommentComponent;
using ImgurApp.Components.VoteComponent;
using ImgurApp.Contracts;
using ImgurApp.Models;
using ImgurApp.Presenters;
using Newtonsoft.Json;
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
    public partial class GalleryDetailForm : Form, ICommentsView
    {
        private readonly GalleryDetailModel _detailModel;
        private readonly VoteModel _voteModel;

        private readonly CommentsPresenter _presenter;

        public GalleryDetailForm(
            GalleryDetailModel detailModel,
            VoteModel voteModel)
        {
            InitializeComponent();
            this._detailModel = detailModel;
            this._voteModel = voteModel;

            this._presenter = new CommentsPresenter(this);
            _ = this.LoadCommentsAsync();

            this.InitGalleryDetailForm();
            this.InitVoteComponent();
        }

        private void InitVoteComponent()
        {
            var voteConfig = new VoteComponentConfig
            {
                Direction = VoteDirection.Vertical,
                RefContainerSize = voteContainer.Size,
                FontSize = voteContainer.Font
            };
            var voteComponent =
                new ImgurApp.Components.VoteComponent.
                VoteComponent(_voteModel, voteConfig);
            this.voteContainer.Controls.Add(voteComponent);
        }

        private async Task LoadCommentsAsync()
        {
            Console.WriteLine($"{this._detailModel.Id}");
            try
            {
                await this._presenter.GetCommentsAsync(this._detailModel.Id);
            }
            catch (JsonReaderException ex)
            {
                Console.WriteLine($"JSON Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
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

        public void ShowComments(CommentsModel comment)
        {
            for (int i = 0; i < comment.data.Length; i++)
            {
                this.commentsContainer.Controls.Add(
                    new CommentComponent(comment.data[i]));
            }
        }
    }
}