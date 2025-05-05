using System.Windows.Forms;

namespace ImgurApp.CommentContentTypes
{
    internal class CommentContentVideo : CommentContentType
    {
        public override Control GetControl(string content)
        {
            var videoLabel = new LinkLabel
            {
                Text = $"[點擊觀看] {content}",
                AutoSize = true
            };
            videoLabel.LinkClicked += (sender, e) => System.Diagnostics.Process.Start(content);
            //contentContainer.Controls.Add(videoLabel);
            //totalHeight += videoLabel.Height + 5;
            return videoLabel;
        }
    }
}