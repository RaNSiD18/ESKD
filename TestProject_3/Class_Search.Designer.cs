
namespace InvAddIn
{
    partial class Class_Search
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
            this.button_dalee = new System.Windows.Forms.Button();
            this.button_nazad = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textbox_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button_dalee
            // 
            this.button_dalee.Location = new System.Drawing.Point(434, 293);
            this.button_dalee.Name = "button_dalee";
            this.button_dalee.Size = new System.Drawing.Size(75, 23);
            this.button_dalee.TabIndex = 1;
            this.button_dalee.Text = "Далее >>";
            this.button_dalee.UseVisualStyleBackColor = true;
            this.button_dalee.Click += new System.EventHandler(this.button_dalee_Click);
            // 
            // button_nazad
            // 
            this.button_nazad.Location = new System.Drawing.Point(353, 293);
            this.button_nazad.Name = "button_nazad";
            this.button_nazad.Size = new System.Drawing.Size(75, 23);
            this.button_nazad.TabIndex = 2;
            this.button_nazad.Text = "<<Назад";
            this.button_nazad.UseVisualStyleBackColor = true;
            this.button_nazad.Click += new System.EventHandler(this.button_nazad_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(272, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Просмотр";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textbox_search
            // 
            this.textbox_search.Enabled = false;
            this.textbox_search.Location = new System.Drawing.Point(153, 295);
            this.textbox_search.Name = "textbox_search";
            this.textbox_search.Size = new System.Drawing.Size(100, 20);
            this.textbox_search.TabIndex = 4;
            this.textbox_search.Text = "XXXXXX";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Текущий код детали:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Класс";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 54);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(508, 204);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Class_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 328);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textbox_search);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_nazad);
            this.Controls.Add(this.button_dalee);
            this.Name = "Class_Search";
            this.Text = "Поиск по классу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_dalee;
        private System.Windows.Forms.Button button_nazad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textbox_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
    }
}