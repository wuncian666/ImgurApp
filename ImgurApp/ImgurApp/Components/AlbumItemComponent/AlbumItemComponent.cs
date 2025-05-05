using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImgurAPI.Models;
using ImgurApp.Components.VoteComponent;
using ImgurApp.Contracts;
using ImgurApp.Presenters;
using ImgurApp.Models;
using ImgurApp.Forms;

namespace ImgurApp.Components.ImageItemComponent
{
    public partial class AlbumItemComponent : UserControl
    {
        private VoteModel _voteModel;

        private AlbumsModelWithVote _albumModelWithVote;

        public AlbumItemComponent(AlbumsModelWithVote response)
        {
            InitializeComponent();

            Console.WriteLine($"https://i.imgur.com/{response.cover}.jpeg");
            this._albumModelWithVote = response;
            this.pictureBox1.LoadAsync($"https://i.imgur.com/{response.cover}.jpeg");
            this.titleLabel.Text = response.title;
            this.views.Text = response.views.ToString();
            var score = response.ups - response.downs;
            this._voteModel = new VoteModel
            {
                VoteTarget = VoteTarget.AlbumOrImage,
                NewScore = score,
                OldScore = score,
                UpLabelColor = Color.Black,
                DownLabelColor = Color.Black
            };
            var voteConfig = new VoteComponentConfig
            {
                Direction = VoteDirection.Horizontal,
                RefContainerSize = container.Size,
                FontSize = container.Font
            };
            var voteComponent =
                new VoteComponent.VoteComponent(this._voteModel, voteConfig);
            this.container.Controls.Add(voteComponent);
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            var albumForm = new ImageEditForm(this._albumModelWithVote.id);
            albumForm.Show();
        }
    }
}