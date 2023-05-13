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
    public partial class peopleEdit : Form
    {
        private Button currentBtn;
        SqlDataAdapter dataAD;
        DataTable dt;

        public peopleEdit()
        {
            InitializeComponent();

            gridPeople.MultiSelect = false;
        }

        // A struct to store the colors
        private struct btnColors
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
                currentBtn.ForeColor = btnColors.lightBlue;

                // Panel on the right of the button
                pnlSideBtn.BackColor = btnColors.back;
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
                    gridPeople.Columns["persoanaID"].Visible = false;
                    gridPeople.Columns["judetID"].Visible = false;
                    gridPeople.Columns["municipiuID"].Visible = false;
                    gridPeople.Columns["orasID"].Visible = false;

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
            ActivateButton(sender, btnColors.lightBlue);
            addPerson person = new addPerson();
            person.Show();
        }

        private void btnDeletePpl_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, btnColors.lightBlue);
            if (gridPeople.SelectedRows.Count > 0)
            {
                // Get the selected record's identifier
                int selectedID = Convert.ToInt32(gridPeople.SelectedRows[0].Cells["persoanaID"].Value);

                try
                {
                    using (IDbConnection connection = new SqlConnection(Helper.dbConn("dbSondaj")))
                    {
                        // Check if the selected person has any foreign key references
                        using (SqlCommand command = new SqlCommand("select count(*) from Raspuns where persoanaID = @ID", (SqlConnection)connection))
                        {
                            command.Parameters.AddWithValue("@ID", selectedID);

                            connection.Open();
                            int count = (int)command.ExecuteScalar();

                            if (count > 0)
                            {
                                DialogResult result = MessageBox.Show("Selected person has given an answer to the poll, are you willing to delete the poll result as well?",
                                    "Delete answer as well?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (result == DialogResult.Yes)
                                {
                                    using (SqlCommand cmd = new SqlCommand("delete from Sondaj where raspunsID in (select raspunsID from Raspuns where persoanaID = @ID)",
                                        (SqlConnection)connection))
                                    {
                                        cmd.Parameters.AddWithValue("@ID", selectedID);
                                        cmd.ExecuteNonQuery();

                                        connection.Close();
                                    }

                                    using (SqlCommand commandDelete = new SqlCommand("delete from Raspuns where persoanaID = @ID", (SqlConnection)connection))
                                    {
                                        commandDelete.Parameters.AddWithValue("@ID", selectedID);
                                        commandDelete.ExecuteNonQuery();
                                    }

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, btnColors.lightBlue);
            if (gridPeople.SelectedRows.Count > 0)
            {
                // Get the selected record's identifier
                int selectedID = Convert.ToInt32(gridPeople.SelectedRows[0].Cells["persoanaID"].Value);

                try
                {
                    string name = Convert.ToString(gridPeople.SelectedRows[0].Cells["Nume"].Value);
                    string surname = Convert.ToString(gridPeople.SelectedRows[0].Cells["Prenume"].Value);
                    char sex = Convert.ToChar(gridPeople.SelectedRows[0].Cells["sex"].Value);
                    string studies = Convert.ToString(gridPeople.SelectedRows[0].Cells["studii"].Value);
                    string email = Convert.ToString(gridPeople.SelectedRows[0].Cells["email"].Value);
                    DateTime birthday = Convert.ToDateTime(gridPeople.SelectedRows[0].Cells["Prenume"].Value);
                    int judetID = Convert.ToInt32(gridPeople.SelectedRows[0].Cells["judetID"].Value);
                    int municipiuID = Convert.ToInt32(gridPeople.SelectedRows[0].Cells["municipiuID"].Value);
                    int orasID = Convert.ToInt32(gridPeople.SelectedRows[0].Cells["orasID"].Value);
                    bool married = Convert.ToBoolean(gridPeople.SelectedRows[0].Cells["orasID"].Value);
                    bool divorced = Convert.ToBoolean(gridPeople.SelectedRows[0].Cells["orasID"].Value);
                    bool participates = Convert.ToBoolean(gridPeople.SelectedRows[0].Cells["orasID"].Value);

                    addPerson person = new addPerson();
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

        private void peopleEdit_Load(object sender, EventArgs e)
        {
            refreshPeople();
        }
    }
}
