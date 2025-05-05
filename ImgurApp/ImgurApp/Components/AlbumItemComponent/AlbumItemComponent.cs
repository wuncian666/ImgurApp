using ImgurApp.Components.VoteComponent;
using ImgurApp.Forms;
using ImgurApp.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImgurApp.Components.ImageItemComponent
{
    public partial class AlbumItemComponent : UserControl
    {
        private readonly VoteModel _voteModel;

        private readonly AlbumsModelWithVote _albumModelWithVote;

        public AlbumItemComponent(AlbumsModelWithVote response)
        {
            InitializeComponent();

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