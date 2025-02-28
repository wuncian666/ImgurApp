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
            this.label1 = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.commentCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.views = new System.Windows.Forms.Label();
            this.imgurPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgurPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 20F);
            this.label1.Location = new System.Drawing.Point(-1, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "⬆";
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Location = new System.Drawing.Point(17, 129);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(23, 12);
            this.score.TabIndex = 1;
            this.score.Text = "292";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 20F);
            this.label3.Location = new System.Drawing.Point(36, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "⬇";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("新細明體", 20F);
            this.label4.Location = new System.Drawing.Point(52, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "💬";
            // 
            // commentCount
            // 
            this.commentCount.AutoSize = true;
            this.commentCount.Location = new System.Drawing.Point(90, 129);
            this.commentCount.Name = "commentCount";
            this.commentCount.Size = new System.Drawing.Size(23, 12);
            this.commentCount.TabIndex = 4;
            this.commentCount.Text = "124";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 20F);
            this.label6.Location = new System.Drawing.Point(112, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 27);
            this.label6.TabIndex = 5;
            this.label6.Text = "👁️";
            // 
            // views
            // 
            this.views.AutoSize = true;
            this.views.Location = new System.Drawing.Point(146, 129);
            this.views.Name = "views";
            this.views.Size = new System.Drawing.Size(29, 12);
            this.views.TabIndex = 6;
            this.views.Text = "3967";
            // 
            // imgurPicture
            // 
            this.imgurPicture.Location = new System.Drawing.Point(0, 0);
            this.imgurPicture.Name = "imgurPicture";
            this.imgurPicture.Size = new System.Drawing.Size(186, 120);
            this.imgurPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgurPicture.TabIndex = 7;
            this.imgurPicture.TabStop = false;
            // 
            // GalleryItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.imgurPicture);
            this.Controls.Add(this.views);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.commentCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.score);
            this.Controls.Add(this.label1);
            this.Name = "GalleryItem";
            this.Size = new System.Drawing.Size(187, 146);
            ((System.ComponentModel.ISupportInitialize)(this.imgurPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label commentCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label views;
        private System.Windows.Forms.PictureBox imgurPicture;
    }
}
