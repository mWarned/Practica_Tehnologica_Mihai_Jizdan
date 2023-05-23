using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace AppSondaj
{
    public partial class peopleEdit : Form
    {
        private Button currentBtn;
        SqlDataAdapter dataAD;
        DataTable dt;

        public peopleEdit()
        {
            InitializeComponent();

            gridPeople.MultiSelect = false;
            gridPeople.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        // A struct to store the colors
        private struct colorList
        {
            public static Color back = Color.FromArgb(23, 30, 54);
            public static Color lightBlue = Color.FromArgb(0, 126, 246);
        }

        // Method for activated button
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (Button)senderBtn;
                currentBtn.ForeColor = color;

                // Panel on the right of the button
                pnlSideBtn.BackColor = color;
                pnlSideBtn.Location = new Point(224, currentBtn.Location.Y);
                pnlSideBtn.Visible = true;
                pnlSideBtn.BringToFront();
            }
        }

        // Method for disabling previous activated button
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.ForeColor = colorList.lightBlue;

                // Panel on the right of the button
                pnlSideBtn.BackColor = colorList.back;
                pnlSideBtn.Location = new Point(225, currentBtn.Location.Y);
                pnlSideBtn.Visible = true;
                pnlSideBtn.BringToFront();
            }
        }

        // Refresh the datagrid output
        public void refreshPeople()
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(Helper.dbConn("dbSondaj")))
                {
                    dataAD = new SqlDataAdapter("select persoanaID, Nume, Prenume, sex, studii, email, DataNasterii, Persoana.judetID, numeJudet, Persoana.municipiuID, numeMunicipiu, Persoana.orasID, numeOras, Casatorit, Divortat, Participant" +
                        " from Persoana inner join Judet on Persoana.judetID = Judet.judetID inner join Municipiu on Persoana.municipiuID = Municipiu.municipiuID" +
                        " inner join Oras on Persoana.orasID = Oras.orasID", (SqlConnection)connection);

                    dt = new System.Data.DataTable();
                    dataAD.Fill(dt);

                    gridPeople.DataSource = dt;

                    DataColumn Age = new DataColumn();

                    dt.Columns.Add("Age", typeof(int));

                    foreach (DataRow row in dt.Rows)
                    {
                        DateTime d0 = new DateTime(1, 1, 1);
                        DateTime now = DateTime.Now;
                        TimeSpan ts = now - Convert.ToDateTime(row["DataNasterii"]);

                        row["Age"] = ((d0 + ts).Year - 1);
                    }

                    gridPeople.Columns["persoanaID"].Visible = false;
                    gridPeople.Columns["judetID"].Visible = false;
                    gridPeople.Columns["municipiuID"].Visible = false;
                    gridPeople.Columns["orasID"].Visible = false;
                    gridPeople.Columns["Age"].Visible = false;

                    // Adapt columns width to the largest string
                    foreach (DataGridViewColumn column in gridPeople.Columns)
                    {
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
        }

        // Events for button clicks

        private void btnAddPpl_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorList.lightBlue);
            newPerson person = new newPerson();
            person.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorList.lightBlue);
            if (gridPeople.SelectedRows.Count > 0)
            {
                // Get the selected record's identifier
                int selectedID = Convert.ToInt32(gridPeople.SelectedRows[0].Cells["persoanaID"].Value);

                newPerson person = new newPerson();

                try
                {
                    // insert the selected person data to the form for the update
                    person.personID = selectedID;

                    person.usrName.Text = Convert.ToString(gridPeople.SelectedRows[0].Cells["Nume"].Value);
                    person.usrSurname.Text = Convert.ToString(gridPeople.SelectedRows[0].Cells["Prenume"].Value);
                    if (Convert.ToChar(gridPeople.SelectedRows[0].Cells["sex"].Value) == 'M')
                    {
                        person.usrM.Checked = true;
                    }
                    else
                    {
                        person.usrF.Checked = true;
                    }
                    person.usrStudies.Text = Convert.ToString(gridPeople.SelectedRows[0].Cells["studii"].Value);
                    person.usrEmail.Text = Convert.ToString(gridPeople.SelectedRows[0].Cells["email"].Value);
                    person.usrBirthday.Value = Convert.ToDateTime(gridPeople.SelectedRows[0].Cells["DataNasterii"].Value);
                    person.usrJudet.Text = Convert.ToString(gridPeople.SelectedRows[0].Cells["numeJudet"].Value);
                    person.usrMunicipiu.Text = Convert.ToString(gridPeople.SelectedRows[0].Cells["numeMunicipiu"].Value);
                    person.usrOras.Text = Convert.ToString(gridPeople.SelectedRows[0].Cells["numeOras"].Value);
                    if (Convert.ToBoolean(gridPeople.SelectedRows[0].Cells["Casatorit"].Value) == true)
                    {
                        person.usrMarried.Checked = true;
                    }
                    if (Convert.ToBoolean(gridPeople.SelectedRows[0].Cells["Divortat"].Value) == true)
                    {
                        person.usrDivorced.Checked = true;
                    }
                    if (Convert.ToBoolean(gridPeople.SelectedRows[0].Cells["Participant"].Value) == true)
                    {
                        person.usrParticipated.Checked = true;
                    }

                    // Hide save button and show the update button
                    person.btnSave.Visible = false;
                    person.btnUpdate.Visible = true;
                    person.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Select the row containing the person whose data you want to update!", "Select row!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeletePpl_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorList.lightBlue);
            if (gridPeople.SelectedRows.Count > 0)
            {
                // Get the selected record's identifier
                int selectedID = Convert.ToInt32(gridPeople.SelectedRows[0].Cells["persoanaID"].Value);

                try
                {
                    using (IDbConnection connection = new SqlConnection(Helper.dbConn("dbSondaj")))
                    {
                        // Check if the selected person has any foreign key references in answers table
                        using (SqlCommand command = new SqlCommand("select count(*) from Raspuns where persoanaID = @ID", (SqlConnection)connection))
                        {
                            command.Parameters.AddWithValue("@ID", selectedID);

                            connection.Open();
                            int count = (int)command.ExecuteScalar(); // Execute scalar to get the number of foreign keys

                            if (count > 0)
                            {
                                // Ask user if he wants to delete all the answers record as well
                                DialogResult result = MessageBox.Show("Selected person has given an answer to the poll, are you willing to delete the poll records as well?",
                                    "Delete answer as well?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (result == DialogResult.Yes)
                                {
                                    // Delete the answer of the person
                                    using (SqlCommand commandDelete = new SqlCommand("delete from Raspuns where persoanaID = @ID", (SqlConnection)connection))
                                    {
                                        commandDelete.Parameters.AddWithValue("@ID", selectedID);
                                        commandDelete.ExecuteNonQuery();
                                    }

                                    // Delete the person
                                    using (SqlCommand commandDelete = new SqlCommand("delete from Persoana where persoanaID = @ID", (SqlConnection)connection))
                                    {
                                        commandDelete.Parameters.AddWithValue("@ID", selectedID);
                                        commandDelete.ExecuteNonQuery();
                                    }

                                    // Refresh the DataGridView after deletion
                                    refreshPeople();

                                    MessageBox.Show("Person was deleted!");
                                }
                            }
                            else
                            {
                                // Delete the person
                                using (SqlCommand commandDelete = new SqlCommand("delete from Persoana where persoanaID = @ID", (SqlConnection)connection))
                                {
                                    commandDelete.Parameters.AddWithValue("@ID", selectedID);

                                    commandDelete.ExecuteNonQuery();
                                }

                                // Refresh the DataGridView after deletion
                                refreshPeople();

                                MessageBox.Show("Person was deleted!");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Select the row containing the person you want to delete!", "Select row!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSortAsc_Click(object sender, EventArgs e)
        {
            gridPeople.Sort(gridPeople.Columns["Age"], ListSortDirection.Ascending);
        }

        private void btnSortDesc_Click(object sender, EventArgs e)
        {
            gridPeople.Sort(gridPeople.Columns["Age"], ListSortDirection.Descending);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshPeople();
        }

        private void peopleEdit_Load(object sender, EventArgs e)
        {
            refreshPeople();
        }
    }
}
