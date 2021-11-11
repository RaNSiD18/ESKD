
namespace InvAddIn
{
    partial class InfoModels
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoModels));
            this.pb_drawing = new System.Windows.Forms.PictureBox();
            this.bt_open_3dmodels = new System.Windows.Forms.Button();
            this.bt_info = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_drawing)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_drawing
            // 
            this.pb_drawing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_drawing.BackColor = System.Drawing.SystemColors.Control;
            this.pb_drawing.Location = new System.Drawing.Point(12, 12);
            this.pb_drawing.Name = "pb_drawing";
            this.pb_drawing.Size = new System.Drawing.Size(554, 408);
            this.pb_drawing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_drawing.TabIndex = 0;
            this.pb_drawing.TabStop = false;
            // 
            // bt_open_3dmodels
            // 
            this.bt_open_3dmodels.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_open_3dmodels.Location = new System.Drawing.Point(441, 426);
            this.bt_open_3dmodels.Name = "bt_open_3dmodels";
            this.bt_open_3dmodels.Size = new System.Drawing.Size(125, 23);
            this.bt_open_3dmodels.TabIndex = 1;
            this.bt_open_3dmodels.Text = "Открыть 3d-модель";
            this.bt_open_3dmodels.UseVisualStyleBackColor = true;
            this.bt_open_3dmodels.Click += new System.EventHandler(this.bt_open_3dmodels_Click);
            // 
            // bt_info
            // 
            this.bt_info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_info.Location = new System.Drawing.Point(13, 426);
            this.bt_info.Name = "bt_info";
            this.bt_info.Size = new System.Drawing.Size(102, 23);
            this.bt_info.TabIndex = 2;
            this.bt_info.Text = "Справка о схеме";
            this.bt_info.UseVisualStyleBackColor = true;
            this.bt_info.Click += new System.EventHandler(this.bt_info_Click);
            // 
            // InfoModels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 459);
            this.Controls.Add(this.bt_info);
            this.Controls.Add(this.bt_open_3dmodels);
            this.Controls.Add(this.pb_drawing);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InfoModels";
            this.Text = "Схема";
            ((System.ComponentModel.ISupportInitialize)(this.pb_drawing)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bt_open_3dmodels;
        public System.Windows.Forms.PictureBox pb_drawing;
        private System.Windows.Forms.Button bt_info;
    }
}