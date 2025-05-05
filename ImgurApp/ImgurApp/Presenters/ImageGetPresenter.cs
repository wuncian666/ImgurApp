using ImgurAPI.Models;
using ImgurApp.Contracts;

namespace ImgurApp.Presenters
{
    internal class ImageGetPresenter : IGetImagePresenter
    {
        private readonly IGetImageView _view;

        public ImageGetPresenter(IGetImageView view)
        {
            _view = view;
        }

        public void GetImageAsync(string accountUrl)
        {
            ImgurAPI.ImgurContext context = new ImgurAPI.ImgurContext();
            ImageModel response = context.Image.GetImage(accountUrl);
            this._view.ShowImage(response.data.link);
        }
    }
}