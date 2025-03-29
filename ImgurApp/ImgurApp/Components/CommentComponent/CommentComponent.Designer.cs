namespace ImgurApp.Components.CommentComponent
{
    partial class CommentComponent
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.voteContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.UserLabel = new System.Windows.Forms.Label();
            this.commentLabel = new System.Windows.Forms.Label();
            this.repliesBtn = new System.Windows.Forms.Button();
            this.commentContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // voteContainer
            // 
            this.voteContainer.Font = new System.Drawing.Font("新細明體", 12F);
            this.voteContainer.Location = new System.Drawing.Point(21, 91);
            this.voteContainer.Name = "voteContainer";
            this.voteContainer.Size = new System.Drawing.Size(363, 57);
            this.voteContainer.TabIndex = 0;
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("新細明體", 12F);
            this.UserLabel.Location = new System.Drawing.Point(17, 13);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(64, 24);
            this.UserLabel.TabIndex = 1;
            this.UserLabel.Text = "Name";
            // 
            // commentLabel
            // 
            this.commentLabel.Font = new System.Drawing.Font("新細明體", 12F);
            this.commentLabel.Location = new System.Drawing.Point(17, 49);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(500, 24);
            this.commentLabel.TabIndex = 2;
            this.commentLabel.Text = "Comment";
            // 
            // repliesBtn
            // 
            this.repliesBtn.Font = new System.Drawing.Font("新細明體", 12F);
            this.repliesBtn.Location = new System.Drawing.Point(390, 91);
            this.repliesBtn.Name = "repliesBtn";
            this.repliesBtn.Size = new System.Drawing.Size(127, 57);
            this.repliesBtn.TabIndex = 3;
            this.repliesBtn.Text = "replies";
            this.repliesBtn.UseVisualStyleBackColor = true;
            this.repliesBtn.Click += new System.EventHandler(this.RepliesBtn_Click);
            // 
            // commentContainer
            // 
            this.commentContainer.AutoScroll = true;
            this.commentContainer.Location = new System.Drawing.Point(3, 155);
            this.commentContainer.Name = "commentContainer";
            this.commentContainer.Size = new System.Drawing.Size(520, 10);
            this.commentContainer.TabIndex = 4;
            // 
            // CommentComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.commentContainer);
            this.Controls.Add(this.repliesBtn);
            this.Controls.Add(this.commentLabel);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.voteContainer);
            this.Name = "CommentComponent";
            this.Size = new System.Drawing.Size(520, 165);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel voteContainer;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label commentLabel;
        private System.Windows.Forms.Button repliesBtn;
        private System.Windows.Forms.FlowLayoutPanel commentContainer;
    }
}
