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
    public partial class frmSettigns : Form
    {
        public frmSettigns()
        {
            InitializeComponent();

            string theme = Helper.getTheme();
            if (theme.Equals("Dark"))
            {
                usrThDark.Checked = true;
            }
            else if (theme.Equals("Light"))
            {
                usrThLight.Checked = true;
            }
            else if (theme.Equals("Blue"))
            {
                usrThBlue.Checked = true;
            }
        }

        private void btnAccList_Click(object sender, EventArgs e)
        {
            frmAccounts accList = new frmAccounts();
            accList.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmUser user = new frmUser();
            user.btnSave.Visible = true;
            user.btnUpdate.Visible = false;
            user.Show();
        }

        private void setTheme()
        {
            string theme = Helper.getTheme();

            if (theme == null)
            {
                Helper.changeTheme("Blue");
            }
            else if (theme.Equals("Dark"))
            {
                this.BackColor = Color.FromArgb(68, 68, 68);
                lblTheme.ForeColor = Color.White;
                btnAdd.ForeColor = Color.White;
                btnAdd.Image = AppSondaj.Properties.Resources.newD;
                btnAccList.ForeColor = Color.White;
                btnAccList.Image = AppSondaj.Properties.Resources.listD;
                grTheme.ForeColor = Color.White;
                grActions.ForeColor = Color.White;
            }
            else if (theme.Equals("Light"))
            {
                this.BackColor = Color.White;
                lblTheme.ForeColor = Color.Black;
                btnAdd.Image = AppSondaj.Properties.Resources.newL;
                btnAdd.ForeColor = Color.Black;
                btnAccList.ForeColor = Color.Black;
                btnAccList.Image = AppSondaj.Properties.Resources.listL;
                grTheme.ForeColor = Color.Black;
                grActions.ForeColor = Color.Black;
            }
            else if (theme.Equals("Blue"))
            {
                this.BackColor = Color.FromArgb(49, 51, 73);
                lblTheme.ForeColor = Color.FromArgb(0, 126, 246);
                btnAdd.Image = AppSondaj.Properties.Resources._new;
                btnAdd.ForeColor = Color.FromArgb(0, 126, 246);
                btnAccList.ForeColor = Color.FromArgb(0, 126, 246);
                btnAccList.Image = AppSondaj.Properties.Resources.list;
                grTheme.ForeColor = Color.White;
                grActions.ForeColor = Color.White;
            }
        }

        private void usrThDark_CheckedChanged(object sender, EventArgs e)
        {
            Helper.changeTheme("Dark");
            setTheme();
            if (System.Windows.Forms.Application.OpenForms["Main"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["Main"] as Main).setTheme();
            }
        }

        private void usrThLight_CheckedChanged(object sender, EventArgs e)
        {
            Helper.changeTheme("Light");
            setTheme();
            if (System.Windows.Forms.Application.OpenForms["Main"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["Main"] as Main).setTheme();
            }
        }

        private void usrThBlue_CheckedChanged(object sender, EventArgs e)
        {
            Helper.changeTheme("Blue");
            setTheme();
            if (System.Windows.Forms.Application.OpenForms["Main"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["Main"] as Main).setTheme();
            }
        }
    }
}
