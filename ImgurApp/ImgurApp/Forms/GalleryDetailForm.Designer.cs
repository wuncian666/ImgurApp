using ImgurApp.Components.CommentComponent;

namespace ImgurApp.Forms
{
    partial class GalleryDetailForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                CommentEvents.ReplyButtonClicked -= OnCommentReplyButtonClicked;
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.imageContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.favoriteLabel = new System.Windows.Forms.Label();
            this.commentLabel = new System.Windows.Forms.Label();
            this.voteContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.commentsContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.commentBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.插入圖片ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPost = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("新細明體", 12F);
            this.userNameLabel.Location = new System.Drawing.Point(77, 21);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(33, 16);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "user";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("新細明體", 18F);
            this.titleLabel.Location = new System.Drawing.Point(76, 51);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(52, 24);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Title";
            // 
            // imageContainer
            // 
            this.imageContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.imageContainer.AutoScroll = true;
            this.imageContainer.Location = new System.Drawing.Point(80, 91);
            this.imageContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imageContainer.Name = "imageContainer";
            this.imageContainer.Size = new System.Drawing.Size(359, 377);
            this.imageContainer.TabIndex = 2;
            // 
            // favoriteLabel
            // 
            this.favoriteLabel.Font = new System.Drawing.Font("新細明體", 20F);
            this.favoriteLabel.Location = new System.Drawing.Point(25, 380);
            this.favoriteLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.favoriteLabel.Name = "favoriteLabel";
            this.favoriteLabel.Size = new System.Drawing.Size(32, 32);
            this.favoriteLabel.TabIndex = 6;
            this.favoriteLabel.Text = "♡";
            this.favoriteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.favoriteLabel.Click += new System.EventHandler(this.FavoriteLabel_ClickAsync);
            // 
            // commentLabel
            // 
            this.commentLabel.Font = new System.Drawing.Font("新細明體", 20F);
            this.commentLabel.Location = new System.Drawing.Point(25, 420);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(32, 32);
            this.commentLabel.TabIndex = 7;
            this.commentLabel.Text = "💬";
            this.commentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // voteContainer
            // 
            this.voteContainer.AutoScroll = true;
            this.voteContainer.Font = new System.Drawing.Font("新細明體", 9F);
            this.voteContainer.Location = new System.Drawing.Point(29, 91);
            this.voteContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.voteContainer.Name = "voteContainer";
            this.voteContainer.Size = new System.Drawing.Size(33, 267);
            this.voteContainer.TabIndex = 8;
            // 
            // commentsContainer
            // 
            this.commentsContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commentsContainer.AutoScroll = true;
            this.commentsContainer.Location = new System.Drawing.Point(489, 121);
            this.commentsContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.commentsContainer.Name = "commentsContainer";
            this.commentsContainer.Size = new System.Drawing.Size(355, 347);
            this.commentsContainer.TabIndex = 2;
            // 
            // commentBox
            // 
            this.commentBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.commentBox.ContextMenuStrip = this.contextMenuStrip1;
            this.commentBox.Location = new System.Drawing.Point(489, 9);
            this.commentBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.commentBox.Multiline = true;
            this.commentBox.Name = "commentBox";
            this.commentBox.Size = new System.Drawing.Size(341, 68);
            this.commentBox.TabIndex = 9;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.插入圖片ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 26);
            // 
            // 插入圖片ToolStripMenuItem
            // 
            this.插入圖片ToolStripMenuItem.Name = "插入圖片ToolStripMenuItem";
            this.插入圖片ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.插入圖片ToolStripMenuItem.Text = "插入圖片";
            this.插入圖片ToolStripMenuItem.Click += new System.EventHandler(this.InsertImage_ClickAsync);
            // 
            // btnPost
            // 
            this.btnPost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPost.Location = new System.Drawing.Point(737, 79);
            this.btnPost.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(91, 31);
            this.btnPost.TabIndex = 10;
            this.btnPost.Text = "Post";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.BtnPost_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(489, 85);
            this.idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(49, 12);
            this.idLabel.TabIndex = 11;
            this.idLabel.Text = "GellaryId";
            // 
            // GalleryDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 468);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.commentBox);
            this.Controls.Add(this.voteContainer);
            this.Controls.Add(this.commentLabel);
            this.Controls.Add(this.favoriteLabel);
            this.Controls.Add(this.commentsContainer);
            this.Controls.Add(this.imageContainer);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.userNameLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GalleryDetailForm";
            this.Text = "GalleryDetailForm";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.FlowLayoutPanel imageContainer;
        private System.Windows.Forms.Label favoriteLabel;
        private System.Windows.Forms.Label commentLabel;
        private System.Windows.Forms.FlowLayoutPanel voteContainer;
        private System.Windows.Forms.FlowLayoutPanel commentsContainer;
        private System.Windows.Forms.TextBox commentBox;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 插入圖片ToolStripMenuItem;
    }
}