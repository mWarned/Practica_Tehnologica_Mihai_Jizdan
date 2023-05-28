using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
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

            // Set theme
            setTheme();
        }

        // A struct to store the colors
        private struct colorList
        {
            public static Color color1;
            public static Color color2;
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
                currentBtn.ForeColor = colorList.color2;

                // Panel on the right of the button
                pnlSideBtn.BackColor = colorList.color1;
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
                        DateTime now = DateTime.Now;
                        DateTime birthDate;

                        // Parse the date and calculate age
                        if (DateTime.TryParseExact(row["DataNasterii"].ToString(), "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out birthDate))
                        {
                            int age = now.Year - birthDate.Year;

                            // If the person haven't had this year's birthday, substract 1
                            if (now.Month < birthDate.Month || (now.Month == birthDate.Month && now.Day < birthDate.Day))
                            {
                                age--;
                            }

                            row["Age"] = age;
                        }
                        else
                        {
                            MessageBox.Show("There's an error with the date format");
                        }
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
            ActivateButton(sender, colorList.color2);
            frmPerson person = new frmPerson();
            person.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorList.color2);
            if (gridPeople.SelectedRows.Count > 0)
            {
                // Get the selected record's identifier
                int selectedID = Convert.ToInt32(gridPeople.SelectedRows[0].Cells["persoanaID"].Value);

                frmPerson person = new frmPerson();

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
                    try
                    {
                        DateTime usrBirthday = DateTime.ParseExact((string)gridPeople.SelectedRows[0].Cells["DataNasterii"].Value, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                        person.usrBirthday.Value = usrBirthday;
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Date format error!");
                    }
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
            ActivateButton(sender, colorList.color2);
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
                            connection.Close();

                            if (count > 0)
                            {
                                // Ask user if he wants to delete all the answers record as well
                                DialogResult result = MessageBox.Show("Selected person has given an answer to the poll, are you willing to delete the poll records as well?",
                                    "Delete answer as well?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (result == DialogResult.Yes)
                                {
                                    connection.Open();

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

                                    connection.Close();

                                    // Refresh the DataGridView after deletion
                                    refreshPeople();

                                    MessageBox.Show("Person was deleted!");
                                }
                            }
                            else
                            {
                                connection.Open();

                                // Delete the person
                                using (SqlCommand commandDelete = new SqlCommand("delete from Persoana where persoanaID = @ID", (SqlConnection)connection))
                                {
                                    commandDelete.Parameters.AddWithValue("@ID", selectedID);

                                    commandDelete.ExecuteNonQuery();
                                }

                                connection.Close();

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

        public void setTheme()
        {
            if (Helper.getTheme().Equals("Dark"))
            {
                colorList.color1 = Color.FromArgb(68, 68, 68);
                colorList.color2 = Color.White;

                this.BackColor = colorList.color1;
                gridPeople.BackgroundColor = Color.FromArgb(23, 23, 23);

                btnAdd.Image = AppSondaj.Properties.Resources.newD;
                btnUpdate.Image = AppSondaj.Properties.Resources.updateD;
                btnDelete.Image = AppSondaj.Properties.Resources.deleteD;
                btnSortAsc.Image = AppSondaj.Properties.Resources.up_arrowD;
                btnSortDesc.Image = AppSondaj.Properties.Resources.down_arrowD;
                btnRefresh.Image = AppSondaj.Properties.Resources.refreshD;
                grpActions.ForeColor = Color.White;
            }
            else if (Helper.getTheme().Equals("Light"))
            {
                colorList.color1 = Color.White;
                colorList.color2 = Color.Black;

                this.BackColor = colorList.color1;
                gridPeople.BackgroundColor = Color.FromArgb(210, 211, 219);

                btnAdd.Image = AppSondaj.Properties.Resources.newL;
                btnUpdate.Image = AppSondaj.Properties.Resources.updateL;
                btnDelete.Image = AppSondaj.Properties.Resources.deleteL;
                btnSortAsc.Image = AppSondaj.Properties.Resources.up_arrowL;
                btnSortDesc.Image = AppSondaj.Properties.Resources.down_arrowL;
                btnRefresh.Image = AppSondaj.Properties.Resources.refreshL;
                grpActions.ForeColor = Color.White;
            }
            else if (Helper.getTheme().Equals("Blue"))
            {
                colorList.color1 = Color.FromArgb(49, 51, 73);
                colorList.color2 = Color.FromArgb(0, 126, 246);

                this.BackColor = colorList.color1;
                gridPeople.BackgroundColor = Color.FromArgb(23, 30, 54);

                btnAdd.Image = AppSondaj.Properties.Resources._new;
                btnUpdate.Image = AppSondaj.Properties.Resources.update;
                btnDelete.Image = AppSondaj.Properties.Resources.delete;
                btnSortAsc.Image = AppSondaj.Properties.Resources.up_arrow;
                btnSortDesc.Image = AppSondaj.Properties.Resources.down_arrow;
                btnRefresh.Image = AppSondaj.Properties.Resources.refresh;
                grpActions.ForeColor = Color.White;
            }

            gridPeople.BackgroundColor = colorList.color1;

            btnAdd.ForeColor = colorList.color2;
            btnUpdate.ForeColor = colorList.color2;
            btnDelete.ForeColor = colorList.color2;
            btnSortAsc.ForeColor = colorList.color2;
            btnSortDesc.ForeColor = colorList.color2;
            btnRefresh.ForeColor = colorList.color2;
        }

        private void peopleEdit_Load(object sender, EventArgs e)
        {
            refreshPeople();
        }
    }
}
