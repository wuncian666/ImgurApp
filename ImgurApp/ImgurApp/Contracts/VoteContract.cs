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