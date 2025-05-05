using ImgurAPI.Albums;
using ImgurAPI.Models;
using ImgurApp.Components.ImageItemComponent;
using ImgurApp.Contracts;
using ImgurApp.Presenters;
using ImgurApp.Utils;
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
    public partial class ImageEditForm : Form, IAlbumImagesView, IAlbumUpdateView
    {
        private readonly IAlbumImagesPresenter _presenter;
        private readonly IAlbumUpdatePresenter _albumUpdatePresenter;

        private readonly string _albumId;

        public ImageEditForm(string albumId)
        {
            InitializeComponent();
            this._albumId = albumId;
            this.linkTextBox.Text = albumId;

            this._presenter = new AlbumImagesPresenter(this);
            this._presenter.GetAlbumImagesAsync(albumId);

            this._albumUpdatePresenter = new AlbumUpdatePresenter(this);
        }

        public void AlbumImagesLoaded(AlbumImagesModel response)
        {
            for (int i = 0; i < response.data.Count(); i++)
            {
                var image = response.data[i];
                var item = new ImageItemComponent(image.link);
                this.imageContainer.Controls.Add(item);
            }
        }

        public void AlbumUpdated()
        {
        }

        private void ModifyAlbumTitle_KeyUp(object sender, KeyEventArgs e)
        {
            this.DebounceClick(() =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    this._albumUpdatePresenter.UpdateAlbumAsync(
                        this._albumId,
                        ids: new string[0],
                        this.titleBox.Text,
                        "");
                }
            }, 1000);
        }
    }
}