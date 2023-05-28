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
    public partial class frmUser : Form
    {
        private SqlCommand cmd;
        public int accountID;

        public frmUser()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(Helper.dbConn("dbSondaj")))
                {
                    connection.Open();

                    int isAdmin;

                    if (usrAdmin.Checked == true)
                    {
                        isAdmin = 1;
                    }
                    else
                    {
                        isAdmin = 0;
                    }

                    cmd = new SqlCommand("insert into Accounts (login, pass, isAdmin) values ('" + usrLogin.Text + "', '" + usrPass.Text + "', " + isAdmin + ")", (SqlConnection)connection);
                    cmd.ExecuteNonQuery();

                    this.Close();

                    MessageBox.Show("Account added!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(Helper.dbConn("dbSondaj")))
                {
                    connection.Open();

                    // Check if all the data was inserted
                    if (usrLogin.Text != "" && usrPass.Text != "")
                    {
                        int isAdmin;

                        if (usrAdmin.Checked == true)
                        {
                            isAdmin = 1;
                        }
                        else
                        {
                            isAdmin = 0;
                        }

                        // SQL update
                        cmd = new SqlCommand("update Accounts set login='" + usrLogin.Text + "', pass='" +
                            usrPass.Text + "', isAdmin = " + isAdmin + " where accountID = " + accountID, (SqlConnection)connection);
                        cmd.ExecuteNonQuery();

                        // Trigger DataGridView update
                        if (System.Windows.Forms.Application.OpenForms["frmAccounts"] != null)
                        {
                            (System.Windows.Forms.Application.OpenForms["frmAccounts"] as frmAccounts).refreshAccounts();
                        }

                        this.Close();

                        MessageBox.Show("Changes were saved!");
                    }
                    else
                    {
                        MessageBox.Show("Data incomplete, please fill all fields!");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {

        }
    }
}
