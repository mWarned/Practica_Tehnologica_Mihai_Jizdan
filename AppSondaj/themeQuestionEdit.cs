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
    public partial class themeQuestionEdit : Form
    {
        private Button currentBtn;
        SqlDataAdapter dataAD;
        DataTable dt;

        public themeQuestionEdit()
        {
            InitializeComponent();

            gridThemes.MultiSelect = false;
            gridQuestions.MultiSelect = false;

            gridThemes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridQuestions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        // A struct to store the colors
        private struct colorList
        {
            public static Color back = Color.FromArgb(23, 30, 54);
            public static Color lightBlue = Color.FromArgb(0, 126, 246);
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
                currentBtn.ForeColor = colorList.lightBlue;

                // Panel on the right of the button
                pnlSideBtn1.BackColor = colorList.back;
                pnlSideBtn1.Location = new Point(250, currentBtn.Location.Y);
                pnlSideBtn1.Visible = false;
                pnlSideBtn1.BringToFront();
                
                currentBtn.ForeColor = colorList.lightBlue;

                // Panel on the right of the button
                pnlSideBtn2.BackColor = colorList.back;
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
            ActivateButton(sender, colorList.lightBlue, "left");
            newTheme themes = new newTheme();
            themes.btnSave.Visible = true;
            themes.btnUpdate.Visible = false;
            themes.Show();
        }

        private void btnUpdateTheme_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorList.lightBlue, "left");
            if (gridThemes.SelectedRows.Count > 0)
            {
                // Get the selected record's identifier
                int selectedID = Convert.ToInt32(gridThemes.SelectedRows[0].Cells["tematicaID"].Value);

                newTheme theme = new newTheme();

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
            ActivateButton(sender, colorList.lightBlue, "left");

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

                                    // Delete the polls
                                    using (SqlCommand cmd = new SqlCommand("delete from Sondaj where raspunsID in (select raspunsID from Raspuns where intrebareID in (select intrebareID from Intrebare where tematicaID = @ID))",
                                        (SqlConnection)connection))
                                    {
                                        cmd.Parameters.AddWithValue("@ID", selectedID);
                                        cmd.ExecuteNonQuery();
                                    }

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
            ActivateButton(sender, colorList.lightBlue, "left");
            refreshThemes();
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorList.lightBlue, "right");
            newQuestion questions = new newQuestion();
            questions.btnSave.Visible = true;
            questions.btnUpdate.Visible = false;
            questions.Show();
        }

        private void btnUpdateQuestion_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorList.lightBlue, "right");
            if (gridQuestions.SelectedRows.Count > 0)
            {
                // Get the selected record's identifier
                int selectedID = Convert.ToInt32(gridQuestions.SelectedRows[0].Cells["intrebareID"].Value);

                newQuestion questions = new newQuestion();

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
            ActivateButton(sender, colorList.lightBlue, "right");

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

                                    // Delete the polls
                                    using (SqlCommand cmd = new SqlCommand("delete from Sondaj where raspunsID in (select raspunsID from Raspuns where intrebareID = @ID)",
                                        (SqlConnection)connection))
                                    {
                                        cmd.Parameters.AddWithValue("@ID", selectedID);
                                        cmd.ExecuteNonQuery();
                                    }

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
            ActivateButton(sender, colorList.lightBlue, "right");
            refreshQuestions();
        }

        private void themeEdit_Load(object sender, EventArgs e)
        {
            refreshThemes();
            refreshQuestions();
        }
    }
}
