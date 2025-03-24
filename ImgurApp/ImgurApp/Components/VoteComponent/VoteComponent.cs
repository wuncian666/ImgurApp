using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImgurApp.Components.GalleryItemComponent;
using ImgurApp.Contracts;
using ImgurApp.Presenters;

namespace ImgurApp.Components.VoteComponent
{
    public enum VoteDirection
    {
        Horizontal,
        Vertical,
    }

    public partial class VoteComponent :
        UserControl,
        IGalleryVoteView
    {
        private readonly IGalleryVotePresenter _presenter;

        private readonly GalleryVoteModel _voteModel;

        private readonly VoteConfig _config;

        private readonly Label _upLabel;
        private readonly Label _downLabel;
        private readonly Label _scoreLabel;

        public VoteComponent(GalleryVoteModel voteModel, VoteConfig config)
        {
            InitializeComponent();

            this._voteModel = voteModel;
            this._presenter = new GalleryItemPresenter(this);

            this._config = config;
            this.Size = config.ContainerSize;
            this.voteContainer.Size = config.ContainerSize;

            this._upLabel = new Label
            {
                Font = config.IConSize,
                Text = "⬆",
                Tag = Vote.Up,
                Size = config.LabelSize,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = _voteModel.UpLabelColor,
            };

            this._scoreLabel = new Label
            {
                Font = config.FrontSize,
                Text = _voteModel.NewScore.ToString(),
                Size = config.LabelSize,
                TextAlign = ContentAlignment.MiddleCenter,
            };

            this._downLabel = new Label
            {
                Font = config.IConSize,
                Text = "⬇",
                Tag = Vote.Down,
                Size = config.LabelSize,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = _voteModel.DownLabelColor,
            };

            this._upLabel.Click += Vote_Click;
            this._downLabel.Click += Vote_Click;

            this.voteContainer.Controls.Add(_upLabel);
            this.voteContainer.Controls.Add(_scoreLabel);
            this.voteContainer.Controls.Add(_downLabel);

            this.ArrangeControls();
        }

        private void ArrangeControls()
        {
            if (this._config.Direction == VoteDirection.Horizontal)
            {
                _upLabel.Location = new Point(0, 0);
                _scoreLabel.Location = new Point(this._config.RefSize.Width, 0);
                _downLabel.Location = new Point(this._config.RefSize.Width * 2, 0);
            }
            else
            {
                _upLabel.Location = new Point(0, 0);
                _scoreLabel.Location = new Point(0, this._config.RefSize.Width);
                _downLabel.Location = new Point(0, this._config.RefSize.Width * 2);
            }
        }

        public void UpdateGalleryItem(GalleryVoteModel item)
        {
            this._upLabel.ForeColor = item.UpLabelColor;
            this._downLabel.ForeColor = item.DownLabelColor;
            _scoreLabel.Text = item.NewScore.ToString();
        }

        private void Vote_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            this._voteModel.NewVote = (Vote)label.Tag;
            this._presenter.AlbumOrImageVoting(this._voteModel);
        }
    }
}