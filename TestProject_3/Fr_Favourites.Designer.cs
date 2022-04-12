
namespace InvAddIn
{
    partial class Fr_Favourites
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fr_Favourites));
            this.lv_favourites = new System.Windows.Forms.ListView();
            this.tb_infoFavourites = new System.Windows.Forms.TextBox();
            this.bu_delFavourites = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_favourites
            // 
            this.lv_favourites.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lv_favourites.HideSelection = false;
            this.lv_favourites.Location = new System.Drawing.Point(12, 12);
            this.lv_favourites.Name = "lv_favourites";
            this.lv_favourites.Size = new System.Drawing.Size(573, 434);
            this.lv_favourites.TabIndex = 0;
            this.lv_favourites.UseCompatibleStateImageBehavior = false;
            this.lv_favourites.Click += new System.EventHandler(this.lv_favourites_Click);
            this.lv_favourites.DoubleClick += new System.EventHandler(this.lv_favourites_DoubleClick);
            // 
            // tb_infoFavourites
            // 
            this.tb_infoFavourites.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_infoFavourites.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_infoFavourites.Location = new System.Drawing.Point(591, 71);
            this.tb_infoFavourites.Multiline = true;
            this.tb_infoFavourites.Name = "tb_infoFavourites";
            this.tb_infoFavourites.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_infoFavourites.Size = new System.Drawing.Size(371, 375);
            this.tb_infoFavourites.TabIndex = 1;
            // 
            // bu_delFavourites
            // 
            this.bu_delFavourites.BackColor = System.Drawing.Color.Transparent;
            this.bu_delFavourites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bu_delFavourites.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bu_delFavourites.Location = new System.Drawing.Point(591, 12);
            this.bu_delFavourites.Name = "bu_delFavourites";
            this.bu_delFavourites.Size = new System.Drawing.Size(145, 53);
            this.bu_delFavourites.TabIndex = 2;
            this.bu_delFavourites.Text = "Убрать из избранного";
            this.bu_delFavourites.UseVisualStyleBackColor = false;
            this.bu_delFavourites.Click += new System.EventHandler(this.bu_delFavourites_Click);
            // 
            // Fr_Favourites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(974, 458);
            this.Controls.Add(this.bu_delFavourites);
            this.Controls.Add(this.tb_infoFavourites);
            this.Controls.Add(this.lv_favourites);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Fr_Favourites";
            this.Text = "Избранное";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bu_delFavourites;
        public System.Windows.Forms.ListView lv_favourites;
        public System.Windows.Forms.TextBox tb_infoFavourites;
    }
}