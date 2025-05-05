namespace ImgurApp.Components.ImageItemComponent
{
    partial class AlbumItemComponent
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.views = new System.Windows.Forms.Label();
            this.viewsIcon = new System.Windows.Forms.Label();
            this.commentCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.container = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.container.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(475, 350);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(27, 371);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(41, 18);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Title";
            // 
            // views
            // 
            this.views.AutoSize = true;
            this.views.Location = new System.Drawing.Point(371, 33);
            this.views.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.views.Name = "views";
            this.views.Size = new System.Drawing.Size(40, 18);
            this.views.TabIndex = 10;
            this.views.Text = "3967";
            // 
            // viewsIcon
            // 
            this.viewsIcon.Font = new System.Drawing.Font("新細明體", 20F);
            this.viewsIcon.Location = new System.Drawing.Point(320, 19);
            this.viewsIcon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.viewsIcon.Name = "viewsIcon";
            this.viewsIcon.Size = new System.Drawing.Size(45, 45);
            this.viewsIcon.TabIndex = 9;
            this.viewsIcon.Text = "👁️";
            // 
            // commentCount
            // 
            this.commentCount.AutoSize = true;
            this.commentCount.Location = new System.Drawing.Point(278, 33);
            this.commentCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.commentCount.Name = "commentCount";
            this.commentCount.Size = new System.Drawing.Size(32, 18);
            this.commentCount.TabIndex = 8;
            this.commentCount.Text = "124";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("新細明體", 20F);
            this.label4.Location = new System.Drawing.Point(234, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 45);
            this.label4.TabIndex = 7;
            this.label4.Text = "💬";
            // 
            // container
            // 
            this.container.Controls.Add(this.viewsIcon);
            this.container.Controls.Add(this.views);
            this.container.Controls.Add(this.label4);
            this.container.Controls.Add(this.commentCount);
            this.container.Location = new System.Drawing.Point(30, 392);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(430, 80);
            this.container.TabIndex = 11;
            // 
            // AlbumItemComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.container);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AlbumItemComponent";
            this.Size = new System.Drawing.Size(475, 475);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label views;
        private System.Windows.Forms.Label viewsIcon;
        private System.Windows.Forms.Label commentCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel container;
    }
}
