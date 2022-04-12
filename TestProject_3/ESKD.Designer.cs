
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ESKD));
            this.lv = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tb_search = new System.Windows.Forms.TextBox();
            this.cb_class_eskd = new System.Windows.Forms.ComboBox();
            this.button_expert = new System.Windows.Forms.Button();
            this.treeView_eskd = new System.Windows.Forms.TreeView();
            this.button_classsearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_test = new System.Windows.Forms.TextBox();
            this.bu_all_ESKD = new System.Windows.Forms.Button();
            this.bu_favourites = new System.Windows.Forms.Button();
            this.bu_search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv
            // 
            this.lv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lv.HideSelection = false;
            this.lv.Location = new System.Drawing.Point(353, 109);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(1026, 500);
            this.lv.TabIndex = 0;
            this.lv.TileSize = new System.Drawing.Size(100, 100);
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.DoubleClick += new System.EventHandler(this.lv_DoubleClick);
            // 
            // tb_search
            // 
            this.tb_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_search.Location = new System.Drawing.Point(12, 40);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(257, 26);
            this.tb_search.TabIndex = 3;
            // 
            // cb_class_eskd
            // 
            this.cb_class_eskd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_class_eskd.FormattingEnabled = true;
            this.cb_class_eskd.Location = new System.Drawing.Point(1178, 12);
            this.cb_class_eskd.Name = "cb_class_eskd";
            this.cb_class_eskd.Size = new System.Drawing.Size(201, 21);
            this.cb_class_eskd.TabIndex = 5;
            // 
            // button_expert
            // 
            this.button_expert.BackColor = System.Drawing.Color.Transparent;
            this.button_expert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_expert.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_expert.Location = new System.Drawing.Point(354, 11);
            this.button_expert.Name = "button_expert";
            this.button_expert.Size = new System.Drawing.Size(112, 55);
            this.button_expert.TabIndex = 6;
            this.button_expert.Text = "Экспертный поиск";
            this.button_expert.UseVisualStyleBackColor = false;
            this.button_expert.Click += new System.EventHandler(this.button_expert_Click);
            // 
            // treeView_eskd
            // 
            this.treeView_eskd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeView_eskd.Location = new System.Drawing.Point(12, 109);
            this.treeView_eskd.Name = "treeView_eskd";
            this.treeView_eskd.Size = new System.Drawing.Size(335, 500);
            this.treeView_eskd.TabIndex = 7;
            this.treeView_eskd.DoubleClick += new System.EventHandler(this.treeView_eskd_DoubleClick);
            // 
            // button_classsearch
            // 
            this.button_classsearch.BackColor = System.Drawing.Color.Transparent;
            this.button_classsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_classsearch.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_classsearch.Location = new System.Drawing.Point(472, 11);
            this.button_classsearch.Name = "button_classsearch";
            this.button_classsearch.Size = new System.Drawing.Size(112, 55);
            this.button_classsearch.TabIndex = 8;
            this.button_classsearch.Text = "Поиск по классу";
            this.button_classsearch.UseVisualStyleBackColor = false;
            this.button_classsearch.Click += new System.EventHandler(this.button_classsearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Поиск по коду";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Поиск по дереву";
            // 
            // tb_test
            // 
            this.tb_test.Location = new System.Drawing.Point(353, 72);
            this.tb_test.Multiline = true;
            this.tb_test.Name = "tb_test";
            this.tb_test.Size = new System.Drawing.Size(1026, 31);
            this.tb_test.TabIndex = 11;
            // 
            // bu_all_ESKD
            // 
            this.bu_all_ESKD.BackColor = System.Drawing.Color.Transparent;
            this.bu_all_ESKD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bu_all_ESKD.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bu_all_ESKD.Location = new System.Drawing.Point(1060, 12);
            this.bu_all_ESKD.Name = "bu_all_ESKD";
            this.bu_all_ESKD.Size = new System.Drawing.Size(112, 54);
            this.bu_all_ESKD.TabIndex = 12;
            this.bu_all_ESKD.Text = "Отобразить все схемы";
            this.bu_all_ESKD.UseVisualStyleBackColor = false;
            this.bu_all_ESKD.Click += new System.EventHandler(this.bu_all_ESKD_Click);
            // 
            // bu_favourites
            // 
            this.bu_favourites.BackColor = System.Drawing.Color.Transparent;
            this.bu_favourites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bu_favourites.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bu_favourites.Location = new System.Drawing.Point(590, 11);
            this.bu_favourites.Name = "bu_favourites";
            this.bu_favourites.Size = new System.Drawing.Size(112, 55);
            this.bu_favourites.TabIndex = 13;
            this.bu_favourites.Text = "Избранное";
            this.bu_favourites.UseVisualStyleBackColor = false;
            this.bu_favourites.Click += new System.EventHandler(this.button1_Click);
            // 
            // bu_search
            // 
            this.bu_search.BackColor = System.Drawing.Color.Transparent;
            this.bu_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bu_search.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bu_search.Location = new System.Drawing.Point(275, 11);
            this.bu_search.Name = "bu_search";
            this.bu_search.Size = new System.Drawing.Size(61, 55);
            this.bu_search.TabIndex = 14;
            this.bu_search.Text = "Поиск";
            this.bu_search.UseVisualStyleBackColor = false;
            this.bu_search.Click += new System.EventHandler(this.bu_search_Click);
            // 
            // ESKD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1391, 621);
            this.Controls.Add(this.bu_search);
            this.Controls.Add(this.bu_favourites);
            this.Controls.Add(this.bu_all_ESKD);
            this.Controls.Add(this.tb_test);
            this.Controls.Add(this.button_classsearch);
            this.Controls.Add(this.treeView_eskd);
            this.Controls.Add(this.button_expert);
            this.Controls.Add(this.cb_class_eskd);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.lv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ESKD";
            this.Text = "Классифкатор ЕСКД";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ESKD_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ESKD_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
       
        private System.Windows.Forms.ColumnHeader columnHeader1;
        public System.Windows.Forms.TextBox tb_search;
        public System.Windows.Forms.ListView lv;
        private System.Windows.Forms.ComboBox cb_class_eskd;
        private System.Windows.Forms.Button button_expert;
        private System.Windows.Forms.TreeView treeView_eskd;
        private System.Windows.Forms.Button button_classsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_test;
        private System.Windows.Forms.Button bu_all_ESKD;
        private System.Windows.Forms.Button bu_favourites;
        private System.Windows.Forms.Button bu_search;
    }
}