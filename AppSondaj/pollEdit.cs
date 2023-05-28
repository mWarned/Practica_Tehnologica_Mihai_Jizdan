using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Controls.Primitives;
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
            ActivateButton(sender, colorList.color2);
            frmAnswer poll = new frmAnswer();
            poll.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorList.color2);
            if (gridPoll.SelectedRows.Count > 0)
            {
                // Get the selected record's identifier
                int selectedID = Convert.ToInt32(gridPoll.SelectedRows[0].Cells["raspunsID"].Value);

                frmAnswer answer = new frmAnswer();

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
            ActivateButton(sender, colorList.color2);
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
            ActivateButton(sender, colorList.color2);
            refreshPoll();
        }

        // Changing the theme
        public void setTheme()
        {
            if (Helper.getTheme().Equals("Dark"))
            {
                colorList.color1 = Color.FromArgb(68, 68, 68);
                colorList.color2 = Color.White;

                this.BackColor = colorList.color1;
                gridPoll.BackgroundColor = Color.FromArgb(23, 23, 23);
                grpActions.ForeColor = Color.White;

                btnAdd.Image = AppSondaj.Properties.Resources.newD;
                btnUpdate.Image = AppSondaj.Properties.Resources.updateD;
                btnDelete.Image = AppSondaj.Properties.Resources.deleteD;
                btnRefresh.Image = AppSondaj.Properties.Resources.refreshD;
            }
            else if (Helper.getTheme().Equals("Light"))
            {
                colorList.color1 = Color.White;
                colorList.color2 = Color.Black;

                this.BackColor = colorList.color1;
                gridPoll.BackgroundColor = Color.FromArgb(210, 211, 219);
                grpActions.ForeColor = Color.Black;

                btnAdd.Image = AppSondaj.Properties.Resources.newL;
                btnUpdate.Image = AppSondaj.Properties.Resources.updateL;
                btnDelete.Image = AppSondaj.Properties.Resources.deleteL;
                btnRefresh.Image = AppSondaj.Properties.Resources.refreshL;
            }
            else if (Helper.getTheme().Equals("Blue"))
            {
                colorList.color1 = Color.FromArgb(49, 51, 73);
                colorList.color2 = Color.FromArgb(0, 126, 246);

                this.BackColor = colorList.color1;
                gridPoll.BackgroundColor = Color.FromArgb(23, 30, 54);
                grpActions.ForeColor = Color.White;

                btnAdd.Image = AppSondaj.Properties.Resources._new;
                btnUpdate.Image = AppSondaj.Properties.Resources.update;
                btnDelete.Image = AppSondaj.Properties.Resources.delete;
                btnRefresh.Image = AppSondaj.Properties.Resources.refresh;
            }

            btnAdd.ForeColor = colorList.color2;
            btnUpdate.ForeColor = colorList.color2;
            btnDelete.ForeColor = colorList.color2;
            btnRefresh.ForeColor = colorList.color2;
        }

        // Loading the data from the database and outputting it 
        private void pollEdit_Load(object sender, EventArgs e)
        {
            refreshPoll();
        }
    }
}
