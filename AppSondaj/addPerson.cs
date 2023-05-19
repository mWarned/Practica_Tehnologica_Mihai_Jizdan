using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSondaj
{
    public partial class newPerson : Form
    {
        SqlDataAdapter dataAD;
        DataTable dt;
        private SqlCommand cmd;
        public int personID;

        public newPerson()
        {
            InitializeComponent();

            listJudet();

            usrJudet.SelectedIndex= 0;
        }

        // Output judete
        public void listJudet()
        {
            try
            {
                // Output all data from Judet
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

        private void usrJudet_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val;
            try
            {
                // Get the selected value index
                int.TryParse(usrJudet.SelectedValue.ToString(), out val);

                // Output Municipiu based on Judet ID
                using (IDbConnection connection = new SqlConnection(Helper.dbConn("dbSondaj")))
                {
                    dataAD = new SqlDataAdapter("select * from Municipiu where judetID='" + val + "'", (SqlConnection)connection);
                    dt = new DataTable();
                    dataAD.Fill(dt);
                    usrMunicipiu.DataSource = dt;
                    usrMunicipiu.DisplayMember = "numeMunicipiu";
                    usrMunicipiu.ValueMember = "municipiuID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void usrMunicipiu_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val;
            try
            {
                // Get the selected value index
                int.TryParse(usrMunicipiu.SelectedValue.ToString(), out val);

                // Output Orase based on Municipiu ID
                using (IDbConnection connection = new SqlConnection(Helper.dbConn("dbSondaj")))
                {
                    dataAD = new SqlDataAdapter("select * from Oras where municipiuID='" + val + "'", (SqlConnection)connection);
                    dt = new DataTable();
                    dataAD.Fill(dt);
                    usrOras.DataSource = dt;
                    usrOras.DisplayMember = "numeOras";
                    usrOras.ValueMember = "orasID";
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
            // Get the inserted data
            int judetID = Convert.ToInt32(usrJudet.SelectedValue);
            int municipiuID = Convert.ToInt32(usrMunicipiu.SelectedValue);
            int orasID = Convert.ToInt32(usrOras.SelectedValue);

            bool married, divorced, participated;

            try
            {
                string sex = "";

                using (IDbConnection connection = new SqlConnection(Helper.dbConn("dbSondaj")))
                {
                    connection.Open();
                    
                    // Check data
                    if (usrM.Checked)
                    {
                        sex = "M";
                    }
                    else
                    {
                        sex = "F";
                    }

                    if (usrMarried.Checked)
                    {
                        married = true;
                    }
                    else
                    {
                        married = false;
                    }

                    if (usrDivorced.Checked)
                    {
                        divorced = true;
                    }
                    else
                    {
                        divorced = false;
                    }

                    if (usrParticipated.Checked)
                    {
                        participated = true;
                    }
                    else
                    {
                        participated = false;
                    }

                    // Check if all data was inserted
                    if (usrName.Text != "" && usrSurname.Text != "" && usrStudies.Text != ""
                        && usrEmail.Text != "" && usrBirthday.Text != "" && usrJudet.Text != ""
                        && usrMunicipiu.Text != "" && usrOras.Text != "")
                    {
                        // SQL insert
                        cmd = new SqlCommand("insert into Persoana values('" + usrName.Text + "', '" +
                            usrSurname.Text + "','" + sex + "', '" + usrStudies.Text + "','" + usrEmail.Text + "', '" +
                            usrBirthday.Text + "', '" + judetID + "','" + municipiuID + "', '" + orasID + "', '" +
                            married + "', '" + divorced + "', '" + participated + "')", (SqlConnection)connection);
                        cmd.ExecuteNonQuery();

                        this.Close();

                        MessageBox.Show("New person added!");
                    }
                    else
                    {
                        MessageBox.Show("Data incomplete, please fill all fields");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Get the new data
            int judetID = Convert.ToInt32(usrJudet.SelectedValue);
            int municipiuID = Convert.ToInt32(usrMunicipiu.SelectedValue);
            int orasID = Convert.ToInt32(usrOras.SelectedValue);

            bool married, divorced, participated;

            try
            {
                string sex = "";

                using (IDbConnection connection = new SqlConnection(Helper.dbConn("dbSondaj")))
                {
                    connection.Open();

                    // Check data
                    if (usrM.Checked)
                    {
                        sex = "M";
                    }
                    else
                    {
                        sex = "F";
                    }

                    if (usrMarried.Checked)
                    {
                        married = true;
                    }
                    else
                    {
                        married = false;
                    }

                    if (usrDivorced.Checked)
                    {
                        divorced = true;
                    }
                    else
                    {
                        divorced = false;
                    }

                    if (usrParticipated.Checked)
                    {
                        participated = true;
                    }
                    else
                    {
                        participated = false;
                    }

                    // Check if all the data was inserted
                    if (usrName.Text != "" && usrSurname.Text != "" && usrStudies.Text != ""
                        && usrEmail.Text != "" && usrBirthday.Text != "" && usrJudet.Text != ""
                        && usrMunicipiu.Text != "" && usrOras.Text != "")
                    {
                        // SQL update
                        cmd = new SqlCommand("update Persoana set Nume='" + usrName.Text + "', Prenume='" +
                            usrSurname.Text + "', sex='" + sex + "', studii='" + usrStudies.Text + "', email='" + usrEmail.Text + "', DataNasterii='" +
                            usrBirthday.Text + "', judetID='" + judetID + "', municipiuID='" + municipiuID + "', orasID='" + orasID + "', Casatorit='" +
                            married + "', Divortat='" + divorced + "', Participant='" + participated + "' where persoanaID = " + personID, (SqlConnection)connection);
                        cmd.ExecuteNonQuery();

                        // Trigger DataGridView update
                        if (System.Windows.Forms.Application.OpenForms["peopleEdit"] != null)
                        {
                            (System.Windows.Forms.Application.OpenForms["peopleEdit"] as peopleEdit).refreshPeople();
                        }

                        this.Close();

                        MessageBox.Show("Changes were saved!");
                    }
                    else
                    {
                        MessageBox.Show("Data incomplete, please fill all fields!");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
