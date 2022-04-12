using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MDM;

namespace InvAddIn
{
    public partial class Fr_Favourites : Form
    {
        ImageList il_2 = new ImageList();
        public List<string> shemaID = new List<string>();

        public Fr_Favourites()
        {
            InitializeComponent();
            shemaID.AddRange(new[] { "711111", "711113", "711121", "711141" });
            
            lv_drawFavourite();
        }

        //Отрисовка избранных схем
        private void lv_drawFavourite()
        {
            string command_types = "SELECT * FROM Types";
            DataTable table_types = MySQL.FillDataTable(command_types);

            il_2.Images.Clear();
            lv_favourites.LargeImageList = il_2;
            int i = 0;

            foreach (DataRow row_types in table_types.Rows)
            {
                if (i <= shemaID.Count - 1)
                {
                    if (row_types["type_id"].ToString() == shemaID[i])
                    {
                        il_2.Images.Add(Image.FromFile(AppDomain.CurrentDomain.BaseDirectory
                        + row_types["type_id"].ToString() + ".png"));

                        il_2.ImageSize = new Size(200, 200);

                        tb_infoFavourites.Text = tb_infoFavourites.Text + row_types["type_id"].ToString() + " ";
                        lv_favourites.Items.Add(row_types["type_id"].ToString());
                        i++;
                    }
                    for (int k = 0; k < lv_favourites.Items.Count; k++)
                    {
                        lv_favourites.Items[k].ImageIndex = k;
                    }
                }
            }
        }

        //Открытие формы "Информация о детале"
        private void lv_favourites_DoubleClick(object sender, EventArgs e)
        {
            InfoModels infoModels = new InfoModels();
            infoModels.id_eskd = lv_favourites.FocusedItem.Text;

            infoModels.pb_drawing.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory
                + lv_favourites.FocusedItem.Text + ".png");

            infoModels.il_1 = il_2;

            infoModels.ShowDialog();
        }

        //Отрисока описания детали в TextBox
        private void lv_favourites_Click(object sender, EventArgs e)
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

            string i_4 = lv_favourites.FocusedItem.Text.Substring(0, lv_favourites.FocusedItem.Text.Length - 1);
            string i_3 = lv_favourites.FocusedItem.Text.Substring(0, lv_favourites.FocusedItem.Text.Length - 2);
            string i_2 = lv_favourites.FocusedItem.Text.Substring(0, lv_favourites.FocusedItem.Text.Length - 3);
            string i_1 = lv_favourites.FocusedItem.Text.Substring(0, lv_favourites.FocusedItem.Text.Length - 4);

            foreach (DataRow row_classes in table_classes.Rows)
            {
                if (row_classes["Class_num"].ToString() == i_1)
                    tb_infoFavourites.Text = "1. " + row_classes["Class_name"].ToString() + '\r' + '\n';
            }

            foreach (DataRow row_subclasses in table_subclasses.Rows)
            {
                if (row_subclasses["subclass_id"].ToString() == i_2)
                    tb_infoFavourites.Text = tb_infoFavourites.Text + "2. "
                        + row_subclasses["subclass_name"].ToString() + '\r' + '\n';
            }
            foreach (DataRow row_groups in table_groups.Rows)
            {
                if (row_groups["group_id"].ToString() == i_3)
                    tb_infoFavourites.Text = tb_infoFavourites.Text + "3. "
                        + row_groups["group_name"].ToString() + '\r' + '\n';
            }
            foreach (DataRow row_subgroups in table_subgroups.Rows)
            {
                if (row_subgroups["subroup_id"].ToString() == i_4)
                    tb_infoFavourites.Text = tb_infoFavourites.Text + "4. "
                        + row_subgroups["subroup_name"].ToString() + '\r' + '\n';
            }
            foreach (DataRow row_types in table_types.Rows)
            {
                if (row_types["type_id"].ToString() == lv_favourites.FocusedItem.Text)
                    tb_infoFavourites.Text = tb_infoFavourites.Text + "5. "
                        + row_types["type_name"].ToString();
            }           
        }

        //Удаление детали из избранного
        private void bu_delFavourites_Click(object sender, EventArgs e)
        {
            shemaID.Remove(lv_favourites.FocusedItem.Text);

            string command_types = "SELECT * FROM Types";
                DataTable table_types = MySQL.FillDataTable(command_types);

            lv_favourites.Clear();
                il_2.Images.Clear();
                lv_favourites.LargeImageList = il_2;
                int i = 0;

            foreach (DataRow row_types in table_types.Rows)
            {
                if (i <= shemaID.Count - 1)
                {
                    if (row_types["type_id"].ToString() == shemaID[i])
                    {
                        il_2.Images.Add(Image.FromFile(AppDomain.CurrentDomain.BaseDirectory
                        + row_types["type_id"].ToString() + ".png"));

                        il_2.ImageSize = new Size(200, 200);

                        tb_infoFavourites.Text = tb_infoFavourites.Text + row_types["type_id"].ToString() + " ";
                        lv_favourites.Items.Add(row_types["type_id"].ToString());
                        i++;
                    }
                    for (int k = 0; k < lv_favourites.Items.Count; k++)
                    {
                        lv_favourites.Items[k].ImageIndex = k;
                    }
                }
            }
        }
    }
}
