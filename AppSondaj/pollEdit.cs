using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace AppSondaj
{
    public partial class pollEdit : Form
    {
        private Button currentBtn;
        SqlDataAdapter dataAD;
        DataTable dt;

        public pollEdit()
        {
            InitializeComponent();

            gridPoll.MultiSelect = false;
            gridPoll.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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

        // Method for outputting data 
        public void refreshPoll()
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(Helper.dbConn("dbSondaj")))
                {
                    dataAD = new SqlDataAdapter("select raspunsID, Nume, Prenume, Tematica, Intrebare, Raspuns, Limba from Raspuns " +
                        "inner join Persoana on Raspuns.persoanaID = Persoana.persoanaID " +
                        "inner join Intrebare on Raspuns.intrebareID = Intrebare.intrebareID " +
                        "inner join Tematica on Intrebare.tematicaID = Tematica.tematicaID " +
                        "inner join Limba on Raspuns.limbaID = Limba.limbaID", (SqlConnection)connection);

                    dt = new System.Data.DataTable();
                    dataAD.Fill(dt);
                    gridPoll.DataSource = dt;

                    gridPoll.Columns["raspunsID"].Visible = false;

                    // Adapt columns width to the largest string
                    foreach (DataGridViewColumn column in gridPoll.Columns)
                    {
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Events for button clicks

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorList.lightBlue);
            newAnswer poll = new newAnswer();
            poll.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorList.lightBlue);
            if (gridPoll.SelectedRows.Count > 0)
            {
                // Get the selected record's identifier
                int selectedID = Convert.ToInt32(gridPoll.SelectedRows[0].Cells["raspunsID"].Value);

                newAnswer answer = new newAnswer();

                try
                {
                    // insert the selected answer data for the update
                    answer.pollID = selectedID;

                    answer.usrPerson.Text = Convert.ToString(gridPoll.SelectedRows[0].Cells["Nume"].Value) + " " + Convert.ToString(gridPoll.SelectedRows[0].Cells["Prenume"].Value);
                    answer.usrTheme.Text = Convert.ToString(gridPoll.SelectedRows[0].Cells["Tematica"].Value);
                    answer.usrQuestion.Text = Convert.ToString(gridPoll.SelectedRows[0].Cells["Intrebare"].Value);
                    answer.usrAnswer.Text = Convert.ToString(gridPoll.SelectedRows[0].Cells["Raspuns"].Value);
                    answer.usrLanguage.Text = Convert.ToString(gridPoll.SelectedRows[0].Cells["Limba"].Value);

                    // Hide save button and show the update button
                    answer.btnSave.Visible = false;
                    answer.btnUpdate.Visible = true;
                    answer.Show();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorList.lightBlue);
            if (gridPoll.SelectedRows.Count > 0)
            {
                // Get the selected record's identifier
                int selectedID = Convert.ToInt32(gridPoll.SelectedRows[0].Cells["raspunsID"].Value);

                try
                {
                    using (IDbConnection connection = new SqlConnection(Helper.dbConn("dbSondaj")))
                    {
                        // Delete the answer
                        using (SqlCommand commandDelete = new SqlCommand("delete from Raspuns where raspunsID = @ID", (SqlConnection)connection))
                        {
                            connection.Open();
                            commandDelete.Parameters.AddWithValue("@ID", selectedID);

                            commandDelete.ExecuteNonQuery();
                            connection.Close();
                        }

                        // Refresh the DataGridView after deletion
                        refreshPoll();

                        MessageBox.Show("Answer was deleted!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Select the row containing the answer whose data you want to delete!", "Select row!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorList.lightBlue);
            refreshPoll();
        }

        // Loading the data from the database and outputting it 
        private void pollEdit_Load(object sender, EventArgs e)
        {
            refreshPoll();
        }
    }
}
