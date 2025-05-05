using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgurApp.Components.ImageItemComponent
{
    public partial class ImageItemComponent : UserControl
    {
        public ImageItemComponent(string link)
        {
            InitializeComponent();
            this.pictureBox1.LoadAsync(link);
            this.descriptionBox.Text = link;
        }
    }
}