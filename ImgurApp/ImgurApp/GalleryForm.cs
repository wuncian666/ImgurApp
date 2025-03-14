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

        private GallerySearchModel _response;

        public GalleryForm()
        {
            InitializeComponent();

            this.sortComboBox.DataSource =
                new string[] { "viral", "top", "time", "rising" };
            this.windowComboBox.DataSource =
                new string[] { "day", "week", "month", "year", "all" };

            this._presenter = new GalleryPresenter(this);
            this.pagination1.ItemPrePages = 4;
            this.pagination1.PageNumberChange += PageNumberChange;
        }

        private void PageNumberChange(object sender, int e)
        {
            Console.WriteLine("page:" + e);
            galleryContainer.Controls.Clear();

            for (int i = e; i < e + pagination1.ItemPrePages; i++)
            {
                GalleryItem image = new GalleryItem(_response.data[i]);
                galleryContainer.Controls.Add(image);
            }
        }

        public void ShowGallery(GallerySearchModel response)
        {
            this._response = response;
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
    }
}