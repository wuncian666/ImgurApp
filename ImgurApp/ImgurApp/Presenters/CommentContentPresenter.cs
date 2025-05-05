using ImgurApp.CommentContentTypes;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static ImgurApp.Contracts.CommentContentContract;

namespace ImgurApp.Presenters
{
    internal class CommentContentPresenter : ICommentContentPresenter
    {
        private readonly ICommentContentView _view;
        private readonly Regex _imageRegex = new Regex(@"\.(jpeg|jpg|gif|png)$", RegexOptions.IgnoreCase);
        private readonly Regex _videoRegex = new Regex(@"\.mp4$", RegexOptions.IgnoreCase);
        private readonly Regex _urlRegex = new Regex(@"^(http|https)://", RegexOptions.IgnoreCase);

        public CommentContentPresenter(ICommentContentView view)
        {
            this._view = view;
        }

        public void AnalyzeComment(string comment)
        {
            var lines = comment.Split(
                new[] { "\n", "\r", "\r\n", " " },
                StringSplitOptions.None);

            FlowLayoutPanel container = new FlowLayoutPanel();
            foreach (var line in lines)
            {
                var trimmedLine = line.Trim();
                if (string.IsNullOrEmpty(trimmedLine)) continue;
                var control = AnalyzeContent(line);
                container.Controls.Add(control);
            }

            this._view.AddCommentPanelToContainer(container);
        }

        private Control AnalyzeContent(string line)
        {
            CommentContentTypeEnum contentType;

            if (_imageRegex.IsMatch(line))
            {
                contentType = CommentContentTypeEnum.Picture;
            }
            else if (_videoRegex.IsMatch(line))
            {
                contentType = CommentContentTypeEnum.Video;
            }
            else if (_urlRegex.IsMatch(line))
            {
                contentType = CommentContentTypeEnum.Url;
            }
            else
            {
                contentType = CommentContentTypeEnum.Text;
            }

            CommentContentType commentType = CommentContentTypeFactory.CreateCommentControl(contentType);
            return commentType.GetControl(line);
        }
    }
}