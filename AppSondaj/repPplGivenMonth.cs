using Microsoft.Office.Interop.Excel;
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
    public partial class repPplGivenMonth : Form
    {
        SqlDataAdapter dataAD;
        System.Data.DataTable dt;


        public repPplGivenMonth()
        {
            InitializeComponent();

            gridPplGivenMonth.MultiSelect = false;
            gridPplGivenMonth.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Set theme
            setTheme();
        }

        // A struct to store the colors
        private struct colorList
        {
            public static Color color1;
            public static Color color2;
        }

        public void refreshGrid()
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(Helper.dbConn("dbSondaj")))
                {
                    dataAD = new SqlDataAdapter("select persoanaID, Nume, Prenume, sex, studii, email, DataNasterii, Persoana.judetID, numeJudet, Persoana.municipiuID, numeMunicipiu, Persoana.orasID, numeOras, Casatorit, Divortat, Participant" +
                        " from Persoana inner join Judet on Persoana.judetID = Judet.judetID inner join Municipiu on Persoana.municipiuID = Municipiu.municipiuID" +
                        " inner join Oras on Persoana.orasID = Oras.orasID" + $" WHERE MONTH(CONVERT(date, DataNasterii, 104)) = {usrMonth.SelectedIndex + 1}", (SqlConnection)connection);

                    dt = new System.Data.DataTable();
                    dataAD.Fill(dt);

                    gridPplGivenMonth.DataSource = dt;

                    gridPplGivenMonth.Columns["persoanaID"].Visible = false;
                    gridPplGivenMonth.Columns["judetID"].Visible = false;
                    gridPplGivenMonth.Columns["municipiuID"].Visible = false;
                    gridPplGivenMonth.Columns["orasID"].Visible = false;

                    gridPplGivenMonth.DataSource = dt;

                    // Adapt columns width to the largest string
                    foreach (DataGridViewColumn column in gridPplGivenMonth.Columns)
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

        private void usrMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Workbook WB;
            Worksheet WS;

            try
            {
                Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
                WB = Excel.Workbooks.Add(Type.Missing);
                WS = null;

                WS = WB.Sheets["Sheet1"];
                WS = WB.ActiveSheet;
                WS.Name = "Persoane_Luna_Aleasa";
                Excel.Visible = true;

                // Set headers
                for (int i = 1; i < gridPplGivenMonth.Columns.Count + 1; i++)
                {
                    WS.Cells[1, i] = gridPplGivenMonth.Columns[i - 1].HeaderText;
                }

                // Set cell values
                for (int i = 0; i < gridPplGivenMonth.Rows.Count; i++)
                {
                    for (int j = 0; j < gridPplGivenMonth.Columns.Count; j++)
                    {
                        WS.Cells[i + 2, j + 1] = gridPplGivenMonth.Rows[i].Cells[j].Value?.ToString();
                    }
                }

                WS.UsedRange.Columns.AutoFit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void usrMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshGrid();
        }

        // Changing the theme
        public void setTheme()
        {
            if (Helper.getTheme().Equals("Dark"))
            {
                colorList.color1 = Color.FromArgb(68, 68, 68);
                colorList.color2 = Color.White;

                btnExcel.Image = AppSondaj.Properties.Resources.saveD;
            }
            else if (Helper.getTheme().Equals("Light"))
            {
                colorList.color1 = Color.White;
                colorList.color2 = Color.Black;

                btnExcel.Image = AppSondaj.Properties.Resources.saveL;
            }
            else if (Helper.getTheme().Equals("Blue"))
            {
                colorList.color1 = Color.FromArgb(49, 51, 73);
                colorList.color2 = Color.FromArgb(0, 126, 246);

                btnExcel.Image = AppSondaj.Properties.Resources.save;
            }

            this.BackColor = colorList.color1;
            gridPplGivenMonth.BackgroundColor = colorList.color1;
            label1.ForeColor = colorList.color2;
            usrMonth.ForeColor = colorList.color2;
            usrMonth.BackColor = colorList.color1;
            btnExcel.ForeColor = colorList.color2;
        }
    }
}
