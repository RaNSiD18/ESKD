using System;
using System.Collections;
using System.IO;
using System.Collections.Specialized;
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
    public partial class ESKD : Form
    {
        private string _curDir;

        public ESKD()
        {
            InitializeComponent();
            CurDir = Directory.GetCurrentDirectory();

            tv.Click += Tv_Click;
            tv.DoubleClick += Tv_DoubleClick;
            tv.LabelEdit = true;
            tv.NodeMouseClick += (s, e) => tv.SelectedNode = e.Node;
            tv.AfterSelect += (s, e) => { SetItemTS = Path.Combine(tv.SelectedNode.FullPath); };

            cb1.Text = "Class 71";
            cb1.Items.AddRange(new string[] { "Class 71", "Class 72", "Class 73", "Class 74", "Class 75" });

            tvLoad();
            
        }

        private void tvLoad()
        {
            foreach (var item in Directory.GetLogicalDrives())
            {
                tv.Nodes.Add("", item, 1);
            }
        }

        private void Tv_Click(object sender, EventArgs e)
        {
            //LoadDir(tv.SelectedNode.FullPath);
        }

        private void Tv_DoubleClick(object sender, EventArgs e)
        {
            //this.Text = tv.SelectedNode.Text;
            DirectoryInfo directoryInfo = new DirectoryInfo(tv.SelectedNode.FullPath);
            tv.BeginUpdate();
            tv.SelectedNode.Nodes.Clear();
            foreach (var item in directoryInfo.GetDirectories())
            {
                tv.SelectedNode.Nodes.Add("", item.Name, 2);
            }
            tv.SelectedNode.Expand();
            tv.EndUpdate();
            LoadDir(tv.SelectedNode.FullPath);
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
                //buUp.Enabled = false;
            }
            else
            {
                //buUp.Enabled = true;
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
                            new string[] { item.Name, item.LastWriteTime.ToString(), "Папка", "" }, index
                            ));

                    }

                    foreach (var item in directoryInfo.GetFiles())
                    {
                        lv.Items.Add(new ListViewItem(
                            new string[] { item.Name, item.LastWriteTime.ToString(), "Файл", FormatSize($"{item.Length}") }, 0
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
                //edDir.Text = _curDir;
            }
        }

        public string SetItemTS { get; private set; }
    }
}
