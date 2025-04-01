using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgurApp.CommentContentTypes
{
    internal class CommentContentText : CommentContentType
    {
        public override Control GetControl(string content)
        {
            var textLabel = new Label
            {
                Text = content,
                AutoSize = true,
                //MaximumSize = new Size(contentContainer.Width - 5, 0)
            };

            return textLabel;
        }
    }
}