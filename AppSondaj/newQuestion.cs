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
    public partial class newQuestion : Form
    {
        SqlDataAdapter dataAD;
        DataTable dt;
        private SqlCommand cmd;
        public int questionID;

        public newQuestion()
        {
            InitializeComponent();

            listThemes();
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
                        (System.Windows.Forms.Application.OpenForms["themeQuestionEdit"] as themeQuestionEdit).refreshQuestions();
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
                            (System.Windows.Forms.Application.OpenForms["themeQuestionEdit"] as themeQuestionEdit).refreshQuestions();
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
    }
}
