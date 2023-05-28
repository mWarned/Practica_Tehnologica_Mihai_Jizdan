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
    public partial class repMenHigherEducation : Form
    {
        SqlDataAdapter dataAD;
        DataTable dt;

        public repMenHigherEducation()
        {
            InitializeComponent();

            gridMenHighEducation.MultiSelect = false;
            gridMenHighEducation.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void refreshGrid()
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(Helper.dbConn("dbSondaj")))
                {
                    dataAD = new SqlDataAdapter("select persoanaID, Nume, Prenume, sex, studii, email, DataNasterii, Persoana.judetID, numeJudet, Persoana.municipiuID, numeMunicipiu, Persoana.orasID, numeOras, Casatorit, Divortat, Participant" +
                        " from Persoana inner join Judet on Persoana.judetID = Judet.judetID inner join Municipiu on Persoana.municipiuID = Municipiu.municipiuID" +
                        " inner join Oras on Persoana.orasID = Oras.orasID where sex = 'M' AND Casatorit = 0 AND (studii = 'Masterat' OR studii = 'Doctorat' OR studii = 'Diploma de absolvire')", (SqlConnection)connection);

                    dt = new System.Data.DataTable();
                    dataAD.Fill(dt);

                    gridMenHighEducation.DataSource = dt;

                    DataColumn Age = new DataColumn();

                    dt.Columns.Add("Age", typeof(int));

                    foreach (DataRow row in dt.Rows)
                    {
                        DateTime d0 = new DateTime(1, 1, 1);
                        DateTime now = DateTime.Now;
                        TimeSpan ts = now - Convert.ToDateTime(row["DataNasterii"]);

                        row["Age"] = ((d0 + ts).Year - 1);
                    }

                    gridMenHighEducation.Columns["persoanaID"].Visible = false;
                    gridMenHighEducation.Columns["judetID"].Visible = false;
                    gridMenHighEducation.Columns["municipiuID"].Visible = false;
                    gridMenHighEducation.Columns["orasID"].Visible = false;
                    gridMenHighEducation.Columns["Age"].Visible = false;

                    DataRow[] rowsToDelete = dt.Select($"Age < {int.Parse(usrAge1.Text)} OR Age > {int.Parse(usrAge2.Text)}");

                    foreach (DataRow row in rowsToDelete)
                    {
                        dt.Rows.Remove(row);
                    }

                    gridMenHighEducation.DataSource = dt;

                    // Adapt columns width to the largest string
                    foreach (DataGridViewColumn column in gridMenHighEducation.Columns)
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
            if (usrAge1.Text != "" && usrAge2.Text != "")
            {
                int age1, age2;

                int.TryParse(usrAge1.Text, out age1);
                int.TryParse(usrAge2.Text, out age2);

                if (age1 < age2)
                {
                    refreshGrid();
                }
                else
                {
                    MessageBox.Show("Enter a range!");
                }
            }
            else
            {
                MessageBox.Show("Please fill the all the fields!");
            }
        }

        private void usrAge1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void usrAge2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
