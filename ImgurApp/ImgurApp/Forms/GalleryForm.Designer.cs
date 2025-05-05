namespace ImgurApp
{
    partial class GalleryForm
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

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.queryTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.galleryContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.sortComboBox = new System.Windows.Forms.ComboBox();
            this.sortLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.windowComboBox = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.pageLabel = new System.Windows.Forms.Label();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.相簿ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.相片上傳ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagination1 = new ImgurApp.Components.PaginationComponent.PaginationComponent();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.searchPanel.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(956, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "查詢";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // queryTextBox
            // 
            this.queryTextBox.Location = new System.Drawing.Point(68, 28);
            this.queryTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.queryTextBox.Name = "queryTextBox";
            this.queryTextBox.Size = new System.Drawing.Size(232, 29);
            this.queryTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "查詢";
            // 
            // galleryContainer
            // 
            this.galleryContainer.AutoScroll = true;
            this.galleryContainer.Location = new System.Drawing.Point(68, 157);
            this.galleryContainer.Margin = new System.Windows.Forms.Padding(4);
            this.galleryContainer.Name = "galleryContainer";
            this.galleryContainer.Size = new System.Drawing.Size(1089, 538);
            this.galleryContainer.TabIndex = 3;
            // 
            // sortComboBox
            // 
            this.sortComboBox.FormattingEnabled = true;
            this.sortComboBox.Location = new System.Drawing.Point(382, 32);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.Size = new System.Drawing.Size(121, 26);
            this.sortComboBox.TabIndex = 4;
            // 
            // sortLabel
            // 
            this.sortLabel.AutoSize = true;
            this.sortLabel.Location = new System.Drawing.Point(316, 39);
            this.sortLabel.Name = "sortLabel";
            this.sortLabel.Size = new System.Drawing.Size(44, 18);
            this.sortLabel.TabIndex = 5;
            this.sortLabel.Text = "排序";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(508, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "時間區間";
            // 
            // windowComboBox
            // 
            this.windowComboBox.FormattingEnabled = true;
            this.windowComboBox.Location = new System.Drawing.Point(596, 32);
            this.windowComboBox.Name = "windowComboBox";
            this.windowComboBox.Size = new System.Drawing.Size(121, 26);
            this.windowComboBox.TabIndex = 7;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(789, 28);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 29);
            this.numericUpDown1.TabIndex = 8;
            // 
            // pageLabel
            // 
            this.pageLabel.AutoSize = true;
            this.pageLabel.Location = new System.Drawing.Point(740, 39);
            this.pageLabel.Name = "pageLabel";
            this.pageLabel.Size = new System.Drawing.Size(44, 18);
            this.pageLabel.TabIndex = 9;
            this.pageLabel.Text = "頁數";
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.pageLabel);
            this.searchPanel.Controls.Add(this.button1);
            this.searchPanel.Controls.Add(this.label1);
            this.searchPanel.Controls.Add(this.numericUpDown1);
            this.searchPanel.Controls.Add(this.queryTextBox);
            this.searchPanel.Controls.Add(this.windowComboBox);
            this.searchPanel.Controls.Add(this.sortComboBox);
            this.searchPanel.Controls.Add(this.label2);
            this.searchPanel.Controls.Add(this.sortLabel);
            this.searchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchPanel.Location = new System.Drawing.Point(0, 0);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(1258, 100);
            this.searchPanel.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.相簿ToolStripMenuItem,
            this.相片上傳ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 64);
            // 
            // 相簿ToolStripMenuItem
            // 
            this.相簿ToolStripMenuItem.Name = "相簿ToolStripMenuItem";
            this.相簿ToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
            this.相簿ToolStripMenuItem.Text = "相簿";
            this.相簿ToolStripMenuItem.Click += new System.EventHandler(this.相簿ToolStripMenuItem_Click);
            // 
            // 相片上傳ToolStripMenuItem
            // 
            this.相片上傳ToolStripMenuItem.Name = "相片上傳ToolStripMenuItem";
            this.相片上傳ToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
            this.相片上傳ToolStripMenuItem.Text = "相片上傳";
            this.相片上傳ToolStripMenuItem.Click += new System.EventHandler(this.相片上傳ToolStripMenuItem_Click);
            // 
            // pagination1
            // 
            this.pagination1.ItemPrePages = 0;
            this.pagination1.Location = new System.Drawing.Point(176, 710);
            this.pagination1.Margin = new System.Windows.Forms.Padding(2);
            this.pagination1.Name = "pagination1";
            this.pagination1.Size = new System.Drawing.Size(933, 82);
            this.pagination1.TabIndex = 4;
            // 
            // GalleryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 744);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.pagination1);
            this.Controls.Add(this.galleryContainer);
            this.Controls.Add(this.searchPanel);
            this.Name = "GalleryForm";
            this.Text = "GallerySearchForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox queryTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel galleryContainer;
        private System.Windows.Forms.ComboBox sortComboBox;
        private System.Windows.Forms.Label sortLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox windowComboBox;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label pageLabel;
        private System.Windows.Forms.Panel searchPanel;
        private Components.PaginationComponent.PaginationComponent pagination1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 相簿ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 相片上傳ToolStripMenuItem;
    }
}

