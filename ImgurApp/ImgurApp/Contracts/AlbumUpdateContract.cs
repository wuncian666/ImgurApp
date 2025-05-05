using System.Threading.Tasks;

namespace ImgurApp.Contracts
{
    public interface IAlbumUpdatePresenter
    {
        Task UpdateAlbumAsync(string id, string[] ids, string title, string description);
    }

    public interface IAlbumUpdateView
    {
        void AlbumUpdated();
    }
}