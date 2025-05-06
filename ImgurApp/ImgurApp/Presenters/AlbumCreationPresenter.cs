using ImgurAPI.Models.Params;
using ImgurApp.Contracts;
using System.Threading.Tasks;

namespace ImgurApp.Presenters
{
    internal class AlbumCreationPresenter : IAlbumCreationPresenter
    {
        private readonly ImgurAPI.ImgurContext _context;

        public AlbumCreationPresenter()
        {
            this._context = new ImgurAPI.ImgurContext();
        }

        public Task CreateAlbumAsync(AlbumCreationParam param)
        {
            return _context.Album.CreateNewAlbum(param);
        }
    }
}