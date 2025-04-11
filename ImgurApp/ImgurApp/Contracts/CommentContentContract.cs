using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgurApp.Contracts
{
    internal class CommentContentContract
    {
        public interface ICommentContentPresenter
        {
            void AnalyzeComment(string comment);
        }

        public interface ICommentContentView
        {
            void AddCommentPanelToContainer(Control control);
        }
    }
}