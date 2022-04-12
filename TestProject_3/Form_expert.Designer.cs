
namespace InvAddIn
{
    partial class Form_expert
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
            this.listBox_result = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_gores = new System.Windows.Forms.Button();
            this.button_yes = new System.Windows.Forms.Button();
            this.button_no = new System.Windows.Forms.Button();
            this.label_question = new System.Windows.Forms.Label();
            this.button_sbros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_result
            // 
            this.listBox_result.BackColor = System.Drawing.Color.PeachPuff;
            this.listBox_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_result.FormattingEnabled = true;
            this.listBox_result.ItemHeight = 16;
            this.listBox_result.Location = new System.Drawing.Point(580, 40);
            this.listBox_result.Name = "listBox_result";
            this.listBox_result.Size = new System.Drawing.Size(194, 340);
            this.listBox_result.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(577, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Результат поиска:";
            // 
            // button_gores
            // 
            this.button_gores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_gores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_gores.Location = new System.Drawing.Point(668, 402);
            this.button_gores.Name = "button_gores";
            this.button_gores.Size = new System.Drawing.Size(89, 23);
            this.button_gores.TabIndex = 2;
            this.button_gores.Text = "Перейти";
            this.button_gores.UseVisualStyleBackColor = true;
            // 
            // button_yes
            // 
            this.button_yes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_yes.Location = new System.Drawing.Point(103, 372);
            this.button_yes.Name = "button_yes";
            this.button_yes.Size = new System.Drawing.Size(102, 23);
            this.button_yes.TabIndex = 3;
            this.button_yes.Text = "Да";
            this.button_yes.UseVisualStyleBackColor = true;
            this.button_yes.Click += new System.EventHandler(this.button_yes_Click);
            // 
            // button_no
            // 
            this.button_no.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_no.Location = new System.Drawing.Point(251, 372);
            this.button_no.Name = "button_no";
            this.button_no.Size = new System.Drawing.Size(102, 23);
            this.button_no.TabIndex = 4;
            this.button_no.Text = "Нет";
            this.button_no.UseVisualStyleBackColor = true;
            this.button_no.Click += new System.EventHandler(this.button_no_Click);
            // 
            // label_question
            // 
            this.label_question.AutoSize = true;
            this.label_question.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_question.Location = new System.Drawing.Point(191, 166);
            this.label_question.MaximumSize = new System.Drawing.Size(200, 200);
            this.label_question.Name = "label_question";
            this.label_question.Size = new System.Drawing.Size(70, 20);
            this.label_question.TabIndex = 5;
            this.label_question.Text = "Вопрос";
            // 
            // button_sbros
            // 
            this.button_sbros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sbros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_sbros.Location = new System.Drawing.Point(580, 402);
            this.button_sbros.Name = "button_sbros";
            this.button_sbros.Size = new System.Drawing.Size(75, 23);
            this.button_sbros.TabIndex = 6;
            this.button_sbros.Text = "Сбросить";
            this.button_sbros.UseVisualStyleBackColor = true;
            this.button_sbros.Click += new System.EventHandler(this.button_sbros_Click);
            // 
            // Form_expert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(804, 437);
            this.Controls.Add(this.button_sbros);
            this.Controls.Add(this.label_question);
            this.Controls.Add(this.button_no);
            this.Controls.Add(this.button_yes);
            this.Controls.Add(this.button_gores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_result);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form_expert";
            this.Text = "Экспертный поиск";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_gores;
        private System.Windows.Forms.Button button_yes;
        private System.Windows.Forms.Button button_no;
        private System.Windows.Forms.Label label_question;
        private System.Windows.Forms.Button button_sbros;
    }
}