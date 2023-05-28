using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSondaj
{
    public partial class Main : Form
    {
        private Button currentBtn;
        private Form currentFormChild;
        public bool isAdmin;

        public Main()
        {
            InitializeComponent();
        }

        // A struct to store the colors
        private struct colorList
        {
            public static Color color1;
            public static Color color2;
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
                currentBtn.ForeColor = colorList.color2;

                // Panel on the left of the button
                pnlSideBtn.BackColor = colorList.color1;
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

        private void btnPeople_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorList.color2);
            OpenChildForm(new peopleEdit());
        }

        private void btnPoll_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorList.color2);
            OpenChildForm(new pollEdit());
        }

        private void btnThemesQuestions_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorList.color2);
            OpenChildForm(new grActions());
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorList.color2);
            OpenChildForm(new frmReports());
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorList.color2);
            frmSettigns settings = new frmSettigns();
            if(isAdmin == true)
            {
                settings.btnAdd.Enabled = true;
                settings.btnAccList.Enabled = true;
            }
            else
            {
                settings.btnAdd.Enabled = false;
                settings.btnAccList.Enabled = false;
            }
            OpenChildForm(settings);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorList.color2);
            frmLogin login = new frmLogin();
            login.Show();
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void usrImg_Click(object sender, EventArgs e)
        {
            pnlDesktop.Controls.Clear();
            Reset();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Changing the theme
        public void setTheme()
        {
            if (Helper.getTheme().Equals("Dark"))
            {
                colorList.color1 = Color.FromArgb(68, 68, 68);
                colorList.color2 = Color.White;

                pnlUp.BackColor = Color.FromArgb(23, 23, 23);
                pnlUser.BackColor = Color.FromArgb(23, 23, 23);
                pnlActions.BackColor = Color.FromArgb(23, 23, 23);
                pnlDesktop.BackColor = Color.FromArgb(68, 68, 68);

                usrImg.Image = AppSondaj.Properties.Resources.userD;
                btnPeople.Image = AppSondaj.Properties.Resources.peopleD;
                btnPoll.Image = AppSondaj.Properties.Resources.editD;
                btnThemesQuestions.Image = AppSondaj.Properties.Resources.questionsD;
                btnReports.Image = AppSondaj.Properties.Resources.reportD;
                btnSettings.Image = AppSondaj.Properties.Resources.settingD;
                btnLogin.Image = AppSondaj.Properties.Resources.logoutD;
            }
            else if (Helper.getTheme().Equals("Light"))
            {
                colorList.color1 = Color.White;
                colorList.color2 = Color.Black;

                pnlUp.BackColor = Color.FromArgb(210, 211, 219);
                pnlUser.BackColor = Color.FromArgb(210, 211, 219);
                pnlActions.BackColor = Color.FromArgb(210, 211, 219);
                pnlDesktop.BackColor = Color.White;

                usrImg.Image = AppSondaj.Properties.Resources.userL;
                btnPeople.Image = AppSondaj.Properties.Resources.peopleL;
                btnPoll.Image = AppSondaj.Properties.Resources.editL;
                btnThemesQuestions.Image = AppSondaj.Properties.Resources.questionsL;
                btnReports.Image = AppSondaj.Properties.Resources.reportL;
                btnSettings.Image = AppSondaj.Properties.Resources.settingL;
                btnLogin.Image = AppSondaj.Properties.Resources.logoutL;
            }
            else if (Helper.getTheme().Equals("Blue"))
            {
                colorList.color1 = Color.FromArgb(49, 51, 73);
                colorList.color2 = Color.FromArgb(0, 126, 246);

                pnlUp.BackColor = Color.FromArgb(23, 30, 54);
                pnlUser.BackColor = Color.FromArgb(23, 30, 54);
                pnlActions.BackColor = Color.FromArgb(23, 30, 54);
                pnlDesktop.BackColor = Color.FromArgb(49, 51, 73);

                usrImg.Image = AppSondaj.Properties.Resources.user;
                btnPeople.Image = AppSondaj.Properties.Resources.people;
                btnPoll.Image = AppSondaj.Properties.Resources.edit;
                btnThemesQuestions.Image = AppSondaj.Properties.Resources.questions;
                btnReports.Image = AppSondaj.Properties.Resources.report;
                btnSettings.Image = AppSondaj.Properties.Resources.setting;
                btnLogin.Image = AppSondaj.Properties.Resources.logout;
            }

            lblUser.ForeColor = colorList.color2;
            btnPeople.ForeColor = colorList.color2;
            btnPoll.ForeColor = colorList.color2;
            btnThemesQuestions.ForeColor = colorList.color2;
            btnReports.ForeColor = colorList.color2;
            btnSettings.ForeColor = colorList.color2;
            btnLogin.ForeColor = colorList.color2;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            setTheme();
        }
    }
}
