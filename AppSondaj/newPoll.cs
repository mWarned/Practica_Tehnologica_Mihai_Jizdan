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
    public partial class newPoll : Form
    {
        SqlDataAdapter dataAD;
        DataTable dt;
        private SqlCommand cmd;
        public int pollID;

        public newPoll()
        {
            InitializeComponent();

            listPeople();
            listThemes();
            listLanguages();
            usrPerson.SelectedIndex = -1;
            usrTheme.SelectedIndex = -1;
            usrLanguage.SelectedIndex = -1;
        }

        // Populate the combobox with people from the database
        public void listPeople()
        {
            try
            {
                // Output all data from Persoana
                using (IDbConnection connection = new SqlConnection(Helper.dbConn("dbSondaj")))
                {
                    dataAD = new SqlDataAdapter("select persoanaID, Nume, Prenume from Persoana", (SqlConnection)connection);
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

                    // Check data

                    // Check if all data was inserted
                    if (usrPerson.Text != "" && usrTheme.Text != "" && usrQuestion.Text != ""
                        && usrAnswer.Text != "")
                    {
                        // SQL insert
                        cmd = new SqlCommand("insert into Raspuns (Raspuns, intrebareID, persoanaID) values('" + usrAnswer.Text + "', '" +
                            questionID + "','" + personID + "'); select scope_identity();", (SqlConnection)connection);
                        cmd.ExecuteNonQuery();

                        int answerID = Convert.ToInt32(cmd.ExecuteScalar());

                        cmd = new SqlCommand("insert into Sondaj (raspunsID, limbaID) values('" + answerID + "', '" +
                            languageID + "')", (SqlConnection)connection);
                        cmd.ExecuteNonQuery();

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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
