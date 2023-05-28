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
    public partial class repPplMarriedUnder20 : Form
    {
        SqlDataAdapter dataAD;
        System.Data.DataTable dt;

        public repPplMarriedUnder20()
        {
            InitializeComponent();

            gridPplMarriedUnder20.MultiSelect = false;
            gridPplMarriedUnder20.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

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
                        " inner join Oras on Persoana.orasID = Oras.orasID where Casatorit = 1 AND DATEDIFF(YEAR, CONVERT(date, DataNasterii, 104), GETDATE()) < 20", (SqlConnection)connection);

                    dt = new System.Data.DataTable();
                    dataAD.Fill(dt);

                    gridPplMarriedUnder20.DataSource = dt;

                    gridPplMarriedUnder20.Columns["persoanaID"].Visible = false;
                    gridPplMarriedUnder20.Columns["judetID"].Visible = false;
                    gridPplMarriedUnder20.Columns["municipiuID"].Visible = false;
                    gridPplMarriedUnder20.Columns["orasID"].Visible = false;

                    int nrPeople = gridPplMarriedUnder20.Rows.Count;

                    txtMarriedUnder20.Text = (nrPeople - 1).ToString();

                    // Adapt columns width to the largest string
                    foreach (DataGridViewColumn column in gridPplMarriedUnder20.Columns)
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
            gridPplMarriedUnder20.BackgroundColor = colorList.color1;
            label1.ForeColor = colorList.color2;
            txtMarriedUnder20.ForeColor = colorList.color2;
            txtMarriedUnder20.BackColor = colorList.color1;
        }
    }
}
