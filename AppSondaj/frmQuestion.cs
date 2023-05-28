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
    public partial class frmQuestion : Form
    {
        SqlDataAdapter dataAD;
        DataTable dt;
        private SqlCommand cmd;
        public int questionID;

        public frmQuestion()
        {
            InitializeComponent();

            listThemes();

            // Set theme
            setTheme();
        }

        // A struct to store the colors
        private struct colorList
        {
            public static Color color1;
            public static Color color2;
        }

        public void listThemes()
        {
            try
            {
                // Output all data from Judet
                using (IDbConnection connection = new SqlConnection(Helper.dbConn("dbSondaj")))
                {
                    dataAD = new SqlDataAdapter("select * from Tematica", (SqlConnection)connection);
                    dt = new DataTable();
                    dataAD.Fill(dt);
                    usrTheme.DataSource = dt;
                    usrTheme.DisplayMember = "Tematica";
                    usrTheme.ValueMember = "tematicaID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(Helper.dbConn("dbSondaj")))
                {
                    int themeID = Convert.ToInt32(usrTheme.SelectedValue);

                    connection.Open();

                    cmd = new SqlCommand("insert into Intrebare (Intrebare, tematicaID) values ('" + usrQuestion.Text + "', '" + themeID + "')", (SqlConnection)connection);
                    cmd.ExecuteNonQuery();

                    if (System.Windows.Forms.Application.OpenForms["themeQuestionEdit"] != null)
                    {
                        (System.Windows.Forms.Application.OpenForms["themeQuestionEdit"] as grActions).refreshQuestions();
                    }

                    this.Close();

                    MessageBox.Show("Question added!");
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
                    int themeID = Convert.ToInt32(usrTheme.SelectedValue);

                    connection.Open();

                    // Check if the data was inserted
                    if (usrTheme.Text != "" && usrQuestion.Text != "")
                    {
                        // SQL update
                        cmd = new SqlCommand("update Intrebare set Intrebare='" + usrQuestion.Text + "', tematicaID='" + themeID + "'  where intrebareID = " + questionID, (SqlConnection)connection);
                        cmd.ExecuteNonQuery();

                        // Trigger DataGridView update
                        if (System.Windows.Forms.Application.OpenForms["themeQuestionEdit"] != null)
                        {
                            (System.Windows.Forms.Application.OpenForms["themeQuestionEdit"] as grActions).refreshQuestions();
                        }

                        this.Close();

                        MessageBox.Show("Changes were saved!");
                    }
                    else
                    {
                        MessageBox.Show("Data incomplete, please fill the fields!");
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
            label2.ForeColor = colorList.color2;
            usrTheme.BackColor = colorList.color1;
            usrTheme.ForeColor = colorList.color2;
            usrQuestion.BackColor = colorList.color1;
            usrQuestion.ForeColor = colorList.color2;
        }
    }
}
