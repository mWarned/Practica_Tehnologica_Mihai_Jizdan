using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSondaj
{
    public partial class frmReports : Form
    {
        public frmReports()
        {
            InitializeComponent();
        }

        private void frmReports_Load(object sender, EventArgs e)
        {

            this.repView.RefreshReport();
            this.repView.RefreshReport();
        }

        private void divorcedPercentageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string debugPath = Directory.GetCurrentDirectory();
            string binPath = Directory.GetParent(debugPath).FullName;
            string appPath = Directory.GetParent(binPath).FullName;

            this.repView.LocalReport.ReportPath = appPath + "/repDivorcedPercentage.rdlc";
            this.repView.RefreshReport();
        }
    }
}
