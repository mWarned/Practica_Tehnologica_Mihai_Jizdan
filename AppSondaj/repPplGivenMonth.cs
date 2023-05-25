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

            gridPplMonth.MultiSelect = false;
            gridPplMonth.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void refreshGrid()
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(Helper.dbConn("dbSondaj")))
                {
                    dataAD = new SqlDataAdapter("select persoanaID, Nume, Prenume, sex, studii, email, DataNasterii, Persoana.judetID, numeJudet, Persoana.municipiuID, numeMunicipiu, Persoana.orasID, numeOras, Casatorit, Divortat, Participant" +
                        " from Persoana inner join Judet on Persoana.judetID = Judet.judetID inner join Municipiu on Persoana.municipiuID = Municipiu.municipiuID" +
                        " inner join Oras on Persoana.orasID = Oras.orasID", (SqlConnection)connection);

                    dt = new System.Data.DataTable();
                    dataAD.Fill(dt);

                    gridPplMonth.DataSource = dt;

                    gridPplMonth.Columns["persoanaID"].Visible = false;
                    gridPplMonth.Columns["judetID"].Visible = false;
                    gridPplMonth.Columns["municipiuID"].Visible = false;
                    gridPplMonth.Columns["orasID"].Visible = false;

                    DataRow[] rowsToDelete = dt.Select($"MONTH(DataNasterii) <> {int.Parse(usrMonth.Text)}");

                    foreach (DataRow row in rowsToDelete)
                    {
                        dt.Rows.Remove(row);
                    }

                    gridPplMonth.DataSource = dt;

                    // Adapt columns width to the largest string
                    foreach (DataGridViewColumn column in gridPplMonth.Columns)
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            refreshGrid();
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
            Microsoft.Office.Interop.Excel.Application Excel;
            Workbook WB;
            Worksheet WS;

            try
            {
                Excel = new Microsoft.Office.Interop.Excel.Application();
                WB = Excel.Workbooks.Add(Type.Missing);
                WS = null;

                WS = WB.Sheets["Sheet1"];
                WS = WB.ActiveSheet;
                WS.Name = "Persoane nascute in luna specificata!";
                Excel.Visible = true;

                for (int i = 1; i < gridPplMonth.Columns.Count + 1; i++)
                {
                    WS.Cells[1, i] = gridPplMonth.Columns[i - 1].HeaderText;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
