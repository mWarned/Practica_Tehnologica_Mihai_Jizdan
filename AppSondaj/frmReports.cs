using Microsoft.Reporting.WinForms;
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
        private Form currentFormChild;

        public frmReports()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlReport.Controls.Add(childForm);
            pnlReport.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void frmReports_Load(object sender, EventArgs e)
        {

        }

        private void divorcedPercentageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new repDivorcePercentage());
        }

        private void menWithHigherEducationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new repMenHigherEducation());
        }

        private void peopleBornInGivenMonthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new repPplGivenMonth());
        }

        private void malesFemalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new repPplUnder18());
        }

        private void marriedAndOlderThan20YoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new repPplMarriedOver20());
        }

        private void peopleThatRefusedToParticipateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new repPplRefuse());
        }

        private void pnlReport_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
