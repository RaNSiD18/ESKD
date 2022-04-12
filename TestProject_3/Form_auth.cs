using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MDM;

namespace InvAddIn
{
    public partial class Form_auth : Form
    {
        public Form_auth()
        {
            InitializeComponent();
        }

        private void button_vhod_Click(object sender, EventArgs e)
        {
            string command = "SELECT COUNT(*)  FROM Users WHERE login='" + textBox_log.Text + "' AND password='" + textBox_pass.Text + "'";
            if (MySQL.ExMysqlCommandAuth(command))
            {
                MessageBox.Show("Вы вошли в систему");
                
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Некорректный логин/пароль");
                return;
            }
        }

        private void Form_auth_FormClosed(object sender, FormClosedEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }
    }
}
