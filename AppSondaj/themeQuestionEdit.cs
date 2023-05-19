﻿using System;
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
            addTheme themes = new addTheme();
            themes.Show();
        }

        private void btnUpdateTheme_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorList.lightBlue, "left");
        }

        private void btnDeleteTheme_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorList.lightBlue, "left");

            // Default selected index
            int selectedID = -1;

            // Get the selected record's identifier
            if (gridThemes.SelectedRows.Count > 0)
            {
                selectedID = Convert.ToInt32(gridThemes.SelectedRows[0].Cells["tematicaID"].Value);
            }
            else if (gridThemes.SelectedCells.Count > 0)
            {
                selectedID = Convert.ToInt32(gridThemes.Rows[gridThemes.SelectedCells[0].RowIndex].Cells["tematicaID"].Value);
            }
            else
            {
                MessageBox.Show("Select the theme to be deleted!", "Select theme!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            MessageBox.Show(gridThemes.SelectedCells.Count.ToString() + " " + gridThemes.SelectedRows.Count.ToString());

            // If selectedID is not -1 (default value) - then start deletion
            if (selectedID != -1)
            {
                try
                {
                    using (IDbConnection connection = new SqlConnection(Helper.dbConn("dbSondaj")))
                    {
                        // Check if the selected theme has any foreign key references in answers table
                        using (SqlCommand command = new SqlCommand("select count(*) from Raspuns where tematicaID = @ID", (SqlConnection)connection))
                        {
                            command.Parameters.AddWithValue("@ID", selectedID);

                            connection.Open();
                            int count = (int)command.ExecuteScalar(); // Execute scalar to get the number of foreign keys

                            if (count > 0)
                            {
                                // Ask user if he wants to delete all the answers record as well
                                DialogResult result = MessageBox.Show("Selected theme was used in the poll, are you willing to delete the poll records as well?",
                                    "Delete answer as well?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (result == DialogResult.Yes)
                                {
                                    // Delete the poll based on the ID of the theme
                                    using (SqlCommand cmd = new SqlCommand("delete from Sondaj where raspunsID in (select raspunsID from Raspuns where tematicaID = @ID)",
                                        (SqlConnection)connection))
                                    {
                                        cmd.Parameters.AddWithValue("@ID", selectedID);
                                        cmd.ExecuteNonQuery();

                                        connection.Close();
                                    }

                                    // Delete the answer
                                    using (SqlCommand commandDelete = new SqlCommand("delete from Raspuns where tematicaID = @ID", (SqlConnection)connection))
                                    {
                                        commandDelete.Parameters.AddWithValue("@ID", selectedID);
                                        commandDelete.ExecuteNonQuery();
                                    }

                                    // Delete the theme
                                    using (SqlCommand commandDelete = new SqlCommand("delete from Persoana where tematicaID = @ID", (SqlConnection)connection))
                                    {
                                        commandDelete.Parameters.AddWithValue("@ID", selectedID);
                                        commandDelete.ExecuteNonQuery();
                                    }

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
                                }

                                // Refresh the DataGridView after deletion
                                refreshThemes();

                                MessageBox.Show("Theme was deleted!");
                            }
                        }

                        // Refresh the DataGridView after deletion
                        refreshThemes();

                        MessageBox.Show("Theme was deleted!");
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

            selectedID = -1;
        }

        private void btnRefreshTheme_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorList.lightBlue, "left");
            refreshThemes();
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorList.lightBlue, "right");
        }

        private void btnUpdateQuestion_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorList.lightBlue, "right");
        }

        private void btnDeleteQuestion_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorList.lightBlue, "right");
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
