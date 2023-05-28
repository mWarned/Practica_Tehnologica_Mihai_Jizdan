using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace AppSondaj
{
    public partial class frmTheme : Form
    {
        private SqlCommand cmd;
        public int themeID;

        public frmTheme()
        {
            InitializeComponent();

            // Set theme
            setTheme();
        }

        // A struct to store the colors
        private struct colorList
        {
            public static Color color1;
            public static Color color2;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(Helper.dbConn("dbSondaj")))
                {
                    connection.Open();

                    cmd = new SqlCommand("insert into Tematica (Tematica) values ('" + usrTheme.Text + "')", (SqlConnection)connection);
                    cmd.ExecuteNonQuery();

                    if (System.Windows.Forms.Application.OpenForms["themeQuestionEdit"] != null)
                    {
                        (System.Windows.Forms.Application.OpenForms["themeQuestionEdit"] as grActions).refreshThemes();
                    }

                    this.Close();

                    MessageBox.Show("Theme added!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(Helper.dbConn("dbSondaj")))
                {
                    connection.Open();

                    // Check if the data was inserted
                    if (usrTheme.Text != "")
                    {
                        // SQL update
                        cmd = new SqlCommand("update Tematica set Tematica='" + usrTheme.Text + "' where tematicaID = " + themeID, (SqlConnection)connection);
                        cmd.ExecuteNonQuery();

                        // Trigger DataGridView update
                        if (System.Windows.Forms.Application.OpenForms["themeQuestionEdit"] != null)
                        {
                            (System.Windows.Forms.Application.OpenForms["themeQuestionEdit"] as grActions).refreshThemes();
                        }

                        this.Close();

                        MessageBox.Show("Changes were saved!");
                    }
                    else
                    {
                        MessageBox.Show("Data incomplete, please fill the field!");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThemeClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Changing the theme
        public void setTheme()
        {
            if (Helper.getTheme().Equals("Dark"))
            {
                colorList.color1 = Color.FromArgb(68, 68, 68);
                colorList.color2 = Color.White;

                pnlUp.BackColor = Color.FromArgb(23, 23, 23);
                btnExit.IconColor = Color.White;
                btnSave.Image = AppSondaj.Properties.Resources.saveD;
                btnUpdate.Image = AppSondaj.Properties.Resources.updateD;
            }
            else if (Helper.getTheme().Equals("Light"))
            {
                colorList.color1 = Color.White;
                colorList.color2 = Color.Black;

                pnlUp.BackColor = Color.FromArgb(210, 211, 219);
                btnExit.IconColor = Color.Black;
                btnSave.Image = AppSondaj.Properties.Resources.saveL;
                btnUpdate.Image = AppSondaj.Properties.Resources.updateL;
            }
            else if (Helper.getTheme().Equals("Blue"))
            {
                colorList.color1 = Color.FromArgb(49, 51, 73);
                colorList.color2 = Color.White;

                pnlUp.BackColor = Color.FromArgb(23, 30, 54);
                btnExit.IconColor = Color.White;
                btnSave.Image = AppSondaj.Properties.Resources.save;
                btnUpdate.Image = AppSondaj.Properties.Resources.update;
            }

            btnSave.BackColor = colorList.color1;
            btnUpdate.BackColor = colorList.color1;

            btnSave.ForeColor = colorList.color2;
            btnUpdate.ForeColor = colorList.color2;

            this.BackColor = colorList.color1;
            label1.ForeColor = colorList.color2;
            usrTheme.BackColor = colorList.color1;
            usrTheme.ForeColor = colorList.color2;
        }
    }
}
