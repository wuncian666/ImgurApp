﻿namespace ImgurApp.CommentContentTypes
{
    internal class CommentContentTypeFactory
    {
        public static CommentContentType CreateCommentControl(CommentContentTypeEnum type)
        {
            CommentContentType contentType = null;
            switch (type)
            {
                case CommentContentTypeEnum.Picture:
                    contentType = new CommentContentPicture();
                    break;

                case CommentContentTypeEnum.Video:
                    contentType = new CommentContentVideo();
                    break;

                case CommentContentTypeEnum.Url:
                    contentType = new CommentContentUrl();
                    break;

                case CommentContentTypeEnum.Text:
                    contentType = new CommentContentText();
                    break;

                default:
                    break;
            }
            return contentType;
        }
    }
}