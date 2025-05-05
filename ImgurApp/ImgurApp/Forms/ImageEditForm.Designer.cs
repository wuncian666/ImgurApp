namespace ImgurApp.Forms
{
    partial class ImageEditForm
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
            this.titleBox = new System.Windows.Forms.TextBox();
            this.linkTextBox = new System.Windows.Forms.TextBox();
            this.linkLabel = new System.Windows.Forms.Label();
            this.imageContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(32, 28);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(639, 29);
            this.titleBox.TabIndex = 0;
            this.titleBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ModifyAlbumTitle_KeyUp);
            // 
            // linkTextBox
            // 
            this.linkTextBox.Location = new System.Drawing.Point(722, 93);
            this.linkTextBox.Name = "linkTextBox";
            this.linkTextBox.Size = new System.Drawing.Size(421, 29);
            this.linkTextBox.TabIndex = 3;
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.Location = new System.Drawing.Point(719, 63);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(116, 18);
            this.linkLabel.TabIndex = 4;
            this.linkLabel.Text = "GRAB A LINK";
            // 
            // imageContainer
            // 
            this.imageContainer.AutoScroll = true;
            this.imageContainer.Location = new System.Drawing.Point(32, 77);
            this.imageContainer.Name = "imageContainer";
            this.imageContainer.Size = new System.Drawing.Size(638, 748);
            this.imageContainer.TabIndex = 5;
            // 
            // ImageEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 744);
            this.Controls.Add(this.imageContainer);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.linkTextBox);
            this.Controls.Add(this.titleBox);
            this.Name = "ImageEditForm";
            this.Text = "ImageUploadForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox linkTextBox;
        private System.Windows.Forms.Label linkLabel;
        private System.Windows.Forms.FlowLayoutPanel imageContainer;
    }
}