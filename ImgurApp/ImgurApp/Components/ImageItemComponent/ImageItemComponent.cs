using ImgurAPI.Models;
using ImgurApp.Models;
using System.Windows.Forms;

namespace ImgurApp.Components.ImageItemComponent
{
    public partial class ImageItemComponent : UserControl
    {
        public ImageItemComponent(ImageItemModel image)
        {
            InitializeComponent();
            this.pictureBox1.LoadAsync(image.link);
            this.descriptionBox.Text = image.description;
        }
    }
}