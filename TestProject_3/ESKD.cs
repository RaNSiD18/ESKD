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

namespace InvAddIn
{
    public partial class ESKD : Form
    {
        private string _curDir;
        public ESKD()
        {
            InitializeComponent();
            CurDir = Directory.GetCurrentDirectory();

            //tv.Click += Tv_Click;
            tv.DoubleClick += Tv_DoubleClick;
            tv.LabelEdit = true;
            tv.NodeMouseClick += (s, e) => tv.SelectedNode = e.Node;
            tv.AfterSelect += (s, e) => { SetItemTS = Path.Combine(tv.SelectedNode.FullPath); };

            
            combo_class_search.Items.AddRange(new string[] { "Class 71", "Class 72", "Class 73", "Class 74", "Class 75" });
            MySQL.Try_Connect_to_mysql();
            string command = "SELECT Class_name FROM `Classes`";
            DataTable table = MySQL.FillDataTable(command);
            combo_class_search.DataSource = table;
            combo_class_search.DisplayMember = "Class_name";
            combo_class_search.ValueMember = "Class_name";

            cb_class_eskd.Items.AddRange(new string[] {
                "71 - Детали-тела вращения типа колец, дисков, шкивов, блоков, стержней, втулок, стаканов, колонок, валов, осей, штоков, шпинделей и др.",
                "72 - Детали-тела вращения с элементами зубчатого зацепления; трубы, шланги, проволочки, разрезные, сектора, сегменты; изогнутые из листов, полос и лент; аэрогидродинамические; корпусные, опорные; емкостные; подшипников",
                "73 - Детали-не тела вращения корпусные, опорные, емкостные"});

            LoadDir(@"3d-models");
            for (int i = 0; i < lv.Items.Count; i++)
            lv.Items[i].ImageIndex = i;
        }

        private void Tv_DoubleClick(object sender, EventArgs e)
        {
            //this.Text = tv.SelectedNode.Text; var result = Regex.Replace(inputStr, @"[а-яА-ЯёЁ]", "");
            /*            string dir = tv.SelectedNode.FullPath;
                        string newdir = Regex.Replace(dir, @"[а-яА-ЯёЁ,. ()-]", "");
                        DirectoryInfo directoryInfo = new DirectoryInfo(newdir);
                        tv.BeginUpdate();
                        tv.SelectedNode.Nodes.Clear();
                        foreach (var item in directoryInfo.GetDirectories())
                        {
                            tv.SelectedNode.Nodes.Add("", item.Name, 2);
                        }
                        tv.SelectedNode.Expand();
                        tv.EndUpdate();
                        LoadDir(tv.SelectedNode.FullPath);*/
            string SearchText = this.tv.SelectedNode.Name;
            if (SearchText == "")
            {
                return;
            };
            TreeNode SelectedNode = SearchNode(SearchText, tv.Nodes[0]);
            if (SelectedNode != null)
            {
                this.tv.SelectedNode = SelectedNode;
                /*lv.SelectedItems[0].Text = this.tv.SelectedNode.Name + ".ipt";*/
                this.tv.SelectedNode.Expand();
                this.tv.Select();

                if (cb_class_eskd.Text == "")
                {
                    for (int i = lv.Items.Count - 1; i >= 0; i--)
                    {
                        var item = lv.Items[i];
                        if (item.Text.ToLower().Contains(SearchText + ".ipt"))
                        {
                            lv.Select();
                            item.Selected = true;
                            lv.EnsureVisible(i);
                            break;
                        }
                        else
                        if (item.Text.ToLower().Contains(SearchText + ".iam"))
                        {
                            lv.Select();
                            item.Selected = true;
                            lv.EnsureVisible(i);
                            break;
                        }
                    }
                } /*else
                {
                    string cb_id = cb_class_eskd.SelectedItem.ToString();
                    switch(cb_id)
                    {
                        case "0":
                            for (int i = lv.Items.Count - 1; i >= 0; i--)
                            {
                                var item = lv.Items[i];
                                if (item.Text.Remove(2, 6) == "38")
                                {
                                    if (item.Text.ToLower().Contains(SearchText + ".iam"))
                                    {
                                        lv.Select();
                                        item.Selected = true;
                                        lv.EnsureVisible(i);
                                        break;
                                    }
                                }
                            }
                            break;
                        case "1":
                            for (int i = lv.Items.Count - 1; i >= 0; i--)
                            {
                                var item = lv.Items[i];
                                if (item.Text.Remove(2, 6) == "71")
                                {
                                    if (item.Text.ToLower().Contains(SearchText + ".ipt"))
                                    {
                                        lv.Select();
                                        item.Selected = true;
                                        lv.EnsureVisible(i);
                                        break;
                                    }
                                }
                            }
                            break;
                        case "2":
                            for (int i = lv.Items.Count - 1; i >= 0; i--)
                            {
                                var item = lv.Items[i];
                                if (item.Text.Remove(2, 6) == "73")
                                {
                                    if (item.Text.ToLower().Contains(SearchText + ".ipt"))
                                    {
                                        lv.Select();
                                        item.Selected = true;
                                        lv.EnsureVisible(i);
                                        break;
                                    }
                                }
                            }
                            break;
                        default:
                            break;
                    }
                }*/
            };
        }

