using System;
using System.Collections;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

            // Set visibility button icon
            btnViewPass.IconChar = FontAwesome.Sharp.IconChar.Eye;
        }

        private void btnViewPass_Click(object sender, EventArgs e)
        {
            // If password characters are hidden - make visible
            if (usrPass.UseSystemPasswordChar == true)
            {
                // Change button icon
                btnViewPass.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;

                // Show the password
                usrPass.UseSystemPasswordChar = false;
            }
            else
            {
                // Change button icon
                btnViewPass.IconChar = FontAwesome.Sharp.IconChar.Eye;

                // Hide the password
                usrPass.UseSystemPasswordChar = true;
            }

            // Focus to the label to avoid annoying click border
            lblLogin.Focus();
        }

        // Text boxes reset
        private void lblClear_Click(object sender, EventArgs e)
        {
            usrLogin.Text = string.Empty;
            usrPass.Text = string.Empty;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(Helper.dbConn("dbSondaj")))
                {
                    using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Accounts WHERE login = @Login AND pass = @Pass", (SqlConnection)connection))
                    {
                        connection.Open();

                        // Add login and password variables
                        command.Parameters.AddWithValue("@Login", usrLogin.Text);
                        command.Parameters.AddWithValue("@Pass", usrPass.Text);

                        // Count number of accounts with same login and password
                        int count = (int)command.ExecuteScalar();

                        // if account exists open new main form
                        if (count > 0)
                        {
                            Main app = new Main();

                            app.lblUser.Text = usrLogin.Text;
                            app.Show();

                            this.Close();
                        }
                        else
                        {
                            // Else check if the login or the password is wrong
                            using (SqlCommand checkLogin = new SqlCommand("SELECT COUNT(*) FROM Accounts WHERE login = @Login", (SqlConnection)connection))
                            {
                                checkLogin.Parameters.AddWithValue("@Login", usrLogin.Text);

                                int loginCount = (int) checkLogin.ExecuteScalar();

                                if (loginCount > 0)
                                {
                                    MessageBox.Show("Wrong password!");
                                }
                                else
                                {
                                    MessageBox.Show("Login failed!");
                                }
                            }
                        }

                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
