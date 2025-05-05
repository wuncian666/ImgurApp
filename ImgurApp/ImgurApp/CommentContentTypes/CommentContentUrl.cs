using System.Windows.Forms;

namespace ImgurApp.CommentContentTypes
{
    internal class CommentContentUrl : CommentContentType
    {
        public override Control GetControl(string content)
        {
            var linkLabel = new LinkLabel
            {
                Text = content,
                AutoSize = true
            };
            linkLabel.LinkClicked += (sender, e) =>
            System.Diagnostics.Process.Start(content);
            //contentContainer.Controls.Add(linkLabel);
            //totalHeight += linkLabel.Height + 5;
            return linkLabel;
        }
    }
}