using ImgurAPI.Models;
using ImgurApp.Components.GalleryItemComponent;
using ImgurApp.Contracts;
using ImgurApp.Presenters;
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
    public partial class GalleryItem : UserControl, IGalleryItemView
    {
        private readonly IGalleryItemPresenter _presenter;

        private readonly GallerySearchModel.Datum _item;

        private readonly int _tempScore = 0;

        private Vote? _vote = null;

        public GalleryItem(GallerySearchModel.Datum item)
        {
            InitializeComponent();
            imgurPicture.LoadAsync($"https://imgur.com/{item.cover}.jpg");
            this._presenter = new GalleryItemPresenter(this);
            this._item = item;
            this._tempScore = item.score;

            this.InitGalleryItem(item);
        }

        private void InitGalleryItem(GallerySearchModel.Datum item)
        {
            titleLabel.Text = item.title;
            score.Text = item.score.ToString();
            commentCount.Text = item.comment_count.ToString();
            views.Text = item.views.ToString();
        }

        private void VoteUp_Click(object sender, EventArgs e)
        {
            this.HandleVote(Vote.Up);
        }

        private void VoteDown_Click(object sender, EventArgs e)
        {
            this.HandleVote(Vote.Down);
        }

        private void HandleVote(Vote vote)
        {
            if (this._vote == vote)
            {
                this._presenter.AlbumOrImageVoting(this._item.id, Vote.Veto);
                this._vote = null;
            }
            else
            {
                this._presenter.AlbumOrImageVoting(this._item.id, vote);
                this._vote = vote;
            }
        }

        public void UpdateGalleryItem(Vote vote)
        {
            this._item.score = this._tempScore;
            switch (vote)
            {
                case Vote.Up:
                    this._item.score++;
                    this.upLabel.ForeColor = Color.Green;
                    break;

                case Vote.Down:
                    this._item.score--;
                    this.downLabel.ForeColor = Color.Red;
                    break;

                case Vote.Veto:
                    this.upLabel.ForeColor = Color.Black;
                    this.downLabel.ForeColor = Color.Black;
                    break;
            }
            score.Text = this._item.score.ToString();
        }
    }
}