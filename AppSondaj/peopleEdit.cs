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
                    dataAD = new SqlDataAdapter("SELECT * FROM Persoana", (SqlConnection)connection);

                    dt = new System.Data.DataTable();
                    dataAD.Fill(dt);
                    gridPeople.DataSource = dt;

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
                // Get the selected record's identifier, assuming it is stored in a column named "ID"
                int selectedID = Convert.ToInt32(gridPeople.SelectedRows[0].Cells["persoanaID"].Value);

                try
                {
                    using (IDbConnection connection = new SqlConnection(Helper.dbConn("dbSondaj")))
                    {
                        // Proceding to see if the selected person has any foreign key references
                        using (SqlCommand command = new SqlCommand("select count(*) from Raspuns where persoanaID = @ID", (SqlConnection)connection))
                        {
                            command.Parameters.AddWithValue("@ID", selectedID);

                            connection.Open();
                            int count = (int)command.ExecuteScalar();

                            if (count > 0)
                            {
                                DialogResult result = MessageBox.Show("Selected person has given an answer to the poll, are you willing to delete the poll result as well?", "Delete answer as well?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (result == DialogResult.Yes)
                                {
                                    List<int> answID = new List<int>();

                                    using (SqlCommand answSrc = new SqlCommand("select raspunsID from Raspuns where persoanaID = @ID", (SqlConnection)connection))
                                    {
                                        answSrc.Parameters.AddWithValue("@ID", selectedID);

                                        connection.Open();
                                        using (SqlDataReader reader = answSrc.ExecuteReader())
                                        {
                                            connection.Open();

                                            while (reader.Read())
                                            {
                                                int id = (int)reader["raspunsID"];
                                                answID.Add(id);
                                            }
                                            reader.Close();
                                        }
                                    }

                                    foreach (int id in answID)
                                    {
                                        using (SqlCommand commandDelete = new SqlCommand("delete from Sondaj where raspunsID = @ID", (SqlConnection)connection))
                                        {
                                            commandDelete.Parameters.AddWithValue("@ID", id);

                                            connection.Open();
                                            commandDelete.ExecuteNonQuery();
                                        }
                                    }

                                    using (SqlCommand commandDelete = new SqlCommand("delete from Raspuns where persoanaID = @ID", (SqlConnection)connection))
                                    {
                                        commandDelete.Parameters.AddWithValue("@ID", selectedID);

                                        connection.Open();
                                        commandDelete.ExecuteNonQuery();
                                    }

                                    using (SqlCommand commandDelete = new SqlCommand("delete from Persoana where persoanaID = @ID", (SqlConnection)connection))
                                    {
                                        commandDelete.Parameters.AddWithValue("@ID", selectedID);

                                        connection.Open();
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

                                    connection.Open();
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

        private void peopleEdit_Load(object sender, EventArgs e)
        {
            refreshPeople();
        }
    }
}
