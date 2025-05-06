using ImgurAPI.Models;
using ImgurAPI.Models.Params;
using ImgurApp.Components.ImageItemComponent;
using ImgurApp.Contracts;
using ImgurApp.Models;
using ImgurApp.Presenters;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ImgurApp.Forms
{
    public partial class ImageUploadForm : Form, IAlbumsView
    {
        private readonly IAlbumsPresenter _albumsPresenter;
        private readonly IAddImagesToAnAlbumPresenter _addImagesToAnAlbumPresenter;
        private readonly IAlbumCreationPresenter _albumCreationPresenter;
        private readonly List<ImageUploadModel> _images;
        private AlbumsModel.Datum[] _albums;

        public ImageUploadForm(ImageUploadModel image)
        {
            InitializeComponent();

            this.titleBox.Text = image.data.title;
            this._images = new List<ImageUploadModel> { image };
            this._albumsPresenter = new AlbumsPresenter(this);
            this._albumsPresenter.GetAlbumsAsync();

            this._addImagesToAnAlbumPresenter = new AddImagesToAnAlbumPresenter();
            this._albumCreationPresenter = new AlbumCreationPresenter();

            var imageModel = new ImageItemModel()
            {
                id = image.data.id,
                link = image.data.link,
                title = image.data.title,
                description = image.data.description,
            };
            this.imageContainer.Controls.Add(new ImageItemComponent(imageModel));
        }

        public void AlbumsLoaded(AlbumsModel.Datum[] response)
        {
            this._albums = response;
            this.AlbumComboBox.Items.AddRange(
                response.Select(x => x.title).ToArray());
        }

        public void AlbumsWithVoteLoaded(List<AlbumsModelWithVote> response)
        {
            // do nothing
        }

        private void UploadBtn_Click(object sender, System.EventArgs e)
        {
            if (uploadToAlbumRadioButton.Checked)
            {
                this.AddImagesToAlbum();
            }
            else if (uploadToNewAlbumRadioButton.Checked)
            {
                this.AddImagesToNewAlbum();
            }
        }

        private void AddImagesToAlbum()
        {
            var albumId = _albums.FirstOrDefault(x => x.title == AlbumComboBox.Text).id;
            var ids = this._images.Select(x => x.data.id).ToArray();
            this._addImagesToAnAlbumPresenter.AddImagesToAlbumAsync(albumId, ids);
        }

        private void AddImagesToNewAlbum()
        {
            var ids = this._images.Select(x => x.data.id).ToArray();
            AlbumCreationParam param = new AlbumCreationParam(ids)
            {
                Title = this.titleBox.Text
            };
            this._albumCreationPresenter.CreateAlbumAsync(param);
        }
    }
}