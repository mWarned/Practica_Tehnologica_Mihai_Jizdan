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
    public partial class frmAccounts : Form
    {
        SqlDataAdapter dataAD;
        DataTable dt;

        public frmAccounts()
        {
            InitializeComponent();

            gridAccounts.MultiSelect = false;
            gridAccounts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void refreshAccounts()
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(Helper.dbConn("dbSondaj")))
                {
                    dataAD = new SqlDataAdapter("select * from Accounts", (SqlConnection)connection);

                    dt = new System.Data.DataTable();
                    dataAD.Fill(dt);

                    gridAccounts.DataSource = dt;

                    gridAccounts.Columns["accountID"].Visible = false;


                    // Adapt columns width to the largest string
                    foreach (DataGridViewColumn column in gridAccounts.Columns)
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

        private void frmAccounts_Load(object sender, EventArgs e)
        {
            refreshAccounts();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (gridAccounts.SelectedRows.Count > 0)
            {
                // Get the selected record's identifier
                int selectedID = Convert.ToInt32(gridAccounts.SelectedRows[0].Cells["accountID"].Value);

                frmUser user = new frmUser();

                try
                {
                    // insert the selected account ID to the form for the update
                    user.accountID = selectedID;

                    user.usrLogin.Text = Convert.ToString(gridAccounts.SelectedRows[0].Cells["login"].Value);
                    user.usrPass.Text = Convert.ToString(gridAccounts.SelectedRows[0].Cells["pass"].Value);


                    // Hide save button and show the update button
                    user.btnSave.Visible = false;
                    user.btnUpdate.Visible = true;
                    user.Show();
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
            if (gridAccounts.SelectedRows.Count > 0)
            {
                // Get the selected record's identifier
                int selectedID = Convert.ToInt32(gridAccounts.SelectedRows[0].Cells["accountID"].Value);

                try
                {
                    using (IDbConnection connection = new SqlConnection(Helper.dbConn("dbSondaj")))
                    {
                        // Delete the account
                        using (SqlCommand commandDelete = new SqlCommand("delete from Accounts where accountID = @ID", (SqlConnection)connection))
                        {
                            connection.Open();
                            commandDelete.Parameters.AddWithValue("@ID", selectedID);

                            commandDelete.ExecuteNonQuery();
                            connection.Close();
                        }

                        // Refresh the DataGridView after deletion
                        refreshAccounts();

                        MessageBox.Show("Person was deleted!");
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
