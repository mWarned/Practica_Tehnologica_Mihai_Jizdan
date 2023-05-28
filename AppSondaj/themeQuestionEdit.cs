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
    public partial class grActions : Form
    {
        private Button currentBtn;
        SqlDataAdapter dataAD;
        DataTable dt;

        public grActions()
        {
            InitializeComponent();

            gridThemes.MultiSelect = false;
            gridQuestions.MultiSelect = false;

            gridThemes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridQuestions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

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
        private void ActivateButton(object senderBtn, Color color, string side)
        {
            if (senderBtn != null)
            {
                if (side.Equals("left"))
                {
                    DisableButton();
                    currentBtn = (Button)senderBtn;
                    currentBtn.ForeColor = color;

                    // Panel on the right of the button
                    pnlSideBtn1.BackColor = color;
                    pnlSideBtn1.Location = new Point(225, currentBtn.Location.Y);
                    pnlSideBtn1.Visible = true;
                    pnlSideBtn1.BringToFront();
                }
                else if (side.Equals("right"))
                {
                    DisableButton();
                    currentBtn = (Button)senderBtn;
                    currentBtn.ForeColor = color;

                    // Panel on the right of the button
                    pnlSideBtn2.BackColor = color;
                    pnlSideBtn2.Location = new Point(225, currentBtn.Location.Y);
                    pnlSideBtn2.Visible = true;
                    pnlSideBtn2.BringToFront();
                }
            }
        }

        // Method for disabling previous activated button
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.ForeColor = colorList.color2;

                // Panel on the right of the button
                pnlSideBtn1.BackColor = colorList.color1;
                pnlSideBtn1.Location = new Point(250, currentBtn.Location.Y);
                pnlSideBtn1.Visible = false;
                pnlSideBtn1.BringToFront();
                
                currentBtn.ForeColor = colorList.color2;

                // Panel on the right of the button
                pnlSideBtn2.BackColor = colorList.color1;
                pnlSideBtn2.Location = new Point(250, currentBtn.Location.Y);
                pnlSideBtn2.Visible = false;
                pnlSideBtn2.BringToFront();
            }
        }

        // Refresh the datagrid output
        public void refreshThemes()
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(Helper.dbConn("dbSondaj")))
                {
                    dataAD = new SqlDataAdapter("select * from Tematica", (SqlConnection)connection);

                    dt = new System.Data.DataTable();
                    dataAD.Fill(dt);
                    gridThemes.DataSource = dt;
                    gridThemes.Columns["tematicaID"].Visible = false;

                    // Adapt columns width to the largest string
                    foreach (DataGridViewColumn column in gridThemes.Columns)
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

        public void refreshQuestions()
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(Helper.dbConn("dbSondaj")))
                {
                    dataAD = new SqlDataAdapter("select intrebareID, Tematica, Intrebare from Intrebare inner join Tematica on Intrebare.tematicaID = Tematica.tematicaID", (SqlConnection)connection);

                    dt = new System.Data.DataTable();
                    dataAD.Fill(dt);
                    gridQuestions.DataSource = dt;
                    gridQuestions.Columns["intrebareID"].Visible = false;

                    // Adapt columns width to the largest string
                    foreach (DataGridViewColumn column in gridQuestions.Columns)
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

        private void btnAddTheme_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorList.color2, "left");
            frmTheme themes = new frmTheme();
            themes.btnSave.Visible = true;
            themes.btnUpdate.Visible = false;
            themes.Show();
        }

        private void btnUpdateTheme_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorList.color2, "left");
            if (gridThemes.SelectedRows.Count > 0)
            {
                // Get the selected record's identifier
                int selectedID = Convert.ToInt32(gridThemes.SelectedRows[0].Cells["tematicaID"].Value);

                frmTheme theme = new frmTheme();

                try
                {
                    // Insert the selected theme data in the update form
                    theme.themeID = selectedID;

                    theme.usrTheme.Text = Convert.ToString(gridThemes.SelectedRows[0].Cells["Tematica"].Value);

                    // Hide save button and show the update button
                    theme.btnSave.Visible = false;
                    theme.btnUpdate.Visible = true;
                    theme.Show();
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

        private void btnDeleteTheme_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorList.color2, "left");

            // Get the selected record's identifier
            int selectedID = Convert.ToInt32(gridThemes.SelectedRows[0].Cells["tematicaID"].Value);

            // Check selected row
            if (gridThemes.SelectedRows.Count > 0)
            {
                try
                {
                    using (IDbConnection connection = new SqlConnection(Helper.dbConn("dbSondaj")))
                    {
                        // Check if the selected theme has any foreign key references in answers table
                        using (SqlCommand command = new SqlCommand("select count(*) from Raspuns where intrebareID in (select intrebareID from Intrebare where tematicaID = @ID)", (SqlConnection)connection))
                        {
                            connection.Open();

                            command.Parameters.AddWithValue("@ID", selectedID);

                            int countQ;

                            using (SqlCommand checkQuestions = new SqlCommand("select count(*) from Intrebare where tematicaID = @ID", (SqlConnection)connection))
                            {
                                checkQuestions.Parameters.AddWithValue("ID", selectedID);

                                countQ = (int)checkQuestions.ExecuteScalar(); // Execute scalar to get number of foreign keys with Questions table
                            }
                           
                            int count = (int)command.ExecuteScalar(); // Execute scalar to get the number of foreign keys Answers table

                            connection.Close();

                            if (count > 0)
                            {
                                // Ask user if he wants to delete all the answers records as well
                                DialogResult result = MessageBox.Show("Selected theme was used in the poll, are you willing to delete the poll records as well?",
                                    "Delete answers as well?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (result == DialogResult.Yes)
                                {
                                    connection.Open();

                                    // Delete the answers
                                    using (SqlCommand commandDelete = new SqlCommand("delete from Raspuns where intrebareID in (select intrebareID from Intrebare where tematicaID = @ID)",
                                        (SqlConnection)connection))
                                    {
                                        commandDelete.Parameters.AddWithValue("@ID", selectedID);
                                        commandDelete.ExecuteNonQuery();
                                    }

                                    // Delete the questions
                                    using (SqlCommand commandDelete = new SqlCommand("delete from Intrebare where tematicaID = @ID", (SqlConnection)connection))
                                    {
                                        commandDelete.Parameters.AddWithValue("@ID", selectedID);
                                        commandDelete.ExecuteNonQuery();
                                    }

                                    // Delete the theme
                                    using (SqlCommand commandDelete = new SqlCommand("delete from Tematica where tematicaID = @ID", (SqlConnection)connection))
                                    {
                                        commandDelete.Parameters.AddWithValue("@ID", selectedID);
                                        commandDelete.ExecuteNonQuery();
                                    }

                                    connection.Close();

                                    // Refresh the DataGridView after deletion
                                    refreshThemes();

                                    MessageBox.Show("Theme was deleted!");
                                }
                            }
                            else if (countQ > 0)
                            {
                                // Ask user if he wants to delete all the questions records as well
                                DialogResult result = MessageBox.Show("Selected theme was used for questions, are you willing to delete the questions records as well?",
                                    "Delete questions as well?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (result == DialogResult.Yes)
                                {
                                    connection.Open();

                                    // Delete the questions
                                    using (SqlCommand commandDelete = new SqlCommand("delete from Intrebare where tematicaID = @ID", (SqlConnection)connection))
                                    {
                                        commandDelete.Parameters.AddWithValue("@ID", selectedID);

                                        commandDelete.ExecuteNonQuery();
                                    }

                                    // Delete the theme
                                    using (SqlCommand commandDelete = new SqlCommand("delete from Tematica where tematicaID = @ID", (SqlConnection)connection))
                                    {
                                        commandDelete.Parameters.AddWithValue("@ID", selectedID);
                                        commandDelete.ExecuteNonQuery();
                                    }

                                    connection.Close();

                                    // Refresh the DataGridView after deletion
                                    refreshThemes();

                                    MessageBox.Show("Theme was deleted!");
                                }
                            }
                            else
                            {
                                // If theme has no foreign keys proceed to deletion
                                using (SqlCommand commandDelete = new SqlCommand("delete from Tematica where tematicaID = @ID", (SqlConnection)connection))
                                {
                                    connection.Open();

                                    commandDelete.Parameters.AddWithValue("@ID", selectedID);

                                    commandDelete.ExecuteNonQuery();

                                    connection.Close();
                                }

                                // Refresh the DataGridView after deletion
                                refreshThemes();

                                MessageBox.Show("Theme was deleted!");
                            }
                        }

                        // Refresh the DataGridView after deletion
                        refreshThemes();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Select the theme to be deleted!", "Select theme!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRefreshTheme_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorList.color2, "left");
            refreshThemes();
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorList.color2, "right");
            frmQuestion questions = new frmQuestion();
            questions.btnSave.Visible = true;
            questions.btnUpdate.Visible = false;
            questions.Show();
        }

        private void btnUpdateQuestion_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorList.color2, "right");
            if (gridQuestions.SelectedRows.Count > 0)
            {
                // Get the selected record's identifier
                int selectedID = Convert.ToInt32(gridQuestions.SelectedRows[0].Cells["intrebareID"].Value);

                frmQuestion questions = new frmQuestion();

                try
                {
                    // Insert the selected theme data in the update form
                    questions.questionID = selectedID;

                    questions.usrTheme.Text = Convert.ToString(gridQuestions.SelectedRows[0].Cells["Tematica"].Value);
                    questions.usrQuestion.Text = Convert.ToString(gridQuestions.SelectedRows[0].Cells["Intrebare"].Value);

                    // Hide save button and show the update button
                    questions.btnSave.Visible = false;
                    questions.btnUpdate.Visible = true;
                    questions.Show();
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

        private void btnDeleteQuestion_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorList.color2, "right");

            // Get the selected record's identifier
            int selectedID = Convert.ToInt32(gridQuestions.SelectedRows[0].Cells["intrebareID"].Value);

            // Check selected row
            if (gridQuestions.SelectedRows.Count > 0)
            {
                try
                {
                    using (IDbConnection connection = new SqlConnection(Helper.dbConn("dbSondaj")))
                    {
                        // Check if the selected theme has any foreign key references in answers table
                        using (SqlCommand command = new SqlCommand("select count(*) from Raspuns where intrebareID = @ID", (SqlConnection)connection))
                        {
                            connection.Open();

                            command.Parameters.AddWithValue("@ID", selectedID);

                            int count = (int)command.ExecuteScalar(); // Execute scalar to get the number of foreign keys Answers table

                            connection.Close();

                            if (count > 0)
                            {
                                // Ask user if he wants to delete all the answers records as well
                                DialogResult result = MessageBox.Show("Selected question was used in the poll, are you willing to delete the poll records as well?",
                                    "Delete answers as well?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (result == DialogResult.Yes)
                                {
                                    connection.Open();

                                    // Delete the answers
                                    using (SqlCommand commandDelete = new SqlCommand("delete from Raspuns where intrebareID = @ID",
                                        (SqlConnection)connection))
                                    {
                                        commandDelete.Parameters.AddWithValue("@ID", selectedID);
                                        commandDelete.ExecuteNonQuery();
                                    }

                                    // Delete the question
                                    using (SqlCommand commandDelete = new SqlCommand("delete from Intrebare where intrebareID = @ID", (SqlConnection)connection))
                                    {
                                        commandDelete.Parameters.AddWithValue("@ID", selectedID);
                                        commandDelete.ExecuteNonQuery();
                                    }

                                    connection.Close();

                                    // Refresh the DataGridView after deletion
                                    refreshQuestions();

                                    MessageBox.Show("Question was deleted!");
                                }
                            }
                            else
                            {
                                // If theme has no foreign keys proceed to deletion
                                using (SqlCommand commandDelete = new SqlCommand("delete from Intrebare where intrebareID = @ID", (SqlConnection)connection))
                                {
                                    connection.Open();

                                    commandDelete.Parameters.AddWithValue("@ID", selectedID);

                                    commandDelete.ExecuteNonQuery();

                                    connection.Close();
                                }

                                // Refresh the DataGridView after deletion
                                refreshQuestions();

                                MessageBox.Show("Question was deleted!");
                            }
                        }

                        // Refresh the DataGridView after deletion
                        refreshQuestions();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Select the question to be deleted!", "Select question!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRefreshQuestion_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorList.color2, "right");
            refreshQuestions();
        }

        // Changing the theme
        public void setTheme()
        {
            if (Helper.getTheme().Equals("Dark"))
            {
                colorList.color1 = Color.FromArgb(68, 68, 68);
                colorList.color2 = Color.White;

                this.BackColor = colorList.color1;
                gridThemes.BackgroundColor = Color.FromArgb(23, 23, 23);
                gridQuestions.BackgroundColor = Color.FromArgb(23, 23, 23);
                grpActionsT.ForeColor = Color.White;
                grpActionsQ.ForeColor = Color.White;

                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                gridThemes.ForeColor = Color.White;
                gridQuestions.ForeColor = Color.White;

                btnAddTheme.Image = AppSondaj.Properties.Resources.newD;
                btnAddQuestion.Image = AppSondaj.Properties.Resources.newD;

                btnUpdateTheme.Image = AppSondaj.Properties.Resources.updateD;
                btnUpdateQuestion.Image = AppSondaj.Properties.Resources.updateD;

                btnDeleteTheme.Image = AppSondaj.Properties.Resources.deleteD;
                btnDeleteQuestion.Image = AppSondaj.Properties.Resources.deleteD;

                btnRefreshTheme.Image = AppSondaj.Properties.Resources.refreshD;
                btnRefreshQuestion.Image = AppSondaj.Properties.Resources.refreshD;
            }
            else if (Helper.getTheme().Equals("Light"))
            {
                colorList.color1 = Color.White;
                colorList.color2 = Color.Black;

                this.BackColor = colorList.color1;
                gridThemes.BackgroundColor = Color.FromArgb(210, 211, 219);
                gridQuestions.BackgroundColor = Color.FromArgb(210, 211, 219);
                grpActionsT.ForeColor = Color.White;
                grpActionsQ.ForeColor = Color.White;

                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                gridThemes.ForeColor = Color.White;
                grpActionsQ.ForeColor = Color.White;

                btnAddTheme.Image = AppSondaj.Properties.Resources.newL;
                btnAddQuestion.Image = AppSondaj.Properties.Resources.newL;

                btnUpdateTheme.Image = AppSondaj.Properties.Resources.updateL;
                btnUpdateQuestion.Image = AppSondaj.Properties.Resources.updateL;

                btnDeleteTheme.Image = AppSondaj.Properties.Resources.deleteL;
                btnDeleteQuestion.Image = AppSondaj.Properties.Resources.deleteL;

                btnRefreshTheme.Image = AppSondaj.Properties.Resources.refreshL;
                btnRefreshQuestion.Image = AppSondaj.Properties.Resources.refreshL;
            }
            else if (Helper.getTheme().Equals("Blue"))
            {
                colorList.color1 = Color.FromArgb(49, 51, 73);
                colorList.color2 = Color.FromArgb(0, 126, 246);

                this.BackColor = colorList.color1;
                gridThemes.BackgroundColor = Color.FromArgb(23, 30, 54);
                gridQuestions.BackgroundColor = Color.FromArgb(23, 30, 54);
                grpActionsT.ForeColor = Color.White;
                grpActionsQ.ForeColor = Color.White;

                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                gridThemes.ForeColor = Color.White;
                grpActionsQ.ForeColor = Color.White;

                btnAddTheme.Image = AppSondaj.Properties.Resources._new;
                btnAddQuestion.Image = AppSondaj.Properties.Resources._new;

                btnUpdateTheme.Image = AppSondaj.Properties.Resources.update;
                btnUpdateQuestion.Image = AppSondaj.Properties.Resources.update;

                btnDeleteTheme.Image = AppSondaj.Properties.Resources.delete;
                btnDeleteQuestion.Image = AppSondaj.Properties.Resources.delete;

                btnRefreshTheme.Image = AppSondaj.Properties.Resources.refresh;
                btnRefreshQuestion.Image = AppSondaj.Properties.Resources.refresh;
            }

            gridThemes.ForeColor = Color.Black;
            gridQuestions.ForeColor = Color.Black;

            btnAddTheme.ForeColor = colorList.color2;
            btnUpdateTheme.ForeColor = colorList.color2;
            btnDeleteTheme.ForeColor = colorList.color2;
            btnRefreshTheme.ForeColor = colorList.color2;
            btnAddQuestion.ForeColor = colorList.color2;
            btnUpdateQuestion.ForeColor = colorList.color2;
            btnDeleteQuestion.ForeColor = colorList.color2;
            btnRefreshQuestion.ForeColor = colorList.color2;
        }

        private void themeEdit_Load(object sender, EventArgs e)
        {
            refreshThemes();
            refreshQuestions();
        }
    }
}
