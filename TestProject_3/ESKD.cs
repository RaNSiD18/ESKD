using System;
using System.Collections;
using System.IO;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using MDM;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Net;
using MySqlConnector;
using System.Drawing;
using TestProject_3;

namespace InvAddIn
{
    public partial class ESKD : Form
    {
        private string _curDir;
        public ImageList il = new ImageList();
        public ImageList il_1 = new ImageList();

        public ESKD()
        {
            InitializeComponent();
            MySQL.Try_Connect_to_mysql();
            Form_auth form = new Form_auth();
            form.ShowDialog();
            CurDir = Directory.GetCurrentDirectory();
            
            Fill_treeview();
            lv_draw();
        }

        //функция, заполняющая TreeView из базы данных:
        private void Fill_treeview() {

            string command_classes = "SELECT * FROM Classes";
            string command_sublasses = "SELECT * FROM Subclasses";
            string command_groups = "SELECT * FROM Groups";
            string command_subgroups = "SELECT * FROM Subgroup";
            string command_types = "SELECT * FROM Types";

            DataTable table_classes = MySQL.FillDataTable(command_classes);
            DataTable table_subclasses = MySQL.FillDataTable(command_sublasses);
            DataTable table_groups = MySQL.FillDataTable(command_groups);
            DataTable table_subgroups = MySQL.FillDataTable(command_subgroups);
            DataTable table_types = MySQL.FillDataTable(command_types);
          

            foreach (DataRow row_classes in table_classes.Rows)
            {
                TreeNode node_class = new TreeNode(row_classes["Class_num"].ToString()+"-"+row_classes["Class_name"].ToString());
                treeView_eskd.Nodes.Add(node_class);
                foreach (DataRow row_subclasses in table_subclasses.Rows) {
                    TreeNode node_subclass = null;
                    if (row_classes["Class_num"].ToString() == row_subclasses["class_num"].ToString())
                    {
                        node_subclass = new TreeNode(row_subclasses["subclass_id"].ToString() + "-" + row_subclasses["subclass_name"].ToString());
                        node_class.Nodes.Add(node_subclass);
                    }
                    foreach (DataRow row_groups in table_groups.Rows)
                    {
                        TreeNode node_groups = null;
                        if (row_subclasses["subclass_id"].ToString() == row_groups["sublass_num"].ToString())
                        {
                            node_groups = new TreeNode(row_groups["group_id"].ToString() + "-" + row_groups["group_name"].ToString());
                            if (node_subclass != null)
                                node_subclass.Nodes.Add(node_groups);
                        }

                        foreach (DataRow row_subgroups in table_subgroups.Rows)
                        {
                            TreeNode node_subgroups = null;
                            if (row_groups["group_id"].ToString() == row_subgroups["group_id"].ToString())
                            {
                                node_subgroups = new TreeNode(row_subgroups["subroup_id"].ToString() + "-" + row_subgroups["subroup_name"].ToString());
                                if (node_groups != null)
                                    node_groups.Nodes.Add(node_subgroups);
                            }
                            foreach (DataRow row_types in table_types.Rows)
                            {
                                if (row_subgroups["subroup_id"].ToString() == row_types["subgroup_id"].ToString())
                                {
                                    TreeNode node_types = new TreeNode(row_types["type_id"].ToString() + "-" + row_types["type_name"].ToString());
                                    if (node_subgroups != null)
                                        node_subgroups.Nodes.Add(node_types);
                                }
                            }
                        }
                    }
                }
            }
        }

        //Кнопка для отрисовки всех схем в ListView
        private void bu_all_ESKD_Click(object sender, EventArgs e)
        {          
            lv.Clear();
            string command_types = "SELECT * FROM Types";
            DataTable table_types = MySQL.FillDataTable(command_types);

            il.Images.Clear();
            lv.LargeImageList = il;

            foreach (DataRow row_types in table_types.Rows)
            {
                il.Images.Add(Image.FromFile(AppDomain.CurrentDomain.BaseDirectory
                    + row_types["type_id"].ToString() + ".png"));

                il.ImageSize = new Size(200, 200);

                tb_test.Text = tb_test.Text + row_types["type_id"].ToString() + " ";
                lv.Items.Add(row_types["type_id"].ToString());
            }

            for (int i = 0; i < lv.Items.Count; i++)
            {
                lv.Items[i].ImageIndex = i;
            }
        }

        //Начальная отрисовка ListView
        private void lv_draw()
        {
            string command_classes = "SELECT * FROM Classes";
            string command_sublasses = "SELECT * FROM Subclasses";
            string command_groups = "SELECT * FROM Groups";
            string command_subgroups = "SELECT * FROM Subgroup";
            string command_types = "SELECT * FROM Types";
            DataTable table_classes = MySQL.FillDataTable(command_classes);
            DataTable table_subclasses = MySQL.FillDataTable(command_sublasses);
            DataTable table_groups = MySQL.FillDataTable(command_groups);
            DataTable table_subgroups = MySQL.FillDataTable(command_subgroups);
            DataTable table_types = MySQL.FillDataTable(command_types);
            il.Images.Clear();
            lv.LargeImageList = il;

            foreach (DataRow row_types in table_types.Rows)
            {
                string url = row_types["picture"].ToString();
                
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile(url, AppDomain.CurrentDomain.BaseDirectory 
                        + row_types["type_id"].ToString() + ".png");
                }

                il.Images.Add(Image.FromFile(AppDomain.CurrentDomain.BaseDirectory 
                    + row_types["type_id"].ToString() + ".png"));

                il.ImageSize = new Size(200, 200);

                tb_test.Text = tb_test.Text + " " + row_types["type_id"].ToString();
                lv.Items.Add(row_types["type_id"].ToString());
            }

