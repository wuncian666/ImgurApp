namespace ImgurApp.Components
{
    partial class GalleryItemForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.commentCount = new System.Windows.Forms.Label();
            this.viewsIcon = new System.Windows.Forms.Label();
            this.views = new System.Windows.Forms.Label();
            this.imgurPicture = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.voteContainer = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.imgurPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("新細明體", 20F);
            this.label4.Location = new System.Drawing.Point(196, 260);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 45);
            this.label4.TabIndex = 3;
            this.label4.Text = "💬";
            // 
            // commentCount
            // 
            this.commentCount.AutoSize = true;
            this.commentCount.Location = new System.Drawing.Point(240, 276);
            this.commentCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.commentCount.Name = "commentCount";
            this.commentCount.Size = new System.Drawing.Size(32, 18);
            this.commentCount.TabIndex = 4;
            this.commentCount.Text = "124";
            // 
            // viewsIcon
            // 
            this.viewsIcon.Font = new System.Drawing.Font("新細明體", 20F);
            this.viewsIcon.Location = new System.Drawing.Point(282, 262);
            this.viewsIcon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.viewsIcon.Name = "viewsIcon";
            this.viewsIcon.Size = new System.Drawing.Size(45, 45);
            this.viewsIcon.TabIndex = 5;
            this.viewsIcon.Text = "👁️";
            // 
            // views
            // 
            this.views.AutoSize = true;
            this.views.Location = new System.Drawing.Point(333, 276);
            this.views.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.views.Name = "views";
            this.views.Size = new System.Drawing.Size(40, 18);
            this.views.TabIndex = 6;
            this.views.Text = "3967";
            // 
            // imgurPicture
            // 
            this.imgurPicture.Location = new System.Drawing.Point(0, 0);
            this.imgurPicture.Margin = new System.Windows.Forms.Padding(4);
            this.imgurPicture.Name = "imgurPicture";
            this.imgurPicture.Size = new System.Drawing.Size(394, 200);
            this.imgurPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgurPicture.TabIndex = 7;
            this.imgurPicture.TabStop = false;
            this.imgurPicture.Click += new System.EventHandler(this.OpenGalleryDetail_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(20, 218);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(41, 18);
            this.titleLabel.TabIndex = 8;
            this.titleLabel.Text = "Title";
            this.titleLabel.Click += new System.EventHandler(this.OpenGalleryDetail_Click);
            // 
            // voteContainer
            // 
            this.voteContainer.Location = new System.Drawing.Point(23, 260);
            this.voteContainer.Name = "voteContainer";
            this.voteContainer.Size = new System.Drawing.Size(136, 45);
            this.voteContainer.TabIndex = 9;
            // 
            // GalleryItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.voteContainer);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.imgurPicture);
            this.Controls.Add(this.views);
            this.Controls.Add(this.viewsIcon);
            this.Controls.Add(this.commentCount);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GalleryItemForm";
            this.Size = new System.Drawing.Size(394, 332);
            this.Click += new System.EventHandler(this.OpenGalleryDetail_Click);
            ((System.ComponentModel.ISupportInitialize)(this.imgurPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label commentCount;
        private System.Windows.Forms.Label viewsIcon;
        private System.Windows.Forms.Label views;
        private System.Windows.Forms.PictureBox imgurPicture;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.FlowLayoutPanel voteContainer;
    }
}
