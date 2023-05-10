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
    public partial class addPerson : Form
    {
        SqlDataAdapter dataAD;
        DataTable dt;

        public addPerson()
        {
            InitializeComponent();

            listJudet();
        }

        public void listJudet()
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(Helper.dbConn("dbSondaj")))
                {
                    dataAD = new SqlDataAdapter("select * from Judet", (SqlConnection)connection);
                    dt = new DataTable();
                    dataAD.Fill(dt);
                    usrJudet.DataSource = dt;
                    usrJudet.DisplayMember = "numeJudet";
                    usrJudet.ValueMember = "judetID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