            for (int i = 0; i < lv.Items.Count; i++)
            {
                lv.Items[i].ImageIndex = i;
            }
        }

        public string CurDir
        {
            get
            {
                return _curDir;
            }
            private set
            {
                _curDir = value;
            }
        }

        //Открытие формы выбранной схемы
        private void lv_DoubleClick(object sender, EventArgs e)
        {
            InfoModels infoModels = new InfoModels();
            infoModels.id_eskd = lv.FocusedItem.Text;

            infoModels.pb_drawing.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory 
                + lv.FocusedItem.Text + ".png");

            infoModels.il_1 = il;

            infoModels.ShowDialog();
        }

        private TreeNode SearchNode(string SearchText, TreeNode StartNode)
        {
            TreeNode node = null;
            while (StartNode != null)
            {
                if (StartNode.Text.ToLower().Contains(SearchText.ToLower()))
                {
                    node = StartNode; 
                    break;
                };
                if (StartNode.Nodes.Count != 0) 
                {
                    node = SearchNode(SearchText, StartNode.Nodes[0]);
                    if (node != null)
                    {
                        break;
                    };
                };
                StartNode = StartNode.NextNode;
            };
            return node;
        }

        //Кнопка открытия формы поиска по классу
        private void button_classsearch_Click(object sender, EventArgs e)
        {
            Class_Search form = new Class_Search();
            form.Show();
        }

        //Кнопка открытия формы экспертного поиска
        private void button_expert_Click(object sender, EventArgs e)
        {
            Form_expert form = new Form_expert();
            form.Show();
        }

        //Двойной клик по классу в дереве отрисовывает в ListView выбранный класс
        private void treeView_eskd_DoubleClick(object sender, EventArgs e)
        {
            lv.Clear();
            string focusItem;
            string command_sublasses = "SELECT * FROM Subclasses";
            string command_groups = "SELECT * FROM Groups";
            string command_subgroups = "SELECT * FROM Subgroup";
            string command_types = "SELECT * FROM Types";
            string command_classes = "SELECT * FROM Classes";
            DataTable table_classes = MySQL.FillDataTable(command_classes);
            DataTable table_subclasses = MySQL.FillDataTable(command_sublasses);
            DataTable table_groups = MySQL.FillDataTable(command_groups);
            DataTable table_subgroups = MySQL.FillDataTable(command_subgroups);
            DataTable table_types = MySQL.FillDataTable(command_types);
            il.Images.Clear();
            focusItem = "";

            lv.LargeImageList = il;
            focusItem = treeView_eskd.SelectedNode.Text.Remove(2, treeView_eskd.SelectedNode.Text.Length-2);
            tb_test.Text = focusItem;
            
            foreach (DataRow row_types in table_types.Rows)
            {
                string filterClass = row_types["type_id"].ToString().Remove(2, 
                    row_types["type_id"].ToString().Length - 2);

                if (filterClass == focusItem)
                {
                    il.Images.Add(Image.FromFile(AppDomain.CurrentDomain.BaseDirectory
                        + row_types["type_id"].ToString() + ".png"));

                    il.ImageSize = new Size(200, 200);

                    tb_test.Text = tb_test.Text + " " + row_types["type_id"].ToString();
                    lv.Items.Add(row_types["type_id"].ToString());
                }
            }
            for (int i = 0; i < lv.Items.Count; i++)
            {
                lv.Items[i].ImageIndex = i;
            }
        }

        
        private void ESKD_FormClosing(object sender, FormClosingEventArgs e)
        {
            StandardAddInServer standartAddInServer = new StandardAddInServer();
            standartAddInServer.Deactivate();
        }

        //Кнопка вызова формы избранное
        private void button1_Click(object sender, EventArgs e)
        {
            Fr_Favourites fr_fv = new Fr_Favourites();
            fr_fv.ShowDialog();
        }

        //Кнопка поиска схемы с помощью textbox
        private void bu_search_Click(object sender, EventArgs e)
        {
            string SearchText = this.tb_search.Text;
            if (SearchText == "")
            {
                return;
            };

            TreeNode SelectedNode = SearchNode(SearchText, treeView_eskd.Nodes[0]);

            if (SelectedNode != null)
            {
                this.treeView_eskd.SelectedNode = SelectedNode;
                /*lv.SelectedItems[0].Text = this.tv.SelectedNode.Name + ".ipt";*/
                this.treeView_eskd.SelectedNode.Expand();
                this.treeView_eskd.Select();

                for (int i = lv.Items.Count - 1; i >= 0; i--)
                {
                    var item = lv.Items[i];
                    if (item.Text.ToLower().Contains(tb_search.Text.ToLower()))
                    {
                        lv.Select();
                        item.Selected = true;
                        lv.EnsureVisible(i);
                        break;
                    }
                }
            }
        }

        private void ESKD_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}