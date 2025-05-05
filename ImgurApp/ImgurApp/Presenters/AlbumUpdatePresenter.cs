using ImgurAPI;
using ImgurApp.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            var result = await context.Album.UpdateAlbum(
                id, ids, title, description);
            Console.WriteLine($"{result.data}");
        }
    }
}