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
    public partial class Main : Form
    {
        private Button currentBtn;
        private Form currentFormChild;

        public Main()
        {
            InitializeComponent();
        }

        // A struct to store the colors
        private struct btnColors
        {
            public static Color back = Color.FromArgb(23, 30, 54);
            public static Color lightBlue = Color.FromArgb(0, 126, 246);
        }

        // Method for activated button
        private void ActivateButton(object senderBtn, Color color) {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn= (Button)senderBtn;
                currentBtn.ForeColor = color;
                
                // Panel on the left of the button
                pnlSideBtn.BackColor = color;
                pnlSideBtn.Location = new Point(0, currentBtn.Location.Y);
                pnlSideBtn.Visible= true;
                pnlSideBtn.BringToFront();
            }
        }

        // Method for disabling previous activated button
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.ForeColor = btnColors.lightBlue;

                // Panel on the left of the button
                pnlSideBtn.BackColor = btnColors.back;
                pnlSideBtn.Location = new Point(0, currentBtn.Location.Y);
                pnlSideBtn.Visible = true;
                pnlSideBtn.BringToFront();
            }
        }

        //Method for disabling all buttons
        private void Reset()
        {
            DisableButton();
            pnlSideBtn.Visible = false;
        }

        // Method to open forms in the app
        private void OpenChildForm(Form childForm)
        {
            if(currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle= FormBorderStyle.None;
            childForm.Dock= DockStyle.Fill;
            pnlDesktop.Controls.Add(childForm);
            pnlDesktop.Tag= childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        // Events for button clicks

        private void btnPoll_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, btnColors.lightBlue);
            OpenChildForm(new pollEdit());
        }

        private void btnPeople_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, btnColors.lightBlue);
            OpenChildForm(new peopleEdit());
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, btnColors.lightBlue);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, btnColors.lightBlue);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, btnColors.lightBlue);
        }

        private void imgUser_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
