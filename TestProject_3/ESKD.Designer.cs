
namespace InvAddIn
{
    partial class ESKD
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ESKD));
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.lv = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.tv = new System.Windows.Forms.TreeView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bu_search = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // lv
            // 
            this.lv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lv.HideSelection = false;
            this.lv.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3});
            this.lv.Location = new System.Drawing.Point(190, 446);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(550, 117);
            this.lv.TabIndex = 0;
            this.lv.UseCompatibleStateImageBehavior = false;
            // 
            // cb1
            // 
            this.cb1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb1.FormattingEnabled = true;
            this.cb1.Location = new System.Drawing.Point(498, 12);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(241, 21);
            this.cb1.TabIndex = 1;
            // 
            // tv
            // 
            this.tv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tv.Location = new System.Drawing.Point(10, 39);
            this.tv.Name = "tv";
            this.tv.Size = new System.Drawing.Size(174, 524);
            this.tv.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(292, 20);
            this.textBox1.TabIndex = 3;
            // 
            // bu_search
            // 
            this.bu_search.Location = new System.Drawing.Point(307, 12);
            this.bu_search.Name = "bu_search";
            this.bu_search.Size = new System.Drawing.Size(60, 21);
            this.bu_search.TabIndex = 4;
            this.bu_search.Text = "Найти";
            this.bu_search.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "711111.png");
            this.imageList1.Images.SetKeyName(1, "711112.png");
            this.imageList1.Images.SetKeyName(2, "711113.png");
            this.imageList1.Images.SetKeyName(3, "711114.png");
            this.imageList1.Images.SetKeyName(4, "711115.png");
            this.imageList1.Images.SetKeyName(5, "711116.png");
            this.imageList1.Images.SetKeyName(6, "711117.png");
            this.imageList1.Images.SetKeyName(7, "711118.png");
            this.imageList1.Images.SetKeyName(8, "711121.png");
            this.imageList1.Images.SetKeyName(9, "711123-1.png");
            this.imageList1.Images.SetKeyName(10, "711125.png");
            this.imageList1.Images.SetKeyName(11, "711127.png");
            this.imageList1.Images.SetKeyName(12, "711131.png");
            this.imageList1.Images.SetKeyName(13, "711132-1.png");
            this.imageList1.Images.SetKeyName(14, "711133.png");
            this.imageList1.Images.SetKeyName(15, "711134.png");
            this.imageList1.Images.SetKeyName(16, "711135.png");
            this.imageList1.Images.SetKeyName(17, "711136.png");
            this.imageList1.Images.SetKeyName(18, "711137.png");
            this.imageList1.Images.SetKeyName(19, "711141.png");
            this.imageList1.Images.SetKeyName(20, "711142.png");
            this.imageList1.Images.SetKeyName(21, "711143.png");
            this.imageList1.Images.SetKeyName(22, "711145.png");
            this.imageList1.Images.SetKeyName(23, "721112.png");
            this.imageList1.Images.SetKeyName(24, "721114.png");
            this.imageList1.Images.SetKeyName(25, "721115.png");
            this.imageList1.Images.SetKeyName(26, "721116.png");
            this.imageList1.Images.SetKeyName(27, "731111.png");
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(190, 101);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(549, 339);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // ESKD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 575);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.bu_search);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tv);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.lv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ESKD";
            this.Text = "ESKD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.TreeView tv;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bu_search;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView listView1;
    }
}