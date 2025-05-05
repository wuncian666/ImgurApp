namespace ImgurApp.Models
{
    public class AlbumsModelWithVote
    {
        public string id { get; set; }
        public string link { get; set; }
        public string cover { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string accountUrl { get; set; }
        public int accountId { get; set; }
        public int views { get; set; }
        public int ups { get; set; }
        public int downs { get; set; }
    }
}