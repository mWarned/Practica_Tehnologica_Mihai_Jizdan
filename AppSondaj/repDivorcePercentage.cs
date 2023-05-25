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
    public partial class repDivorcePercentage : Form
    {
        SqlDataAdapter dataAD;
        DataTable dt;

        public repDivorcePercentage()
        {
            InitializeComponent();

            gridDivorce.MultiSelect = false;
            gridDivorce.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void refreshGrid()
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(Helper.dbConn("dbSondaj")))
                {
                    dataAD = new SqlDataAdapter("select persoanaID, Nume, Prenume, sex, studii, email, DataNasterii, Persoana.judetID, numeJudet, Persoana.municipiuID, numeMunicipiu, Persoana.orasID, numeOras, Casatorit, Divortat, Participant" +
                        " from Persoana inner join Judet on Persoana.judetID = Judet.judetID inner join Municipiu on Persoana.municipiuID = Municipiu.municipiuID" +
                        " inner join Oras on Persoana.orasID = Oras.orasID where Persoana.Divortat = 1", (SqlConnection)connection);

                    dt = new System.Data.DataTable();
                    dataAD.Fill(dt);

                    gridDivorce.DataSource = dt;

                    gridDivorce.Columns["persoanaID"].Visible = false;
                    gridDivorce.Columns["judetID"].Visible = false;
                    gridDivorce.Columns["municipiuID"].Visible = false;
                    gridDivorce.Columns["orasID"].Visible = false;

                    SqlCommand divorced = new SqlCommand("select count(*) from Persoana where Divortat = 1", (SqlConnection)connection);
                    SqlCommand total = new SqlCommand("select count(*) from Persoana", (SqlConnection)connection);

                    connection.Open();
                    int div = (int)divorced.ExecuteScalar();
                    int tot = (int)total.ExecuteScalar();
                    float percentage = (float) div / (float) tot;
                    connection.Close();

                    divorcePercentage.Text = (percentage*100).ToString() + "%";

                    // Adapt columns width to the largest string
                    foreach (DataGridViewColumn column in gridDivorce.Columns)
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

        private void repDivorcePercentage_Load(object sender, EventArgs e)
        {
            refreshGrid();
        }
    }
}
