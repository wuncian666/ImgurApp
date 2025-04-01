using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgurApp.CommentContentTypes
{
    internal class CommentContentPicture : CommentContentType
    {
        public override Control GetControl(string content)
        {
            var pictureBox = new PictureBox
            {
                ImageLocation = content,
                SizeMode = PictureBoxSizeMode.Zoom,
                Height = 100 // 初始高度，加載後會調整
            };

            return pictureBox;
        }
    }
}