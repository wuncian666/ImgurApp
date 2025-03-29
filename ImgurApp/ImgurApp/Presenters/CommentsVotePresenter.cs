using ImgurApp.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgurApp.Presenters
{
    internal class CommentsVotePresenter : IVotePresenter
    {
        private readonly IVoteView _view;

        public CommentsVotePresenter(IVoteView view)
        {
            this._view = view;
        }

        public void Voting(VoteModel item)
        {
            item.HandleVoteAction();

            ImgurAPI.ImgurContext context = new ImgurAPI.ImgurContext();
            string voteStr = item.NewVote.ToString().ToLower();
            context.Comment.CommentVoting(item.ItemId, voteStr);

            this._view.UpdateVoteComponent(item);
        }
    }
}