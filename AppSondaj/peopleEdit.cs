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
    public partial class peopleEdit : Form
    {
        private Button currentBtn;
        SqlDataAdapter dataAD;
        DataTable dt;

        public peopleEdit()
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
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (Button)senderBtn;
                currentBtn.ForeColor = color;

                // Panel on the right of the button
                pnlSideBtn.BackColor = color;
                pnlSideBtn.Location = new Point(224, currentBtn.Location.Y);
                pnlSideBtn.Visible = true;
                pnlSideBtn.BringToFront();
            }
        }

        // Method for disabling previous activated button
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.ForeColor = btnColors.lightBlue;

                // Panel on the right of the button
                pnlSideBtn.BackColor = btnColors.back;
                pnlSideBtn.Location = new Point(225, currentBtn.Location.Y);
                pnlSideBtn.Visible = true;
                pnlSideBtn.BringToFront();
            }
        }

        // Events for button clicks

        private void btnAddPpl_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, btnColors.lightBlue);
            addPerson person = new addPerson();
            person.Show();
        }

        private void btnDeletePpl_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, btnColors.lightBlue);
        }

        private void peopleEdit_Load(object sender, EventArgs e)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(Helper.dbConn("dbSondaj")))
                {
                    dataAD = new SqlDataAdapter("SELECT * FROM Persoana", (SqlConnection)connection);

                    dt = new System.Data.DataTable();
                    dataAD.Fill(dt);
                    gridPeople.DataSource = dt;

                    // Adapt columns width to the largest string
                    foreach (DataGridViewColumn column in gridPeople.Columns)
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
    }
}
