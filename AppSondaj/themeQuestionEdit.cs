using System;
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
    public partial class themeQuestionEdit : Form
    {
        private Button currentBtn;
        SqlDataAdapter dataAD;
        DataTable dt;

        public themeQuestionEdit()
        {
            InitializeComponent();

            gridThemes.MultiSelect = false;
            gridQuestions.MultiSelect = false;
        }

        // A struct to store the colors
        private struct colorList
        {
            public static Color back = Color.FromArgb(23, 30, 54);
            public static Color lightBlue = Color.FromArgb(0, 126, 246);
        }

        // Method for activated button
        private void ActivateButton(object senderBtn, Color color, string side)
        {
            if (senderBtn != null)
            {
                if (side.Equals("left"))
                {
                    DisableButton();
                    currentBtn = (Button)senderBtn;
                    currentBtn.ForeColor = color;

                    // Panel on the right of the button
                    pnlSideBtn1.BackColor = color;
                    pnlSideBtn1.Location = new Point(225, currentBtn.Location.Y);
                    pnlSideBtn1.Visible = true;
                    pnlSideBtn1.BringToFront();
                }
                else if (side.Equals("right"))
                {
                    DisableButton();
                    currentBtn = (Button)senderBtn;
                    currentBtn.ForeColor = color;

                    // Panel on the right of the button
                    pnlSideBtn2.BackColor = color;
                    pnlSideBtn2.Location = new Point(225, currentBtn.Location.Y);
                    pnlSideBtn2.Visible = true;
                    pnlSideBtn2.BringToFront();
                }
            }
        }

        // Method for disabling previous activated button
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.ForeColor = colorList.lightBlue;

                // Panel on the right of the button
                pnlSideBtn1.BackColor = colorList.back;
                pnlSideBtn1.Location = new Point(250, currentBtn.Location.Y);
                pnlSideBtn1.Visible = false;
                pnlSideBtn1.BringToFront();
                
                currentBtn.ForeColor = colorList.lightBlue;

                // Panel on the right of the button
                pnlSideBtn2.BackColor = colorList.back;
                pnlSideBtn2.Location = new Point(250, currentBtn.Location.Y);
                pnlSideBtn2.Visible = false;
                pnlSideBtn2.BringToFront();
            }
        }

        // Refresh the datagrid output
        public void refreshThemes()
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(Helper.dbConn("dbSondaj")))
                {
                    dataAD = new SqlDataAdapter("select * from Tematica", (SqlConnection)connection);

                    dt = new System.Data.DataTable();
                    dataAD.Fill(dt);
                    gridThemes.DataSource = dt;
                    gridThemes.Columns["tematicaID"].Visible = false;

                    // Adapt columns width to the largest string
                    foreach (DataGridViewColumn column in gridThemes.Columns)
                    {
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void refreshQuestions()
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(Helper.dbConn("dbSondaj")))
                {
                    dataAD = new SqlDataAdapter("select intrebareID, Tematica, Intrebare from Intrebare inner join Tematica on Intrebare.tematicaID = Tematica.tematicaID", (SqlConnection)connection);

                    dt = new System.Data.DataTable();
                    dataAD.Fill(dt);
                    gridQuestions.DataSource = dt;
                    gridQuestions.Columns["intrebareID"].Visible = false;

                    // Adapt columns width to the largest string
                    foreach (DataGridViewColumn column in gridQuestions.Columns)
                    {
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddTheme_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorList.lightBlue, "left");
            addTheme themes = new addTheme();
            themes.Show();
        }

        private void btnUpdateTheme_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorList.lightBlue, "left");
        }

        private void btnDeleteTheme_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorList.lightBlue, "left");
        }

        private void btnRefreshTheme_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorList.lightBlue, "left");
            refreshThemes();
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorList.lightBlue, "right");
        }

        private void btnUpdateQuestion_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorList.lightBlue, "right");
        }

        private void btnDeleteQuestion_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorList.lightBlue, "right");
        }

        private void btnRefreshQuestion_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorList.lightBlue, "right");
            refreshQuestions();
        }

        private void themeEdit_Load(object sender, EventArgs e)
        {
            refreshThemes();
            refreshQuestions();
        }
    }
}
