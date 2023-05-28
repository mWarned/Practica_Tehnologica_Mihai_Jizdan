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
                        " inner join Oras on Persoana.orasID = Oras.orasID where Persoana.Divortat = 1", (SqlConnection)connection);

                    dt = new System.Data.DataTable();
                    dataAD.Fill(dt);

                    gridDivorce.DataSource = dt;

                    gridDivorce.Columns["persoanaID"].Visible = false;
                    gridDivorce.Columns["judetID"].Visible = false;
                    gridDivorce.Columns["municipiuID"].Visible = false;
                    gridDivorce.Columns["orasID"].Visible = false;

                    SqlCommand divorced = new SqlCommand("select count(*) from Persoana where Divortat = 1", (SqlConnection)connection);
                    SqlCommand total = new SqlCommand("select count(*) from Persoana where Casatorit = 1", (SqlConnection)connection);

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

        // Changing the theme
        public void setTheme()
        {
            if (Helper.getTheme().Equals("Dark"))
            {
                colorList.color1 = Color.FromArgb(68, 68, 68);
                colorList.color2 = Color.White;
            }
            else if (Helper.getTheme().Equals("Light"))
            {
                colorList.color1 = Color.White;
                colorList.color2 = Color.Black;
            }
            else if (Helper.getTheme().Equals("Blue"))
            {
                colorList.color1 = Color.FromArgb(49, 51, 73);
                colorList.color2 = Color.FromArgb(0, 126, 246);
            }

            this.BackColor = colorList.color1;
            gridDivorce.BackgroundColor = colorList.color1;
            label1.ForeColor = colorList.color2;
            divorcePercentage.ForeColor = colorList.color2;
            divorcePercentage.BackColor = colorList.color1;
        }

        private void repDivorcePercentage_Load(object sender, EventArgs e)
        {
            refreshGrid();
        }
    }
}
