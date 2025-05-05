using static ImgurAPI.Models.GallerySearchModel;

namespace ImgurApp.Models
{
    public class GalleryDetailModel
    {
        public string Id { get; set; }
        public string Title { get; set; }

        public string Account_url { get; set; }

        public Image[] Images { get; set; }

        public bool Favorite { get; set; }
    }
}