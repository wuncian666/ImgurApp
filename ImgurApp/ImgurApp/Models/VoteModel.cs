using ImgurApp.Components.VoteComponent;
using System.Drawing;

namespace ImgurApp
{
    public class VoteModel
    {
        //public GallerySearchModel.Datum Data { get; set; }
        public VoteTarget VoteTarget { get; set; }

        public string ItemId { get; set; }

        public int NewScore { get; set; }

        public int OldScore { get; set; }

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
            NewScore = OldScore;
        }

        private void ResetColor()
        {
            UpLabelColor = Color.Black;
            DownLabelColor = Color.Black;
        }

        private void VoteUp()
        {
            NewScore++;
            UpLabelColor = Color.Green;
        }

        private void VoteDown()
        {
            NewScore--;
            DownLabelColor = Color.Red;
        }
    }
}