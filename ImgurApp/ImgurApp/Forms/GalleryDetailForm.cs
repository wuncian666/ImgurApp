using ImgurAPI.Models;
using ImgurAPI.Models.Params;
using ImgurApp.Components.CommentComponent;
using ImgurApp.Components.VoteComponent;
using ImgurApp.Contracts;
using ImgurApp.Models;
using ImgurApp.Presenters;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgurApp.Forms
{
    public partial class GalleryDetailForm :
        Form,
        ICommentsView,
        IImageUploadView,
        IAlbumFavoriteView
    {
        private readonly GalleryDetailModel _detailModel;
        private readonly VoteModel _voteModel;

        private readonly CommentsPresenter _commentsPresenter;
        private readonly ImageUploadPresenter _imageUploadPresenter;
        private readonly AlbumFavoritePresenter _albumFavoritePresenter;

        private CommentComponent _selectedComponent;

        public GalleryDetailForm(
            GalleryDetailModel detailModel,
            VoteModel voteModel)
        {
            InitializeComponent();

            this._detailModel = detailModel;
            this._voteModel = voteModel;

            this._commentsPresenter = new CommentsPresenter(this);
            this._imageUploadPresenter = new ImageUploadPresenter(this);
            this._albumFavoritePresenter = new AlbumFavoritePresenter(this);

            CommentEvents.ReplyButtonClicked += this.OnCommentReplyButtonClicked;
            _ = this.LoadCommentsAsync();

            this.InitGalleryDetailForm();
            this.InitVoteComponent();
        }

        private void OnCommentReplyButtonClicked(
            object sender,
            CommentComponent component)
        {
            this._selectedComponent = component;
            this.idLabel.Text = component.CommentId;
        }

        private async Task LoadCommentsAsync()
        {
            await this._commentsPresenter.
                GetCommentsAsync(this._detailModel.Id);
        }

        private void InitGalleryDetailForm()
        {
            this.userNameLabel.Text = this._detailModel.Account_url;
            this.titleLabel.Text = this._detailModel.Title;
            this.idLabel.Text = this._detailModel.Id;

            this.favoriteLabel.ForeColor = (this._detailModel.Favorite) ?
                Color.Red : Color.Black;

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

        private void InitVoteComponent()
        {
            var voteConfig = new VoteComponentConfig
            {
                Direction = VoteDirection.Vertical,
                RefContainerSize = voteContainer.Size,
                FontSize = voteContainer.Font
            };
            var voteComponent = new VoteComponent(_voteModel, voteConfig);
            this.voteContainer.Controls.Add(voteComponent);
        }

        public void ShowComments(CommentsModel comment)
        {
            for (int i = 0; i < comment.data.Length; i++)
            {
                var commentComponent =
                    this.CreateNewCommentComponent(comment.data[i]);
                this.commentsContainer.Controls.Add(commentComponent);
            }
        }

        private void BtnPost_Click(object sender, EventArgs e)
        {
            string comment = this.commentBox.Text;
            _ = this._commentsPresenter.PostCommentsAsync(
                this._detailModel.Id,
                comment,
                this.idLabel.Text);
        }

        public void AddCommentToContainer(CommentsModel.Datum comment)
        {
            var commentComponent = this.CreateNewCommentComponent(comment);
            this.commentsContainer.Controls.Add(commentComponent);
        }

        public void AddReplyToSelectedComment(CommentsModel.Datum comment)
        {
            this._selectedComponent.AddReplyComment(comment);
            this._selectedComponent.EnableReplyBtn();
        }

        private async void InsertImage_ClickAsync(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "圖片檔案|*.jpg;*.png;*.jpeg"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var imageUploadParams = new ImageUploadParam(openFileDialog.FileName);
                await this._imageUploadPresenter.ImageUpload(imageUploadParams);
            }
        }

        public void GetImageUploadResponse(ImageUploadModel image)
        {
            this.commentBox.Text += image.data.link;
        }

        private CommentComponent CreateNewCommentComponent(
            CommentsModel.Datum comment)
        {
            return new CommentComponent(comment);
        }

        public void FavoriteUpdated()
        {
            this.favoriteLabel.ForeColor = (this._detailModel.Favorite) ?
                Color.Black : Color.Red;
            this._detailModel.Favorite = !this._detailModel.Favorite;
        }

        private async void FavoriteLabel_ClickAsync(object sender, EventArgs e)
        {
            await this._albumFavoritePresenter.AddToFavoritesAsync(this._detailModel.Id);
        }
    }
}