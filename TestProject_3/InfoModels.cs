using FluentFTP;
using MDM;
using Renci.SshNet;
using Renci.SshNet.Sftp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace InvAddIn
{
    public partial class InfoModels : Form
    {
        public string id_eskd;
        public string infoDrawing;
        Test_Spravka testSpravka = new Test_Spravka();
        public ImageList il_1 = new ImageList();
        public ImageList il_2 = new ImageList();
        string remoteDirectory = "/models";


        public InfoModels()
        {
            InitializeComponent();
        }

        //Кнопка открытия 3D-модели схемы
        private void bt_open_3dmodels_Click(object sender, EventArgs e)
        {
            //ESKD eskd = new ESKD();
            string dir;
            string shema = "382111";

            if (id_eskd == shema)
            {
                dir = AppDomain.CurrentDomain.BaseDirectory + id_eskd + ".iam";
                Process.Start(dir);
            }
            else
            {
                dir = AppDomain.CurrentDomain.BaseDirectory + id_eskd + ".ipt";
                Process.Start(dir);
            }

            MessageBox.Show("Закройте диалоговые окна ЕСКД для просмотра 3D-модели");
        }

        //Кнопка открытия формы с общей информацией о схеме
        private void bt_info_Click(object sender, EventArgs e)
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

            string i_4 = id_eskd.Substring(0, id_eskd.Length - 1);
            string i_3 = id_eskd.Substring(0, id_eskd.Length - 2);
            string i_2 = id_eskd.Substring(0, id_eskd.Length - 3);
            string i_1 = id_eskd.Substring(0, id_eskd.Length - 4);

            foreach (DataRow row_classes in table_classes.Rows)
            {
                if (row_classes["Class_num"].ToString() == i_1)
                    testSpravka.tb_info.Text = "1. " + row_classes["Class_name"].ToString() + '\r' + '\n';
            }

            foreach (DataRow row_subclasses in table_subclasses.Rows)
            {
                if (row_subclasses["subclass_id"].ToString() == i_2)
                    testSpravka.tb_info.Text = testSpravka.tb_info.Text + "2. "
                        + row_subclasses["subclass_name"].ToString() + '\r' + '\n';
            }
            foreach (DataRow row_groups in table_groups.Rows)
            {
                if (row_groups["group_id"].ToString() == i_3)
                    testSpravka.tb_info.Text = testSpravka.tb_info.Text + "3. "
                        + row_groups["group_name"].ToString() + '\r' + '\n';
            }
            foreach (DataRow row_subgroups in table_subgroups.Rows)
            {
                if (row_subgroups["subroup_id"].ToString() == i_4)
                    testSpravka.tb_info.Text = testSpravka.tb_info.Text + "4. "
                        + row_subgroups["subroup_name"].ToString() + '\r' + '\n';
            }
            foreach (DataRow row_types in table_types.Rows)
            {
                if (row_types["type_id"].ToString() == id_eskd)
                    testSpravka.tb_info.Text = testSpravka.tb_info.Text + "5. " 
                        + row_types["type_name"].ToString();
            }

            testSpravka.Text = "Описание эскиза " + id_eskd;
            testSpravka.ShowDialog();
        }

        //Кнопка для загрузки 3D-моделей на ПК
        private void button1_Click(object sender, EventArgs e)
        {
            var client = new SftpClient("194.58.103.233", "sammy_sftp", "sammy");

            string command_types = "SELECT * FROM Types";
            DataTable table_types = MySQL.FillDataTable(command_types);

            try
            {
                client.Connect();

                var files = client.ListDirectory(remoteDirectory);

                foreach (var file in files)
                {

                    foreach (DataRow row_types in table_types.Rows)
                    {

                        if (file.Name == id_eskd + ".ipt")
                        {
                            SftpFileAttributes attrs = client.GetAttributes(remoteDirectory + '/' + file.Name);

                            int max = (int)attrs.Size;
                            progressBar1.Invoke(
                            (MethodInvoker)delegate { progressBar1.Maximum = max; });

                            var file1 = System.IO.File.Create(AppDomain.CurrentDomain.BaseDirectory + @"\" + file.Name);

                            client.DownloadFile(remoteDirectory + '/' + file.Name, file1, DownloadProgresBar);
                            //
                            MessageBox.Show(file.Name);
                            file1.Close();
                        }
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
            }
            MessageBox.Show("3D-модель скачалась на ваш ПК. " + "Папка 3D-модели: " + AppDomain.CurrentDomain.BaseDirectory);
            client.Disconnect();

        }

        private void DownloadProgresBar(ulong uploaded)
        {
            progressBar1.Invoke(
                (MethodInvoker)delegate { progressBar1.Value = (int)uploaded; });
        }

        //Отправка данных в список избранных
        private void bu_plusFavourites_Click(object sender, EventArgs e)
        {

        }
    }
}