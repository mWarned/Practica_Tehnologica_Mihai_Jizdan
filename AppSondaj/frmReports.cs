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

            // Set theme
            setTheme();
        }

        // A struct to store the colors
        private struct colorList
        {
            public static Color color1;
            public static Color color2;
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

        // Changing the theme
        public void setTheme()
        {
            if (Helper.getTheme().Equals("Dark"))
            {
                colorList.color1 = Color.FromArgb(68, 68, 68);
                colorList.color2 = Color.White;

                menuStrip1.BackColor = Color.FromArgb(23, 23, 23);
                toolStripMenuItem1.BackColor = Color.FromArgb(23, 23, 23);
                toolStripMenuItem2.BackColor = Color.FromArgb(23, 23, 23);
                toolStripMenuItem3.BackColor = Color.FromArgb(23, 23, 23);
                toolStripMenuItem4.BackColor = Color.FromArgb(23, 23, 23);
                toolStripMenuItem5.BackColor = Color.FromArgb(23, 23, 23);
                toolStripMenuItem6.BackColor = Color.FromArgb(23, 23, 23);
                toolStripMenuItem7.BackColor = Color.FromArgb(23, 23, 23);
            }
            else if (Helper.getTheme().Equals("Light"))
            {
                colorList.color1 = Color.White;
                colorList.color2 = Color.Black;

                menuStrip1.BackColor = Color.FromArgb(210, 211, 219);
                toolStripMenuItem1.BackColor = Color.FromArgb(210, 211, 219);
                toolStripMenuItem2.BackColor = Color.FromArgb(210, 211, 219);
                toolStripMenuItem3.BackColor = Color.FromArgb(210, 211, 219);
                toolStripMenuItem4.BackColor = Color.FromArgb(210, 211, 219);
                toolStripMenuItem5.BackColor = Color.FromArgb(210, 211, 219);
                toolStripMenuItem6.BackColor = Color.FromArgb(210, 211, 219);
                toolStripMenuItem7.BackColor = Color.FromArgb(210, 211, 219);
            }
            else if (Helper.getTheme().Equals("Blue"))
            {
                colorList.color1 = Color.FromArgb(49, 51, 73);
                colorList.color2 = Color.FromArgb(0, 126, 246);

                menuStrip1.BackColor = Color.FromArgb(23, 30, 54);
                toolStripMenuItem1.BackColor = Color.FromArgb(23, 30, 54);
                toolStripMenuItem2.BackColor = Color.FromArgb(23, 30, 54);
                toolStripMenuItem3.BackColor = Color.FromArgb(23, 30, 54);
                toolStripMenuItem4.BackColor = Color.FromArgb(23, 30, 54);
                toolStripMenuItem5.BackColor = Color.FromArgb(23, 30, 54);
                toolStripMenuItem6.BackColor = Color.FromArgb(23, 30, 54);
                toolStripMenuItem7.BackColor = Color.FromArgb(23, 30, 54);
            }

            this.BackColor = colorList.color1;
            pnlReport.BackColor = colorList.color1;
            toolStripMenuItem1.ForeColor = colorList.color2;
            toolStripMenuItem2.ForeColor = colorList.color2;
            toolStripMenuItem3.ForeColor = colorList.color2;
            toolStripMenuItem4.ForeColor = colorList.color2;
            toolStripMenuItem5.ForeColor = colorList.color2;
            toolStripMenuItem6.ForeColor = colorList.color2;
            toolStripMenuItem7.ForeColor = colorList.color2;
        }

        private void frmReports_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new repDivorcePercentage());
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new repMenHigherEducation());
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new repPplGivenMonth());
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new repPplUnder18());
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new repPplMarriedUnder20());
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new repPplRefuse());
        }
    }
}