        private void LoadDir(string newDir)
        {
            lv.BeginUpdate();
            lv.Items.Clear();
            if (newDir == null)
            {
                foreach (var item in Directory.GetLogicalDrives())
                {
                    lv.Items.Add(new ListViewItem(
                       new string[] { item, "", "Диск", "" }, 2
                       ));
                }
                CurDir = "My Computer";
            }
            else
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(newDir);
                try
                {
                    foreach (var item in directoryInfo.GetDirectories())
                    {
                        int index;
                        if ((item.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
                            index = 13;
                        else
                            index = 1;
                        lv.Items.Add(new ListViewItem(
                            new string[] { item.Name,
                                item.LastWriteTime.ToString(),
                                "Папка",
                                "" }, index
                            ));
                    }
                    foreach (var item in directoryInfo.GetFiles())
                    {
                        lv.Items.Add(new ListViewItem(
                            new string[] { item.Name,
                                item.LastWriteTime.ToString(),
                                "Файл",
                                FormatSize($"{item.Length}") }, 0
                            ));
                    }
                    CurDir = newDir;
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error" + e.Message);
                }
            }
            lv.EndUpdate();
        }

        private string FormatSize(string str)
        {
            string[] ext = new String[] { "Байт", "Кб", "Мб", "Гб", "Тб" };
            int i = 0;
            double mod = 1024;
            double size = Convert.ToDouble(str);
            double result = size;
            while (result > 1024)
            {
                result /= mod;
                i++;
            }
            return $"{Math.Ceiling(result)} {ext[i]}";
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

        public string SetItemTS { get; private set; }

        private void lv_DoubleClick(object sender, EventArgs e)
        {
            InfoModels infoModels = new InfoModels();
            infoModels.eskdDir = lv.SelectedItems[0].Text;

            string newEskdDir = lv.SelectedItems[0].Text;
            newEskdDir = newEskdDir.Remove(newEskdDir.Length - 4);

            infoModels.infoDrawing = newEskdDir;
            infoModels.Text = "Схема " + newEskdDir;

            if (newEskdDir != null)
            {
                System.IO.FileStream fs = new System.IO.FileStream(@"drawing" 
                + "\\"
                + newEskdDir
                + ".jpg",
                System.IO.FileMode.Open);
                System.Drawing.Image img = System.Drawing.Image.FromStream(fs);
                
                infoModels.pb_drawing.Image = img;
                infoModels.Show();
                fs.Close();
            }
        }

        private void bu_search_Click(object sender, EventArgs e)
        {
            string SearchText = this.tb_search.Text;
            if (SearchText == "")
            {
                return;
            };

            TreeNode SelectedNode = SearchNode(SearchText, tv.Nodes[0]);

            if (SelectedNode != null)
            {
                this.tv.SelectedNode = SelectedNode;
                /*lv.SelectedItems[0].Text = this.tv.SelectedNode.Name + ".ipt";*/
                this.tv.SelectedNode.Expand();
                this.tv.Select();

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
            };
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
    }
}