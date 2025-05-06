namespace ImgurApp.Forms
{
    partial class ImageUploadForm
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
            this.imageContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.AlbumComboBox = new System.Windows.Forms.ComboBox();
            this.newAlbumTextBox = new System.Windows.Forms.TextBox();
            this.uploadToAlbumRadioButton = new System.Windows.Forms.RadioButton();
            this.uploadToNewAlbumRadioButton = new System.Windows.Forms.RadioButton();
            this.uploadBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(12, 12);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(639, 29);
            this.titleBox.TabIndex = 1;
            // 
            // imageContainer
            // 
            this.imageContainer.AutoScroll = true;
            this.imageContainer.Location = new System.Drawing.Point(13, 60);
            this.imageContainer.Name = "imageContainer";
            this.imageContainer.Size = new System.Drawing.Size(638, 748);
            this.imageContainer.TabIndex = 6;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(716, 60);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(160, 22);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "是否公開到社群";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // AlbumComboBox
            // 
            this.AlbumComboBox.FormattingEnabled = true;
            this.AlbumComboBox.Location = new System.Drawing.Point(716, 140);
            this.AlbumComboBox.Name = "AlbumComboBox";
            this.AlbumComboBox.Size = new System.Drawing.Size(121, 26);
            this.AlbumComboBox.TabIndex = 9;
            // 
            // newAlbumTextBox
            // 
            this.newAlbumTextBox.Location = new System.Drawing.Point(716, 338);
            this.newAlbumTextBox.Name = "newAlbumTextBox";
            this.newAlbumTextBox.Size = new System.Drawing.Size(100, 29);
            this.newAlbumTextBox.TabIndex = 10;
            // 
            // uploadToAlbumRadioButton
            // 
            this.uploadToAlbumRadioButton.AutoSize = true;
            this.uploadToAlbumRadioButton.Location = new System.Drawing.Point(716, 112);
            this.uploadToAlbumRadioButton.Name = "uploadToAlbumRadioButton";
            this.uploadToAlbumRadioButton.Size = new System.Drawing.Size(177, 22);
            this.uploadToAlbumRadioButton.TabIndex = 12;
            this.uploadToAlbumRadioButton.TabStop = true;
            this.uploadToAlbumRadioButton.Text = "是否上傳到新相簿";
            this.uploadToAlbumRadioButton.UseVisualStyleBackColor = true;
            // 
            // uploadToNewAlbumRadioButton
            // 
            this.uploadToNewAlbumRadioButton.AutoSize = true;
            this.uploadToNewAlbumRadioButton.Location = new System.Drawing.Point(716, 291);
            this.uploadToNewAlbumRadioButton.Name = "uploadToNewAlbumRadioButton";
            this.uploadToNewAlbumRadioButton.Size = new System.Drawing.Size(141, 22);
            this.uploadToNewAlbumRadioButton.TabIndex = 13;
            this.uploadToNewAlbumRadioButton.TabStop = true;
            this.uploadToNewAlbumRadioButton.Text = "上傳到新相簿";
            this.uploadToNewAlbumRadioButton.UseVisualStyleBackColor = true;
            // 
            // uploadBtn
            // 
            this.uploadBtn.Location = new System.Drawing.Point(1144, 705);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(75, 23);
            this.uploadBtn.TabIndex = 14;
            this.uploadBtn.Text = "上傳";
            this.uploadBtn.UseVisualStyleBackColor = true;
            this.uploadBtn.Click += new System.EventHandler(this.UploadBtn_Click);
            // 
            // ImageUploadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 762);
            this.Controls.Add(this.uploadBtn);
            this.Controls.Add(this.uploadToNewAlbumRadioButton);
            this.Controls.Add(this.uploadToAlbumRadioButton);
            this.Controls.Add(this.newAlbumTextBox);
            this.Controls.Add(this.AlbumComboBox);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.imageContainer);
            this.Controls.Add(this.titleBox);
            this.Name = "ImageUploadForm";
            this.Text = "ImageUploadForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.FlowLayoutPanel imageContainer;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox AlbumComboBox;
        private System.Windows.Forms.TextBox newAlbumTextBox;
        private System.Windows.Forms.RadioButton uploadToAlbumRadioButton;
        private System.Windows.Forms.RadioButton uploadToNewAlbumRadioButton;
        private System.Windows.Forms.Button uploadBtn;
    }
}