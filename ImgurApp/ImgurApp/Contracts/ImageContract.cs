namespace ImgurApp.Contracts
{
    public interface IGetImagePresenter
    {
        void GetImageAsync(string accountUrl);
    }

    public interface IGetImageView
    {
        void ShowImage(string imageUrl);
    }
}