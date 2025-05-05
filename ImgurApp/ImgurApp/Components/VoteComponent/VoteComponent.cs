using ImgurApp.Contracts;
using ImgurApp.Presenters;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImgurApp.Components.VoteComponent
{
    public enum VoteDirection
    {
        Horizontal,
        Vertical,
    }

    public enum VoteTarget
    {
        AlbumOrImage,
        Comment,
    }

    public partial class VoteComponent : UserControl, IVoteView
    {
        private readonly IVotePresenter _presenter;

        private readonly VoteModel _voteModel;

        private readonly VoteComponentConfig _config;

        private readonly Label _upLabel;
        private readonly Label _downLabel;
        private readonly Label _scoreLabel;

        public VoteComponent(VoteModel voteModel, VoteComponentConfig config)
        {
            InitializeComponent();

            this._voteModel = voteModel;

            // 設定邊框
            //this.BorderStyle = BorderStyle.FixedSingle;

            if (voteModel.VoteTarget == VoteTarget.AlbumOrImage)
            {
                this._presenter = new GalleryItemPresenter(this);
            }
            else if (voteModel.VoteTarget == VoteTarget.Comment)
            {
                this._presenter = new CommentsVotePresenter(this);
            }

            this._config = config;
            this.Size = config.ContainerSize;
            this.voteContainer.Size = config.ContainerSize;
            this._upLabel = new Label
            {
                Font = config.IConSize,
                Text = "⬆",
                Tag = Vote.Up,
                Size = config.IconLabelSize,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = _voteModel.UpLabelColor,
            };

            this._scoreLabel = new Label
            {
                Font = config.FontSize,
                Text = _voteModel.NewScore.ToString(),
                Size = config.ScoreLabelSize,
                TextAlign = ContentAlignment.MiddleCenter,
            };

            this._downLabel = new Label
            {
                Font = config.IConSize,
                Text = "⬇",
                Tag = Vote.Down,
                Size = config.IconLabelSize,
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
                _scoreLabel.Location = new Point(this._config.IconLabelSize.Height, 0);
                _downLabel.Location = new Point(this._config.IconLabelSize.Height * 3, 0);
            }
            else
            {
                _upLabel.Location = new Point(0, 0);
                _scoreLabel.Location = new Point(0, this._config.IconLabelSize.Height);
                _downLabel.Location = new Point(0, this._config.IconLabelSize.Height * 3);
            }
        }

        public void UpdateVoteComponent(VoteModel item)
        {
            this._upLabel.ForeColor = item.UpLabelColor;
            this._downLabel.ForeColor = item.DownLabelColor;
            _scoreLabel.Text = item.NewScore.ToString();
        }

        private void Vote_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            this._voteModel.NewVote = (Vote)label.Tag;
            this._presenter.Voting(this._voteModel);
        }
    }
}