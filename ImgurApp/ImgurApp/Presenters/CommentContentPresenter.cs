using ImgurApp.CommentContentTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
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

        public void AnalyzeComment(string content)
        {
            CommentContentTypeEnum contentType;

            if (_imageRegex.IsMatch(content))
            {
                contentType = CommentContentTypeEnum.Picture;
            }
            else if (_videoRegex.IsMatch(content))
            {
                contentType = CommentContentTypeEnum.Video;
            }
            else if (_urlRegex.IsMatch(content))
            {
                contentType = CommentContentTypeEnum.Url;
            }
            else
            {
                contentType = CommentContentTypeEnum.Text;
            }

            CommentContentType commentType = CommentContentTypeFactory.CreateCommentControl(contentType);
            var control = commentType.GetControl(content);
            this._view.AddCommentControl(control);
        }
    }
}