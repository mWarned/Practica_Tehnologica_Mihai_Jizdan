using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

            btnViewPass.IconChar = FontAwesome.Sharp.IconChar.Eye;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
        }
    }
}
