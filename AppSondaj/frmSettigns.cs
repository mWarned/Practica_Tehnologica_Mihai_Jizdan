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
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
