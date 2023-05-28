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
    public partial class repPplRefuse : Form
    {
        SqlDataAdapter dataAD;
        DataTable dt;

        public repPplRefuse()
        {
            InitializeComponent();

            gridPplNotTakenPart.MultiSelect = false;
            gridPplNotTakenPart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void refreshGrid()
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(Helper.dbConn("dbSondaj")))
                {
                    dataAD = new SqlDataAdapter("select persoanaID, Nume, Prenume, sex, studii, email, DataNasterii, Persoana.judetID, numeJudet, Persoana.municipiuID, numeMunicipiu, Persoana.orasID, numeOras, Casatorit, Divortat, Participant" +
                        " from Persoana inner join Judet on Persoana.judetID = Judet.judetID inner join Municipiu on Persoana.municipiuID = Municipiu.municipiuID" +
                        " inner join Oras on Persoana.orasID = Oras.orasID where Persoana.Participant = 0", (SqlConnection)connection);

                    dt = new System.Data.DataTable();
                    dataAD.Fill(dt);

                    gridPplNotTakenPart.DataSource = dt;

                    gridPplNotTakenPart.Columns["persoanaID"].Visible = false;
                    gridPplNotTakenPart.Columns["judetID"].Visible = false;
                    gridPplNotTakenPart.Columns["municipiuID"].Visible = false;
                    gridPplNotTakenPart.Columns["orasID"].Visible = false;

                    int nrPeople = gridPplNotTakenPart.Rows.Count;

                    txtNotTakenPart.Text = (nrPeople - 1).ToString();

                    // Adapt columns width to the largest string
                    foreach (DataGridViewColumn column in gridPplNotTakenPart.Columns)
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

        private void repPplRefuse_Load(object sender, EventArgs e)
        {
            refreshGrid();
        }
    }
}
