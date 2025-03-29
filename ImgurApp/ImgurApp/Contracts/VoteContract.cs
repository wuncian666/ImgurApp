using ImgurAPI.Models;
using ImgurApp.Components.VoteComponent;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgurApp.Contracts
{
    public interface IVotePresenter
    {
        void Voting(VoteModel item);
    }

    public interface IVoteView
    {
        void UpdateVoteComponent(VoteModel item);
    }
}