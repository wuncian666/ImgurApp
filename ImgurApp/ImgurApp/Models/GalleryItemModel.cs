using ImgurAPI.Models;
using ImgurApp.Components.GalleryItemComponent;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgurApp
{
    public class GalleryItemModel
    {
        public GallerySearchModel.Datum Data { get; set; }

        public int Score { get; set; }

        public Vote? NewVote { get; set; }

        public Vote? OldVote { get; set; }

        public Color UpLabelColor { get; set; }

        public Color DownLabelColor { get; set; }

        private bool IsVoted => !(NewVote == null && OldVote == null);

        private bool IsSameVote => NewVote == OldVote;

        public bool IsVeto => IsVoted && IsSameVote;

        public void HandleVoteAction()
        {
            // 是否投同樣的票
            if (IsVeto)
            {
                NewVote = Vote.Veto;
            }
            // 紀錄先前的投票
            OldVote = NewVote;

            this.ResetScore();
            this.ResetColor();

            switch (NewVote)
            {
                case Vote.Up:
                    this.VoteUp();
                    break;

                case Vote.Down:
                    this.VoteDown();
                    break;

                case Vote.Veto:
                    this.ResetColor();
                    break;
            }
        }

        private void ResetScore()
        {
            Score = Data.score;
        }

        private void ResetColor()
        {
            UpLabelColor = Color.Black;
            DownLabelColor = Color.Black;
        }

        private void VoteUp()
        {
            Score++;
            UpLabelColor = Color.Green;
        }

        private void VoteDown()
        {
            Score--;
            DownLabelColor = Color.Red;
        }
    }
}