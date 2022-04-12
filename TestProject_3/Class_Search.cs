using MDM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvAddIn
{
    public partial class Class_Search : Form
    {
        private int num;
        private int page_number = 0;
        public Class_Search()
        {
            InitializeComponent();
            string command_classes = "SELECT * FROM Classes";
            DataTable table_classes = MySQL.FillDataTable(command_classes);
           
                foreach(DataRow row_classes in table_classes.Rows)
                listBox1.Items.Add(row_classes["Class_num"].ToString()+"-"+row_classes["Class_name"].ToString());

            listBox1.HorizontalScrollbar = true;
            listBox1.SetSelected(0, true);


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            string curItem = listBox1.SelectedItem.ToString();
           
           int k = curItem.IndexOf('-');
            string kek = curItem.Substring(0, k);
            num = int.Parse(kek);
          
            textbox_search.Text = num + return_xxx(num);
        }
        private string return_xxx(int num) {
            string xxx="";
            int i = 6 - num.ToString().Length;
            for (int j = 0; j < i; j++)
            {
                xxx += "X";
            }
            return xxx;
        }
        private void button_dalee_Click(object sender, EventArgs e)
        {
            
                if ((page_number < 4))
                {
                    page_number++;
                    listBox1.Items.Clear();
                   

                    if (page_number == 1)
                    {
                        label2.Text = "Подкласс";
                        string command_sublasses = "SELECT * FROM Subclasses";
                        DataTable table_subclasses = MySQL.FillDataTable(command_sublasses);
                        foreach (DataRow row_subclasses in table_subclasses.Rows)
                        {
                          
                            if (num.ToString() == row_subclasses["class_num"].ToString())
                            {
                           
                                listBox1.Items.Add(row_subclasses["subclass_id"].ToString() + "-" + row_subclasses["subclass_name"].ToString());
                            }
                        }
                    }
                    else if (page_number == 2)
                    {
                        label2.Text = "Группа";
                        string command_groups = "SELECT * FROM Groups";
                        DataTable table_groups = MySQL.FillDataTable(command_groups);
                        foreach (DataRow row_groups in table_groups.Rows)
                        {
                          
                            if (num.ToString() == row_groups["sublass_num"].ToString())
                            {
                             
                                listBox1.Items.Add(row_groups["group_id"].ToString() + "-" + row_groups["group_name"].ToString());
                            }
                        }
                    }
                    else if (page_number == 3)
                    {
                        label2.Text = "Подгруппа";
                        string command_subgroups = "SELECT * FROM Subgroup";
                        DataTable table_subgroups = MySQL.FillDataTable(command_subgroups);
                        foreach (DataRow row_subgroups in table_subgroups.Rows)
                        {
                            
                            if (num.ToString() == row_subgroups["group_id"].ToString())
                            {
                                
                                listBox1.Items.Add(row_subgroups["subroup_id"].ToString() + "-" + row_subgroups["subroup_name"].ToString());
                            }
                        }
                    }
                    else if (page_number == 4)
                    {
                        label2.Text = "Тип";
                        string command_types = "SELECT * FROM Types";
                        DataTable table_types = MySQL.FillDataTable(command_types);
                        foreach (DataRow row_types in table_types.Rows)
                        {
                          
                            if (num.ToString() == row_types["subgroup_id"].ToString())
                            {
                               
                                listBox1.Items.Add(row_types["type_id"].ToString() + "-" + row_types["type_name"].ToString());
                            }
                        }
                    }
                    
                    try
                    {
                        listBox1.SetSelected(0, true);
                    }
                    catch
                    {

                    }
                }
            }
           
         
        

        private void button_nazad_Click(object sender, EventArgs e)
        {
          
            if ((page_number > 0))
            {
                page_number--;
                listBox1.Items.Clear();
                
                if (page_number == 0)
                {
                    label2.Text = "Класс";
                    string command_classes = "SELECT * FROM Classes";
                    DataTable table_classes = MySQL.FillDataTable(command_classes);
                    foreach (DataRow row_classes in table_classes.Rows)
                    {
                        
                            listBox1.Items.Add(row_classes["Class_num"].ToString() + "-" + row_classes["Class_name"].ToString());
                     }
                    
                }
                if (page_number == 1)
                {
                    label2.Text = "Подкласс";
                    string command_sublasses = "SELECT * FROM Subclasses";
                    DataTable table_subclasses = MySQL.FillDataTable(command_sublasses);
                    foreach (DataRow row_subclasses in table_subclasses.Rows)
                    {
                      
                        if (num.ToString().Remove(num.ToString().Length - 2) == row_subclasses["class_num"].ToString())
                        {
                            
                            
                            listBox1.Items.Add(row_subclasses["subclass_id"].ToString() + "-" + row_subclasses["subclass_name"].ToString());
                        }
                    }
                }
                else if (page_number == 2)
                {
                    label2.Text = "Группа";
                    string command_groups = "SELECT * FROM Groups";
                    DataTable table_groups = MySQL.FillDataTable(command_groups);
                    foreach (DataRow row_groups in table_groups.Rows)
                    {
                        
                        if (num.ToString().Remove(num.ToString().Length - 2) == row_groups["sublass_num"].ToString())
                        {
                            
                            
                            listBox1.Items.Add(row_groups["group_id"].ToString() + "-" + row_groups["group_name"].ToString());
                        }
                    }
                }
                else if (page_number == 3)
                {
                    label2.Text = "Подгруппа";
                    string command_subgroups = "SELECT * FROM Subgroup";
                    DataTable table_subgroups = MySQL.FillDataTable(command_subgroups);
                    foreach (DataRow row_subgroups in table_subgroups.Rows)
                    {
                     
                        if (num.ToString().Remove(num.ToString().Length - 2) == row_subgroups["group_id"].ToString())
                        {
                            
                            
                            listBox1.Items.Add(row_subgroups["subroup_id"].ToString() + "-" + row_subgroups["subroup_name"].ToString());
                        }
                    }
                }
                else if (page_number == 4)
                {
                    label2.Text = "Тип";
                    string command_types = "SELECT * FROM Types";
                    DataTable table_types = MySQL.FillDataTable(command_types);
                    foreach (DataRow row_types in table_types.Rows)
                    {
                        
                        if (num.ToString().Remove(num.ToString().Length-2) == row_types["subgroup_id"].ToString())
                        {
                            
                           
                            listBox1.Items.Add(row_types["type_id"].ToString() + "-" + row_types["type_name"].ToString());
                        }
                    }
                }
                try
                {
                    var vibor_nazad = num.ToString().Remove(num.ToString().Length - 1);
                  
                    for (int i = 0; i < listBox1.Items.Count; i++)
                    {
                        if (listBox1.Items[i].ToString().Contains(vibor_nazad))
                        {

                            listBox1.SetSelected(i, true);
                        }
                        }

                }
                catch { }
            }
        }
           

    }
}
