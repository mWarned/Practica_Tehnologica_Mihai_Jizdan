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
    public partial class frmAnswer : Form
    {
        SqlDataAdapter dataAD;
        DataTable dt;
        private SqlCommand cmd;
        public int pollID;

        public frmAnswer()
        {
            InitializeComponent();

            listPeople();
            listThemes();
            listLanguages();
            usrPerson.SelectedIndex = -1;
            usrTheme.SelectedIndex = -1;
            usrLanguage.SelectedIndex = -1;

            // Set theme
            setTheme();
        }

        // A struct to store the colors
        private struct colorList
        {
            public static Color color1;
            public static Color color2;
        }

        // Populate the combobox with people from the database
        public void listPeople()
        {
            try
            {
                // Output all data from Persoana
                using (IDbConnection connection = new SqlConnection(Helper.dbConn("dbSondaj")))
                {
                    dataAD = new SqlDataAdapter("select persoanaID, Nume, Prenume from Persoana where Participant = 1", (SqlConnection)connection);
                    dt = new DataTable();
                    dataAD.Fill(dt);

                    // Create a variable to display both Name and Surname as a single string
                    var people = from row in dt.AsEnumerable()
                                 select new
                                 {
                                     NumePrenume = row["Nume"] + " " + row["Prenume"],
                                     persoanaID = row["persoanaID"]
                                 };

                    usrPerson.DisplayMember = "NumePrenume";
                    usrPerson.ValueMember = "persoanaID";
                    usrPerson.DataSource = people.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Output themes data
        public void listThemes()
        {
            try
            {
                // Output all data from Tematica
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

        // Output possible languages
        public void listLanguages()
        {
            try
            {
                // Output all data from Tematica
                using (IDbConnection connection = new SqlConnection(Helper.dbConn("dbSondaj")))
                {
                    dataAD = new SqlDataAdapter("select * from Limba", (SqlConnection)connection);
                    dt = new DataTable();
                    dataAD.Fill(dt);
                    usrLanguage.DataSource = dt;
                    usrLanguage.DisplayMember = "Limba";
                    usrLanguage.ValueMember = "limbaID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Output questions data based on the chosen theme
        private void usrTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val;
            try
            {
                if (usrTheme.SelectedIndex == -1)
                {
                    usrTheme.Text = string.Empty;
                }
                else
                {
                    // Get the selected value index
                    int.TryParse(usrTheme.SelectedValue.ToString(), out val);

                    // Output data
                    using (IDbConnection connection = new SqlConnection(Helper.dbConn("dbSondaj")))
                    {
                        dataAD = new SqlDataAdapter("select * from Intrebare where tematicaID='" + val + "'", (SqlConnection)connection);
                        dt = new DataTable();
                        dataAD.Fill(dt);
                        usrQuestion.DataSource = dt;
                        usrQuestion.DisplayMember = "Intrebare";
                        usrQuestion.ValueMember = "intrebareID";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Output the full question
        private void usrQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            usrQuestionLong.Text = usrQuestion.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Get the inserted data
            int personID = Convert.ToInt32(usrPerson.SelectedValue);
            int questionID = Convert.ToInt32(usrQuestion.SelectedValue);
            int languageID = Convert.ToInt32(usrLanguage.SelectedValue);

            try
            {
                using (IDbConnection connection = new SqlConnection(Helper.dbConn("dbSondaj")))
                {
                    connection.Open();

                    // Check if all data was inserted
                    if (usrPerson.Text != "" && usrTheme.Text != "" && usrQuestion.Text != ""
                        && usrAnswer.Text != "")
                    {
                        // SQL insert
                        cmd = new SqlCommand("insert into Raspuns (Raspuns, intrebareID, persoanaID, limbaID) values('" + usrAnswer.Text + "', '" +
                            questionID + "','" + personID + "','" + languageID + "')", (SqlConnection)connection);
                        cmd.ExecuteNonQuery();

                        // Trigger DataGridView update
                        if (System.Windows.Forms.Application.OpenForms["pollEdit"] != null)
                        {
                            (System.Windows.Forms.Application.OpenForms["pollEdit"] as pollEdit).refreshPoll();
                        }

                        this.Close();

                        MessageBox.Show("Answer added!");
                    }
                    else
                    {
                        MessageBox.Show("Data incomplete, please fill all fields!");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Get the inserted data
            int personID = Convert.ToInt32(usrPerson.SelectedValue);
            int questionID = Convert.ToInt32(usrQuestion.SelectedValue);
            int languageID = Convert.ToInt32(usrLanguage.SelectedValue);

            try
            {
                using (IDbConnection connection = new SqlConnection(Helper.dbConn("dbSondaj")))
                {
                    connection.Open();

                    // Check if all data was inserted
                    if (usrPerson.Text != "" && usrTheme.Text != "" && usrQuestion.Text != ""
                        && usrAnswer.Text != "")
                    {
                        // SQL update
                        cmd = new SqlCommand("update Raspuns set Raspuns='" + usrAnswer.Text + "', intrebareID='" +
                            questionID + "', persoanaID='" + personID + "', limbaID='" + languageID + "' where raspunsID = " + pollID, (SqlConnection)connection);
                        cmd.ExecuteNonQuery();

                        // Trigger DataGridView update
                        if (System.Windows.Forms.Application.OpenForms["pollEdit"] != null)
                        {
                            (System.Windows.Forms.Application.OpenForms["pollEdit"] as pollEdit).refreshPoll();
                        }

                        this.Close();

                        MessageBox.Show("Changes were saved!");
                    }
                    else
                    {
                        MessageBox.Show("Data incomplete, please fill all fields!");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
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
            label3.ForeColor = colorList.color2;
            label4.ForeColor = colorList.color2;
            label5.ForeColor = colorList.color2;
            usrPerson.BackColor = colorList.color1;
            usrPerson.ForeColor = colorList.color2;
            usrTheme.BackColor = colorList.color1;
            usrTheme.ForeColor = colorList.color2;
            usrQuestion.BackColor = colorList.color1;
            usrQuestion.ForeColor = colorList.color2;
            usrQuestionLong.BackColor = colorList.color1;
            usrQuestionLong.ForeColor = colorList.color2;
            usrAnswer.BackColor = colorList.color1;
            usrAnswer.ForeColor = colorList.color2;
            usrLanguage.BackColor = colorList.color1;
            usrLanguage.ForeColor = colorList.color2;
        }
    }
}
