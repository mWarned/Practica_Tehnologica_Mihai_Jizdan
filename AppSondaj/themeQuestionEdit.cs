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
                    DisableButton(side);
                    currentBtn = (Button)senderBtn;
                    currentBtn.ForeColor = color;

                    // Panel on the right of the button
                    pnlSideBtn.BackColor = color;
                    pnlSideBtn.Location = new Point(224, currentBtn.Location.Y);
                    pnlSideBtn.Visible = true;
                    pnlSideBtn.BringToFront();
                }
                else if (side.Equals("right"))
                {
                    DisableButton(side);
                    currentBtn = (Button)senderBtn;
                    currentBtn.ForeColor = color;

                    // Panel on the right of the button
                    pnlSideBtn.BackColor = color;
                    pnlSideBtn.Location = new Point(1100, currentBtn.Location.Y);
                    pnlSideBtn.Visible = true;
                    pnlSideBtn.BringToFront();
                }
            }
        }

        // Method for disabling previous activated button
        private void DisableButton(string side)
        {
            if (currentBtn != null)
            {
                if (side.Equals("left"))
                {
                    currentBtn.ForeColor = colorList.lightBlue;

                    // Panel on the right of the button
                    pnlSideBtn.BackColor = colorList.back;
                    pnlSideBtn.Location = new Point(250, currentBtn.Location.Y);
                    pnlSideBtn.Visible = true;
                    pnlSideBtn.BringToFront();
                }
                else if (side.Equals("right"))
                {
                    currentBtn.ForeColor = colorList.lightBlue;

                    // Panel on the right of the button
                    pnlSideBtn.BackColor = colorList.back;
                    pnlSideBtn.Location = new Point(1015, currentBtn.Location.Y);
                    pnlSideBtn.Visible = true;
                    pnlSideBtn.BringToFront();
                }
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

        private void themeEdit_Load(object sender, EventArgs e)
        {
            refreshThemes();
        }

        private void btnAddTheme_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorList.lightBlue, "left");
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
        }
    }
}
