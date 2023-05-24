using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                        (System.Windows.Forms.Application.OpenForms["themeQuestionEdit"] as themeQuestionEdit).refreshThemes();
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
                            (System.Windows.Forms.Application.OpenForms["themeQuestionEdit"] as themeQuestionEdit).refreshThemes();
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
    }
}
