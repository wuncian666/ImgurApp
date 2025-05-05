using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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