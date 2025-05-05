using ImgurAPI.Models;
using ImgurApp.Components.VoteComponent;
using ImgurApp.Presenters;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static ImgurApp.Contracts.CommentContentContract;

namespace ImgurApp.Components.CommentComponent
{
    public partial class CommentComponent : UserControl, ICommentContentView
    {
        public string CommentId => _comment.id.ToString();

        private readonly ICommentContentPresenter _commentContentPresenter;

        private readonly CommentsModel.Datum _comment;
        private VoteModel _voteModel;

        private int _initialHeight;
        private int _maxHeight = 0;
        private bool _isRepliesShowed = false;
        private const int REPLY_PADDING = 5;

        public CommentComponent(CommentsModel.Datum comment)
        {
            InitializeComponent();
            this._comment = comment;
            this._commentContentPresenter = new CommentContentPresenter(this);

            this.InitCommentComponent();
            this.InitVoteComponent();
        }

        private void RenderCommentToContainer(string comment)
        {
            this._commentContentPresenter.AnalyzeComment(comment);
        }

        public void AddCommentPanelToContainer(Control control)
        {
            if (control == null) return;

            this.contentContainer.Controls.Add(control);
            AdjustContainerHeight(control.Height + 5);
        }

        public void AddReplyComment(CommentsModel.Datum comment)
        {
            if (_comment.children == null)
            {
                _comment.children = new CommentsModel.Datum[] { comment };
            }
            else
            {
                var children = _comment.children.ToList();
                children.Add(comment);
                _comment.children = children.ToArray();
            }

            this.ShowReplies();
        }

        public void EnableReplyBtn()
        {
            this.repliesBtn.Enabled = true;
            this._isRepliesShowed = true;
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

        private void InitCommentComponent()
        {
            this.BorderStyle = BorderStyle.FixedSingle;
            this.UserLabel.Text = this._comment.author;
            this.repliesBtn.Enabled = this._comment.children?.Count() > 0;
            this._initialHeight = this.Height;
            this.RenderCommentToContainer(this._comment.comment);
        }

        private void InitVoteComponent()
        {
            this._voteModel = new VoteModel
            {
                VoteTarget = VoteTarget.Comment,
                ItemId = _comment.id.ToString(),
                NewScore = _comment.points,
                OldScore = _comment.points,
                UpLabelColor = Color.Black,
                DownLabelColor = Color.Black
            };

            var voteComponentConfig = new VoteComponentConfig
            {
                Direction = VoteDirection.Horizontal,
                RefContainerSize = this.voteContainer.Size,
                FontSize = this.voteContainer.Font
            };
            var voteComponent = new VoteComponent.VoteComponent(this._voteModel, voteComponentConfig);
            this.voteContainer.Controls.Add(voteComponent);
        }

        private void RepliesBtn_Click(object sender, EventArgs e)
        {
            this.ToggleRepliesVisibility();
        }

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

            int totalHeight = this.LoadReplyComponents();

            this._maxHeight = totalHeight;// 保存總高度以便關閉時使用

            this.commentContainer.Size = new Size(commentContainer.Width, totalHeight);

            int originalHeight = this.Height;
            this.Height = Math.Max(originalHeight, _initialHeight + totalHeight);

            this.AdjustParentHeights(totalHeight);
        }

        /// <summary>
        /// 載入回覆元件
        /// </summary>
        /// <returns>回覆元件總高度</returns>
        private int LoadReplyComponents()
        {
            int totalHeight = 0;

            Color bgColor = this.BackColor == Color.White ? Color.WhiteSmoke : Color.White;

            foreach (var reply in _comment.children)
            {
                var replyComponent = CreateReplyComponent(reply, bgColor);
                this.commentContainer.Controls.Add(replyComponent);

                totalHeight += replyComponent.Height + REPLY_PADDING;
            }

            return totalHeight;
        }

        /// <summary>
        /// 創建回覆元件
        /// </summary>
        private CommentComponent CreateReplyComponent(CommentsModel.Datum reply, Color bgColor)
        {
            var newComponent = new CommentComponent(reply)
            {
                BackColor = bgColor,
                Width = this.commentContainer.Width - 10
            };

            return newComponent;
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

        private void BtnReplyComment_Click(object sender, EventArgs e)
        {
            CommentEvents.OnReplyButtonClicked(this);
        }
    }
}