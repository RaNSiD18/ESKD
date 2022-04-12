using MDM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvAddIn
{
    public partial class Form_expert : Form
    {
       
        private string last_question;
        private int kpi=0;
        private int level = 1;
        public Form_expert()
        {
            InitializeComponent();
            string command_types = "SELECT * FROM Types";
            DataTable table_types = MySQL.FillDataTable(command_types);
            foreach (DataRow row_types in table_types.Rows)
            {
                // TreeNode node_subclass = null;

                // node_subclass = new TreeNode(row_subclasses["subclass_id"].ToString() + "-" + row_subclasses["subclass_name"].ToString());
                listBox_result.Items.Add(row_types["type_id"].ToString());

            }
            string command_question = "SELECT * FROM Questions WHERE level=1 AND KPI = (SELECT MAX(kpi) FROM Questions)";
            DataTable table_question = MySQL.FillDataTable(command_question);
           DataRow row = table_question.Rows[0];
            // TreeNode node_subclass = null;
            label_question.Text = row["question"].ToString();
            kpi= Int32.Parse (row["kpi"].ToString());
         //   MessageBox.Show(kpi.ToString());
            last_question = label_question.Text;
            // node_subclass = new TreeNode(row_subclasses["subclass_id"].ToString() + "-" + row_subclasses["subclass_name"].ToString());



        }
        public void email()
        {
            int k = listBox_result.Items.Count;
            string text = "Ошибка при экспертном поиске. Остались следующие элементы:";
            for (int i = k - 1; i >= 0; i--)
            {


                text +=listBox_result.Items[i].ToString()+"; ";

            }

            try
            {
                //  MessageBox.Show(text);
                SmtpClient Smtp = new SmtpClient("mail.nic.ru", 587);
                Smtp.Credentials = new NetworkCredential("menelai@alexlyubimov.ru", "Grina_1227");
                MailMessage Message = new MailMessage();
                Message.From = new MailAddress("menelai@alexlyubimov.ru");
                Message.To.Add(new MailAddress("mratlas@mail.ru"));
                Message.Subject = "Ошибка при экспертном поиске "+DateTime.Now.ToString();
                Message.Body = text;
                Message.IsBodyHtml = true;
                try
                {
                    Smtp.Send(Message);
                }
                catch (SmtpException)
                {
                    MessageBox.Show("Проверьте корректность почтового адреса");
                }
            }
            catch
            {
            }
        }
        private bool check_classes_of_elements()
        {
            int k = listBox_result.Items.Count;
           // int check_sum=k;

            for (int i = k - 1; i >= 1; i--)
            {
                if(listBox_result.Items[i-1].ToString().Substring(0, level+1)!= listBox_result.Items[i].ToString().Substring(0, level+1))
                {
                    return false;
                }
                
            }
            return true;
               // return true;
        }
        private void button_yes_Click(object sender, EventArgs e)
        {
            string table = "";
            string name = "";
            string num = "";
            if (level == 1) {
                table = "Classes";
                name = "Class_name";
                num = "Class_num";
            }
            if (level == 2)
            {
                table = "Subclasses";
                name = "subclass_name";
                num = "subclass_id";
            }
            if (level == 3)
            {
                table = "Groups";
                name = "group_name";
                num = "group_id";
            }
            if (level == 4)
            {
                table = "Subgroup";
                name = "subroup_name";
                num = "subroup_id";
            }
            if (level == 5)
            {
                table = "Types";
                name = "type_name";
                num = "type_id";
            }
            string command_key = "SELECT * FROM Keywords WHERE question='" + label_question.Text + "'";
            DataTable table_key = MySQL.FillDataTable(command_key);
         
            foreach (DataRow row_key in table_key.Rows)
            {
              //  MessageBox.Show(row_key["keyword"].ToString());
          
               // string command_res = "SELECT Class_name FROM Classes WHERE Class_name LIKE '%" + row_key["keyword"].ToString() + "%'";
         
              //  DataTable res = MySQL.FillDataTable(command_res);
               
               
                    int k= listBox_result.Items.Count;
                
                    for (int i = k-1; i >= 0; i--)
                    {
                        
                       string class_num= listBox_result.Items[i].ToString().Substring(0, level+1);
                    string command_select_element_classname = "SELECT COUNT(*) FROM " + table+" WHERE "+name+" LIKE '%" + row_key["keyword"].ToString() + "%' AND "+num+"='" + class_num +"'";
                    // DataTable table_element_class_description = MySQL.FillDataTable(command_select_element_classname);
                    if (MySQL.ExMysqlCommandAuth(command_select_element_classname))
                    {
                      //  ничего не делаем
                    }
                    else
                    {
                        listBox_result.Items.RemoveAt(i);
                    }
                   


                    }
                if (listBox_result.Items.Count == 1)
                {

                    MessageBox.Show("Код детали найден");
                }
                //подгружаем следующий вопрос
                else
                {
                    if (check_classes_of_elements())
                    {

                        level++;
                        try
                        {
                            string command_question = "SELECT * FROM Questions WHERE level='" + level + "' AND KPI = (SELECT MAX(kpi)  FROM Questions WHERE level='" + level + "')";
                            DataTable table_question = MySQL.FillDataTable(command_question);
                            DataRow row = table_question.Rows[0];
                            // TreeNode node_subclass = null;
                            label_question.Text = row["question"].ToString();
                            kpi = Int32.Parse(row["kpi"].ToString());
                           // MessageBox.Show(kpi.ToString());
                            last_question = label_question.Text;
                        }
                        catch {
                            MessageBox.Show("Не удается найти искомый код, системному администратору будет отправлено сообщение об ошибке");
                            email();
                        }

                    }

               
                }
                

            


            }
            
        }

        private void button_no_Click(object sender, EventArgs e)
        {
            try
            {
                string command_question = "SELECT * FROM Questions WHERE level='" + level + "' AND KPI = (SELECT MAX(kpi) FROM Questions WHERE kpi<'" + kpi + "')";
                DataTable table_question = MySQL.FillDataTable(command_question);
                DataRow row = table_question.Rows[0];
                label_question.Text = row["question"].ToString();
                last_question = label_question.Text;
                kpi = Int32.Parse(row["kpi"].ToString());
                //MessageBox.Show(kpi.ToString());
            }
            catch {
                MessageBox.Show("Не удается найти искомый код, системному администратору будет отправлено сообщение об ошибке");
                email();
            }
        }

        private void button_sbros_Click(object sender, EventArgs e)
        {
            level = 1;
            listBox_result.Items.Clear();
            string command_types = "SELECT * FROM Types";
            DataTable table_types = MySQL.FillDataTable(command_types);
            foreach (DataRow row_types in table_types.Rows)
            {
                // TreeNode node_subclass = null;

                // node_subclass = new TreeNode(row_subclasses["subclass_id"].ToString() + "-" + row_subclasses["subclass_name"].ToString());
                listBox_result.Items.Add(row_types["type_id"].ToString());

            }
            string command_question = "SELECT * FROM Questions WHERE level=1 AND KPI = (SELECT MAX(kpi) FROM Questions)";
            DataTable table_question = MySQL.FillDataTable(command_question);
            DataRow row = table_question.Rows[0];
            // TreeNode node_subclass = null;
            label_question.Text = row["question"].ToString();
            kpi = Int32.Parse(row["kpi"].ToString());
            //MessageBox.Show(kpi.ToString());
            last_question = label_question.Text;
        }
    }
}
