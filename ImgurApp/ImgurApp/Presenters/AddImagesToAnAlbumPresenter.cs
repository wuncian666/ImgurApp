using ImgurApp.Contracts;
using System.Threading.Tasks;

namespace ImgurApp.Presenters
{
    internal class AddImagesToAnAlbumPresenter : IAddImagesToAnAlbumPresenter
    {
        public AddImagesToAnAlbumPresenter()
        { }

        public async Task AddImagesToAlbumAsync(string albumId, string[] imageIds)
        {
            ImgurAPI.ImgurContext context = new ImgurAPI.ImgurContext();
            await context.Album.AddImageToAnAlbum(albumId, imageIds);
        }
    }
}