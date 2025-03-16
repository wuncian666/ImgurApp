namespace ImgurApp.Components
{
    partial class GalleryItem
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
            this.upLabel = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.downLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.commentCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.views = new System.Windows.Forms.Label();
            this.imgurPicture = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgurPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // upLabel
            // 
            this.upLabel.AutoSize = true;
            this.upLabel.Font = new System.Drawing.Font("新細明體", 20F);
            this.upLabel.Location = new System.Drawing.Point(-2, 177);
            this.upLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.upLabel.Name = "upLabel";
            this.upLabel.Size = new System.Drawing.Size(33, 40);
            this.upLabel.TabIndex = 0;
            this.upLabel.Text = "⬆";
            this.upLabel.Click += new System.EventHandler(this.VoteUp_Click);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Location = new System.Drawing.Point(26, 194);
            this.score.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(32, 18);
            this.score.TabIndex = 1;
            this.score.Text = "292";
            // 
            // downLabel
            // 
            this.downLabel.AutoSize = true;
            this.downLabel.Font = new System.Drawing.Font("新細明體", 20F);
            this.downLabel.Location = new System.Drawing.Point(54, 178);
            this.downLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.downLabel.Name = "downLabel";
            this.downLabel.Size = new System.Drawing.Size(33, 40);
            this.downLabel.TabIndex = 2;
            this.downLabel.Text = "⬇";
            this.downLabel.Click += new System.EventHandler(this.VoteDown_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("新細明體", 20F);
            this.label4.Location = new System.Drawing.Point(78, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 45);
            this.label4.TabIndex = 3;
            this.label4.Text = "💬";
            // 
            // commentCount
            // 
            this.commentCount.AutoSize = true;
            this.commentCount.Location = new System.Drawing.Point(135, 194);
            this.commentCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.commentCount.Name = "commentCount";
            this.commentCount.Size = new System.Drawing.Size(32, 18);
            this.commentCount.TabIndex = 4;
            this.commentCount.Text = "124";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 20F);
            this.label6.Location = new System.Drawing.Point(168, 180);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 40);
            this.label6.TabIndex = 5;
            this.label6.Text = "👁️";
            // 
            // views
            // 
            this.views.AutoSize = true;
            this.views.Location = new System.Drawing.Point(219, 194);
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
            this.imgurPicture.Size = new System.Drawing.Size(279, 147);
            this.imgurPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgurPicture.TabIndex = 7;
            this.imgurPicture.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(3, 151);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(50, 18);
            this.titleLabel.TabIndex = 8;
            this.titleLabel.Text = "label2";
            // 
            // GalleryItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.imgurPicture);
            this.Controls.Add(this.views);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.commentCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.downLabel);
            this.Controls.Add(this.score);
            this.Controls.Add(this.upLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GalleryItem";
            this.Size = new System.Drawing.Size(280, 219);
            ((System.ComponentModel.ISupportInitialize)(this.imgurPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label upLabel;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label downLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label commentCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label views;
        private System.Windows.Forms.PictureBox imgurPicture;
        private System.Windows.Forms.Label titleLabel;
    }
}
