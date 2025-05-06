using ImgurApp.Contracts;
using ImgurApp.Models;
using System.Threading.Tasks;

namespace ImgurApp.Presenters
{
    internal class AlbumIDsPresenter : IAlbumIDsPresenter
    {
        public Task GetAlbumIDsAsync()
        {
            ImgurAPI.ImgurContext context = new ImgurAPI.ImgurContext();
            return context.Account.GetIDs(AccountModel.Account_url, null);
        }
    }
}