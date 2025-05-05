using ImgurAPI.Models;
using ImgurAPI.Models.Params;
using ImgurApp.Components;
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
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgurApp
{
    public partial class GalleryForm : Form, IGalleryView, IImageUploadView
    {
        private readonly IGalleryPresenter _presenter;
        private readonly IImageUploadPresenter _imageUploadPresenter;

        private GallerySearchModel _response;

        public GalleryForm()
        {
            InitializeComponent();

            _ = this.GetAccountAsync();

            this.sortComboBox.DataSource =
                new string[] { "viral", "top", "time", "rising" };
            this.windowComboBox.DataSource =
                new string[] { "day", "week", "month", "year", "all" };

            this._presenter = new GalleryPresenter(this);
            this._imageUploadPresenter =
                new ImageUploadPresenter(this);

            this.pagination1.ItemPrePages = 4;
            this.pagination1.PageNumberChange += PageNumberChange;
        }

        private async Task GetAccountAsync()
        {
            ImgurAPI.ImgurContext context = new ImgurAPI.ImgurContext();
            AccountSettingModel models = await context.Account.GetAccountSettings();
            AccountModel.Account_url = models.data.account_url;
        }

        private void PageNumberChange(object sender, int e)
        {
            galleryContainer.Controls.Clear();
            for (int i = e; i < e + pagination1.ItemPrePages; i++)
            {
                GalleryItemForm image = new GalleryItemForm(_response.data[i]);
                galleryContainer.Controls.Add(image);
            }
        }

        public void ShowGallery(GallerySearchModel response)
        {
            this._response = response;
            // 設置時會觸發 initPageNumber
            pagination1.TotalItems = response.data.Length;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            var param = new GallerySearchParam(
                sortComboBox.Text,
                windowComboBox.Text,
                (int)numericUpDown1.Value,
                queryTextBox.Text);
            this._presenter.SearchGalleryAsync(param);
        }

        private void 相簿ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlbumsForm form = new AlbumsForm();
            form.Show();
        }

        private async void 相片上傳ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 選擇相片
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif",
                Title = "選擇要上傳的相片"
            };
            // 上傳相片
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                await this._imageUploadPresenter.ImageUpload(
                    new ImageUploadParam(filePath));
            }
        }

        public void GetImageUploadResponse(ImageUploadModel image)
        {
            string url = image.data.account_url;
            ImageEditForm form = new ImageEditForm(url);
            form.Show();
        }
    }
}