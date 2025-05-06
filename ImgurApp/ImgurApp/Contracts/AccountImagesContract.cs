using ImgurAPI.Models;
using ImgurApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ImgurApp.Contracts
{
    public interface IAlbumsPresenter
    {
        Task GetAlbumsAsync();

        Task GetAlbumWithVoteAsync(AlbumsModel.Datum[] response);
    }

    public interface IAlbumsView
    {
        void AlbumsLoaded(AlbumsModel.Datum[] response);

        void AlbumsWithVoteLoaded(List<AlbumsModelWithVote> response);
    }
}