using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImgurApp.Contracts;
using ImgurAPI.Models;
using ImgurApp.Presenters;
using ImgurApp.Components.VoteComponent;
using ImgurAPI.Comments;
using System.Text.RegularExpressions;
using static ImgurApp.Contracts.CommentContentContract;

namespace ImgurApp.Components.CommentComponent
{
    public partial class CommentComponent :
            UserControl, ICommentContentView
    {
        private readonly CommentsModel.Datum comment;
        private VoteModel _voteModel;
        private ICommentContentPresenter _presenter;
        private int _initialHeight; // 儲存元件的初始高度

        public CommentComponent(CommentsModel.Datum comment)
        {
            InitializeComponent();
            this._presenter = new CommentContentPresenter(this);
            this.comment = comment;
            this.UserLabel.Text = comment.author;
            this.SetCommentContent(comment.comment);

            this.repliesBtn.Enabled = comment.children.Count() > 0;

            this.InitVoteComponent();

            // 儲存初始高度
            this._initialHeight = this.Height;
        }

        private void SetCommentContent(string comment)
        {
            // 分析評論內容
            var lines = comment.Split(
                new[] { '\n', '\r' },
                StringSplitOptions.RemoveEmptyEntries);

            foreach (var line in lines)
            {
                var trimmedLine = line.Trim();
                if (string.IsNullOrEmpty(trimmedLine)) continue;

                this._presenter.AnalyzeComment(trimmedLine);
            }
        }

        public void AddCommentControl(Control control)
        {
            if (control != null)
            {
                this.contentContainer.Controls.Add(control);
                AdjustContainerHeight(control.Height + 5);
            }
        }

        private void AdjustContainerHeight(int additionalHeight)
        {
            contentContainer.Height += additionalHeight;

            //調整其他控件位置
            if (additionalHeight > 0)
            {
                // 向下移動其他控制項
                this.voteContainer.Top += additionalHeight;
                this.repliesBtn.Top += additionalHeight;
                this.commentContainer.Top += additionalHeight;

                // 增加整個控制項的高度
                this.Height += additionalHeight;

                // 更新初始高度
                this._initialHeight = this.Height;

                // 調整父容器的高度
                if (this.Parent is FlowLayoutPanel parent)
                {
                    parent.PerformLayout();
                }
            }
        }

        private void InitVoteComponent()
        {
            this._voteModel = new VoteModel
            {
                VoteTarget = VoteTarget.Comment,
                ItemId = comment.id.ToString(),
                NewScore = comment.points,
                OldScore = comment.points,
                UpLabelColor = Color.Black,
                DownLabelColor = Color.Black
            };

            var voteComponentConfig = new VoteComponentConfig
            {
                Direction = VoteDirection.Horizontal,
                RefContainerSize = this.voteContainer.Size,
                FontSize = this.voteContainer.Font
            };
            var voteComponent = new ImgurApp.Components.VoteComponent.
                VoteComponent(this._voteModel, voteComponentConfig);
            this.voteContainer.Controls.Add(voteComponent);
        }

        private void RepliesBtn_Click(object sender, EventArgs e)
        {
            // 切換回覆顯示狀態
            ToggleRepliesVisibility();
        }

        private int _maxHeight = 0;
        private bool _isRepliesShowed = false;
        private const int REPLY_PADDING = 5;

        /// <summary>
        /// 切換回覆顯示/隱藏狀態
        /// </summary>
        private void ToggleRepliesVisibility()
        {
            if (_isRepliesShowed)
            {
                HideReplies();
            }
            else
            {
                ShowReplies();
            }

            _isRepliesShowed = !_isRepliesShowed;
        }

        /// <summary>
        /// 隱藏回覆內容
        /// </summary>
        private void HideReplies()
        {
            this.commentContainer.Controls.Clear();
            this.commentContainer.Visible = false;
            this.commentContainer.Size = new Size(commentContainer.Width, 0);

            // 恢復到初始高度，而不是固定的 containerSize.Height
            this.Height = _initialHeight;

            // 調整父容器高度
            AdjustParentHeights(-this._maxHeight);
        }

        /// <summary>
        /// 顯示回覆內容
        /// </summary>
        private void ShowReplies()
        {
            this.commentContainer.Visible = true;
            this.commentContainer.Controls.Clear();
            this.commentContainer.Size = new Size(commentContainer.Width, 10);

            int totalHeight = LoadReplyComponents();

            // 保存總高度以便關閉時使用
            this._maxHeight = totalHeight;

            // 調整容器高度
            this.commentContainer.Size = new Size(commentContainer.Width, totalHeight);

            // 調整當前元件高度
            int originalHeight = this.Height;
            this.Height = Math.Max(originalHeight, _initialHeight + totalHeight);

            // 調整父容器高度
            AdjustParentHeights(totalHeight);
        }

        /// <summary>
        /// 載入回覆元件
        /// </summary>
        /// <returns>回覆元件總高度</returns>
        private int LoadReplyComponents()
        {
            int totalHeight = 0;

            // 創建交替顏色
            Color bgColor = this.BackColor == Color.White ? Color.WhiteSmoke : Color.White;

            foreach (var reply in comment.children)
            {
                var replyComponent = CreateReplyComponent(reply, bgColor);
                this.commentContainer.Controls.Add(replyComponent);

                // 累加高度
                totalHeight += replyComponent.Height + REPLY_PADDING;
            }

            return totalHeight;
        }

        /// <summary>
        /// 創建回覆元件
        /// </summary>
        private CommentComponent CreateReplyComponent(CommentsModel.Datum reply, Color bgColor)
        {
            return new CommentComponent(reply)
            {
                BackColor = bgColor,
                Width = this.commentContainer.Width - 10
            };
        }

        /// <summary>
        /// 調整父容器高度
        /// </summary>
        /// <param name="heightDelta">高度變化量</param>
        private void AdjustParentHeights(int heightDelta)
        {
            if (!(this.Parent is FlowLayoutPanel parent)) return;

            // 調整直接父容器的高度
            parent.Height += heightDelta;

            // 如果嵌套在另一個 CommentComponent 中，同樣調整其高度
            if (parent.Parent is CommentComponent grandparent)
            {
                grandparent.Height += heightDelta;
            }
        }
    }
}