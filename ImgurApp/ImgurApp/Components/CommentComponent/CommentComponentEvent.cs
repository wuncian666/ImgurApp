using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgurApp.Components.CommentComponent
{
    public static class CommentEvents
    {
        public static event EventHandler<CommentComponent> ReplyButtonClicked;

        public static void OnReplyButtonClicked(CommentComponent component)
        {
            ReplyButtonClicked?.Invoke(null, component);
        }
    }
}