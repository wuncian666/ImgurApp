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