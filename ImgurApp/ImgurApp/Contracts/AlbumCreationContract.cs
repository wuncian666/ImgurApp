using ImgurAPI.Models.Params;
using System.Threading.Tasks;

namespace ImgurApp.Contracts
{
    public interface IAlbumCreationPresenter
    {
        Task CreateAlbumAsync(AlbumCreationParam param);
    }
}