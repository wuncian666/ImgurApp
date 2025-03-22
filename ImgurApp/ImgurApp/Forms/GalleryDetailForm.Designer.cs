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
            this.userNameLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.imageContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.loveLabel = new System.Windows.Forms.Label();
            this.commentLabel = new System.Windows.Forms.Label();
            this.voteContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("新細明體", 12F);
            this.userNameLabel.Location = new System.Drawing.Point(116, 32);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(48, 24);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "user";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("新細明體", 18F);
            this.titleLabel.Location = new System.Drawing.Point(114, 77);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(78, 36);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Title";
            // 
            // imageContainer
            // 
            this.imageContainer.AutoScroll = true;
            this.imageContainer.Location = new System.Drawing.Point(120, 137);
            this.imageContainer.Name = "imageContainer";
            this.imageContainer.Size = new System.Drawing.Size(658, 541);
            this.imageContainer.TabIndex = 2;
            // 
            // loveLabel
            // 
            this.loveLabel.Font = new System.Drawing.Font("新細明體", 20F);
            this.loveLabel.Location = new System.Drawing.Point(37, 419);
            this.loveLabel.Name = "loveLabel";
            this.loveLabel.Size = new System.Drawing.Size(30, 32);
            this.loveLabel.TabIndex = 6;
            this.loveLabel.Text = "♡";
            // 
            // commentLabel
            // 
            this.commentLabel.Font = new System.Drawing.Font("新細明體", 20F);
            this.commentLabel.Location = new System.Drawing.Point(37, 515);
            this.commentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(48, 48);
            this.commentLabel.TabIndex = 7;
            this.commentLabel.Text = "💬";
            this.commentLabel.Click += new System.EventHandler(this.commentLabel_Click);
            // 
            // voteContainer
            // 
            this.voteContainer.Location = new System.Drawing.Point(44, 137);
            this.voteContainer.Name = "voteContainer";
            this.voteContainer.Size = new System.Drawing.Size(53, 225);
            this.voteContainer.TabIndex = 8;
            // 
            // GalleryDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 717);
            this.Controls.Add(this.voteContainer);
            this.Controls.Add(this.commentLabel);
            this.Controls.Add(this.loveLabel);
            this.Controls.Add(this.imageContainer);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.userNameLabel);
            this.Name = "GalleryDetailForm";
            this.Text = "GalleryDetailForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.FlowLayoutPanel imageContainer;
        private System.Windows.Forms.Label loveLabel;
        private System.Windows.Forms.Label commentLabel;
        private System.Windows.Forms.FlowLayoutPanel voteContainer;
    }
}