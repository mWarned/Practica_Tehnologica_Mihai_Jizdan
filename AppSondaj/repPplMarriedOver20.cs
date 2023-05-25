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
    public partial class repPplMarriedOver20 : Form
    {
        SqlDataAdapter dataAD;
        System.Data.DataTable dt;

        public repPplMarriedOver20()
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
                    dataAD = new SqlDataAdapter("select persoanaID, Nume, Prenume, sex, studii, email, DataNasterii, Persoana.judetID, numeJudet, Persoana.municipiuID, numeMunicipiu, Persoana.orasID, numeOras, Casatorit, Divortat, Participant" +
                        " from Persoana inner join Judet on Persoana.judetID = Judet.judetID inner join Municipiu on Persoana.municipiuID = Municipiu.municipiuID" +
                        " inner join Oras on Persoana.orasID = Oras.orasID where Casatorit = 1 and DATEDIFF(YEAR, DataNasterii, GETDATE()) > 20", (SqlConnection)connection);

                    dt = new System.Data.DataTable();
                    dataAD.Fill(dt);

                    gridPplUnder18.DataSource = dt;

                    gridPplUnder18.Columns["persoanaID"].Visible = false;
                    gridPplUnder18.Columns["judetID"].Visible = false;
                    gridPplUnder18.Columns["municipiuID"].Visible = false;
                    gridPplUnder18.Columns["orasID"].Visible = false;

                    SqlCommand nrPers = new SqlCommand("select count(*) from Persoana", (SqlConnection)connection);

                    connection.Open();
                    int pers = (int)nrPers.ExecuteScalar();
                    connection.Close();

                    txtNotTakenPart.Text = pers.ToString();

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

        private void repPplMarriedOver20_Load(object sender, EventArgs e)
        {
            refreshGrid();
        }
    }
}
