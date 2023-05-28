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
using System.Windows.Controls.Primitives;
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

            // Set the theme
            setTheme();
        }

        // A struct to store the colors
        private struct colorList
        {
            public static Color color1;
            public static Color color2;
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
            usrLogin.Focus();
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
                            using (SqlCommand checkAdmin = new SqlCommand("SELECT COUNT(*) FROM Accounts WHERE login = @Login AND pass = @Pass AND isAdmin = 1", (SqlConnection)connection))
                            {
                                checkAdmin.Parameters.AddWithValue("@Login", usrLogin.Text);
                                checkAdmin.Parameters.AddWithValue("@Pass", usrPass.Text);

                                int admin = (int)checkAdmin.ExecuteScalar();

                                Main app = new Main();

                                app.lblUser.Text = usrLogin.Text;

                                if (admin > 0)
                                {
                                    app.isAdmin = true;
                                }
                                else
                                {
                                    app.isAdmin = false;
                                }

                                app.Show();

                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Username or password is wrong!");
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

        // Changing the theme
        public void setTheme()
        {
            if (Helper.getTheme().Equals("Dark"))
            {
                colorList.color1 = Color.FromArgb(68, 68, 68);
                colorList.color2 = Color.White;

                this.BackColor = colorList.color1;
                pnlUp.BackColor = Color.FromArgb(23, 23, 23);
                lblLogin.ForeColor = colorList.color2;
                btnExit.IconColor = colorList.color2;

                imgLock.Image = AppSondaj.Properties.Resources.lockD;
                imgUsername.Image = AppSondaj.Properties.Resources.userLoginD;
                imgPassword.Image = AppSondaj.Properties.Resources.passwordD;
                btnLogin.ForeColor = Color.Black;
            }
            else if (Helper.getTheme().Equals("Light"))
            {
                colorList.color1 = Color.White;
                colorList.color2 = Color.Black;

                this.BackColor = colorList.color1;
                pnlUp.BackColor = Color.FromArgb(210, 211, 219);
                lblLogin.ForeColor = colorList.color2;
                btnExit.IconColor = colorList.color2;

                imgLock.Image = AppSondaj.Properties.Resources.lockL;
                imgUsername.Image = AppSondaj.Properties.Resources.userLoginL;
                imgPassword.Image = AppSondaj.Properties.Resources.passwordL;
                btnLogin.ForeColor = Color.White;
            }
            else if (Helper.getTheme().Equals("Blue"))
            {
                colorList.color1 = Color.FromArgb(49, 51, 73);
                colorList.color2 = Color.DarkViolet;

                this.BackColor = colorList.color1;
                pnlUp.BackColor = Color.FromArgb(23, 30, 54);
                lblLogin.ForeColor = colorList.color2;
                btnExit.IconColor = colorList.color2;

                imgLock.Image = AppSondaj.Properties.Resources._lock;
                imgUsername.Image = AppSondaj.Properties.Resources.userLogin;
                imgPassword.Image = AppSondaj.Properties.Resources.password;
                btnLogin.ForeColor = Color.White;
            }

            usrLogin.ForeColor = colorList.color2;
            usrLogin.BackColor = colorList.color1;
            usrPass.ForeColor = colorList.color2;
            usrPass.BackColor = colorList.color1;
            underline1.BackColor = colorList.color2;
            underline2.BackColor = colorList.color2;
            btnViewPass.IconColor = colorList.color2;
            lblClear.ForeColor = colorList.color2;
            btnLogin.BackColor = colorList.color2;
            btnLogin.FlatAppearance.BorderColor = colorList.color2;
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
