
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
            this.mySqlDataAdapter1 = new MySqlConnector.MySqlDataAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.bu_plusFavourites = new System.Windows.Forms.Button();
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
            this.pb_drawing.Size = new System.Drawing.Size(535, 440);
            this.pb_drawing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_drawing.TabIndex = 0;
            this.pb_drawing.TabStop = false;
            // 
            // bt_open_3dmodels
            // 
            this.bt_open_3dmodels.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_open_3dmodels.BackColor = System.Drawing.Color.Transparent;
            this.bt_open_3dmodels.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_open_3dmodels.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_open_3dmodels.Location = new System.Drawing.Point(418, 458);
            this.bt_open_3dmodels.Name = "bt_open_3dmodels";
            this.bt_open_3dmodels.Size = new System.Drawing.Size(129, 52);
            this.bt_open_3dmodels.TabIndex = 1;
            this.bt_open_3dmodels.Text = "Открыть 3d-модель";
            this.bt_open_3dmodels.UseVisualStyleBackColor = false;
            this.bt_open_3dmodels.Click += new System.EventHandler(this.bt_open_3dmodels_Click);
            // 
            // bt_info
            // 
            this.bt_info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_info.BackColor = System.Drawing.Color.Transparent;
            this.bt_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_info.Location = new System.Drawing.Point(12, 458);
            this.bt_info.Name = "bt_info";
            this.bt_info.Size = new System.Drawing.Size(129, 52);
            this.bt_info.TabIndex = 2;
            this.bt_info.Text = "Справка о эскизе";
            this.bt_info.UseVisualStyleBackColor = false;
            this.bt_info.Click += new System.EventHandler(this.bt_info_Click);
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateBatchSize = 0;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(215, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 52);
            this.button1.TabIndex = 3;
            this.button1.Text = "Скачать 3D-модель";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(217, 516);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(127, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // bu_plusFavourites
            // 
            this.bu_plusFavourites.BackColor = System.Drawing.Color.Transparent;
            this.bu_plusFavourites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bu_plusFavourites.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bu_plusFavourites.Location = new System.Drawing.Point(12, 524);
            this.bu_plusFavourites.Name = "bu_plusFavourites";
            this.bu_plusFavourites.Size = new System.Drawing.Size(129, 52);
            this.bu_plusFavourites.TabIndex = 5;
            this.bu_plusFavourites.Text = "Добавить в избранное";
            this.bu_plusFavourites.UseVisualStyleBackColor = false;
            this.bu_plusFavourites.Click += new System.EventHandler(this.bu_plusFavourites_Click);
            // 
            // InfoModels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(559, 588);
            this.Controls.Add(this.bu_plusFavourites);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_info);
            this.Controls.Add(this.bt_open_3dmodels);
            this.Controls.Add(this.pb_drawing);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InfoModels";
            this.Text = "Эскиз";
            ((System.ComponentModel.ISupportInitialize)(this.pb_drawing)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bt_open_3dmodels;
        public System.Windows.Forms.PictureBox pb_drawing;
        private System.Windows.Forms.Button bt_info;
        private MySqlConnector.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button bu_plusFavourites;
    }
}