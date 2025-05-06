using ImgurAPI;
using ImgurApp.Contracts;
using System.Threading.Tasks;

namespace ImgurApp.Presenters
{
    internal class AlbumUpdatePresenter : IAlbumUpdatePresenter
    {
        private readonly IAlbumUpdateView _view;

        public AlbumUpdatePresenter(IAlbumUpdateView view)
        {
            _view = view;
        }

        public async Task UpdateAlbumAsync(string id, string[] ids, string title, string description)
        {
            ImgurContext context = new ImgurContext();
            _ = await context.Album.UpdateAlbum(
                id, ids, title, description);
        }
    }
}