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
using System.Windows.Controls;
using System.Windows.Forms;

namespace AppSondaj
{
    public partial class repPplUnder18 : Form
    {
        SqlDataAdapter dataAD;
        System.Data.DataTable dt;

        public repPplUnder18()
        {
            InitializeComponent();

            gridPplUnder18.MultiSelect = false;
            gridPplUnder18.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void refreshGrid()
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(Helper.dbConn("dbSondaj")))
                {
                    char sex;

                    if (usrFemale.Checked == true)
                    {
                        sex = 'F';
                    }
                    else
                    {
                        sex = 'M';
                    }

                    dataAD = new SqlDataAdapter("select persoanaID, Nume, Prenume, sex, studii, email, DataNasterii, Persoana.judetID, numeJudet, Persoana.municipiuID, numeMunicipiu, Persoana.orasID, numeOras, Casatorit, Divortat, Participant" +
                        " from Persoana inner join Judet on Persoana.judetID = Judet.judetID inner join Municipiu on Persoana.municipiuID = Municipiu.municipiuID" +
                        $" inner join Oras on Persoana.orasID = Oras.orasID where sex = '{sex}' AND DATEDIFF(YEAR, CONVERT(date, DataNasterii, 104), GETDATE()) < 18", (SqlConnection)connection);

                    dt = new System.Data.DataTable();
                    dataAD.Fill(dt);

                    gridPplUnder18.DataSource = dt;

                    gridPplUnder18.Columns["persoanaID"].Visible = false;
                    gridPplUnder18.Columns["judetID"].Visible = false;
                    gridPplUnder18.Columns["municipiuID"].Visible = false;
                    gridPplUnder18.Columns["orasID"].Visible = false;

                    int nrPeople = gridPplUnder18.Rows.Count;

                    txtNotTakenPart.Text = (nrPeople - 1).ToString();

                    // Adapt columns width to the largest string
                    foreach (DataGridViewColumn column in gridPplUnder18.Columns)
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

        private void repPplUnder18_Load(object sender, EventArgs e)
        {
            refreshGrid();
        }

        private void usrMale_CheckedChanged(object sender, EventArgs e)
        {
            refreshGrid();
        }

        private void usrFemale_CheckedChanged(object sender, EventArgs e)
        {
            refreshGrid();
        }
    }
}
