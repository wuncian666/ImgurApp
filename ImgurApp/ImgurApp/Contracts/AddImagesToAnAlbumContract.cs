using System.Threading.Tasks;

namespace ImgurApp.Contracts
{
    public interface IAddImagesToAnAlbumPresenter
    {
        Task AddImagesToAlbumAsync(string albumId, string[] imageIds);
    }
}