using ImgurAPI.Models;
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
    public partial class GalleryItem : UserControl
    {
        public GalleryItem(GallerySearchModel.Datum item)
        {
            InitializeComponent();
            imgurPicture.LoadAsync($"https://imgur.com/{item.cover}.jpg");
            score.Text = item.score.ToString();
            commentCount.Text = item.comment_count.ToString();
            views.Text = item.views.ToString();
        }
    }
}