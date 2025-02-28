using ImgurAPI.Models;
using ImgurAPI.Models.Params;
using ImgurApp.Components;
using ImgurApp.Contracts;
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
    public partial class GalleryForm : Form, IGalleryView
    {
        private readonly IGalleryPresenter _presenter;

        public GalleryForm()
        {
            InitializeComponent();

            this.sortComboBox.DataSource =
                new string[] { "viral", "top", "time", "rising" };
            this.windowComboBox.DataSource =
                new string[] { "day", "week", "month", "year", "all" };

            this._presenter = new GalleryPresenter(this);
        }

        public void ShowGallery(GallerySearchModel response)
        {
            galleryContainer.Controls.Clear();

            foreach (var item in response.data)
            {
                GalleryItem image = new GalleryItem(item);
                galleryContainer.Controls.Add(image);
            }
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
    }
}