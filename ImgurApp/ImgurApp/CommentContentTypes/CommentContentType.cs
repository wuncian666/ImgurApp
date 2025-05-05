using System.Windows.Forms;

namespace ImgurApp.CommentContentTypes
{
    internal abstract class CommentContentType
    {
        public abstract Control GetControl(string content);
    }
}