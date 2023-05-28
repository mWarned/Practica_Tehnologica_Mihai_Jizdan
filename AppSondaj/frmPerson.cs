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
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace AppSondaj
{
    public partial class frmPerson : Form
    {
        SqlDataAdapter dataAD;
        DataTable dt;
        private SqlCommand cmd;
        public int personID;

        public frmPerson()
        {
            InitializeComponent();

            listJudet();
            usrJudet_SelectedIndexChanged(usrJudet, EventArgs.Empty);

            // Set theme
            setTheme();
        }

        // A struct to store the colors
        private struct colorList
        {
            public static Color color1;
            public static Color color2;
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

                        if (System.Windows.Forms.Application.OpenForms["peopleEdit"] != null)
                        {
                            (System.Windows.Forms.Application.OpenForms["peopleEdit"] as peopleEdit).refreshPeople();
                        }

                        this.Close();

                        MessageBox.Show("New person added!");
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newPerson_Load(object sender, EventArgs e)
        {
            
        }

        // Changing the theme
        public void setTheme()
        {
            if (Helper.getTheme().Equals("Dark"))
            {
                colorList.color1 = Color.FromArgb(68, 68, 68);
                colorList.color2 = Color.White;

                pnlUp.BackColor = Color.FromArgb(23, 23, 23);
                btnExit.IconColor = Color.White;
                btnSave.Image = AppSondaj.Properties.Resources.saveD;
                btnUpdate.Image = AppSondaj.Properties.Resources.updateD;
            }
            else if (Helper.getTheme().Equals("Light"))
            {
                colorList.color1 = Color.White;
                colorList.color2 = Color.Black;

                pnlUp.BackColor = Color.FromArgb(210, 211, 219);
                btnExit.IconColor = Color.Black;
                btnSave.Image = AppSondaj.Properties.Resources.saveL;
                btnUpdate.Image = AppSondaj.Properties.Resources.updateL;
            }
            else if (Helper.getTheme().Equals("Blue"))
            {
                colorList.color1 = Color.FromArgb(49, 51, 73);
                colorList.color2 = Color.White;

                pnlUp.BackColor = Color.FromArgb(23, 30, 54);
                btnExit.IconColor = Color.White;
                btnSave.Image = AppSondaj.Properties.Resources.save;
                btnUpdate.Image = AppSondaj.Properties.Resources.update;
            }

            btnSave.BackColor = colorList.color1;
            btnUpdate.BackColor = colorList.color1;

            btnSave.ForeColor = colorList.color2;
            btnUpdate.ForeColor = colorList.color2;

            this.BackColor = colorList.color1;
            label1.ForeColor = colorList.color2;
            label2.ForeColor = colorList.color2;
            label3.ForeColor = colorList.color2;
            label4.ForeColor = colorList.color2;
            label5.ForeColor = colorList.color2;
            label6.ForeColor = colorList.color2;
            label7.ForeColor = colorList.color2;
            label8.ForeColor = colorList.color2;
            label9.ForeColor = colorList.color2;
            usrName.BackColor = colorList.color1;
            usrName.ForeColor = colorList.color2;
            usrSurname.BackColor = colorList.color1;
            usrSurname.ForeColor = colorList.color2;
            usrStudies.BackColor = colorList.color1;
            usrStudies.ForeColor = colorList.color2;
            usrEmail.BackColor = colorList.color1;
            usrEmail.ForeColor = colorList.color2;
            usrJudet.BackColor = colorList.color1;
            usrJudet.ForeColor = colorList.color2;
            usrMunicipiu.BackColor = colorList.color1;
            usrMunicipiu.ForeColor = colorList.color2;
            usrOras.BackColor = colorList.color1;
            usrOras.ForeColor = colorList.color2;

            usrM.ForeColor = colorList.color2;
            usrF.ForeColor = colorList.color2;
            usrMarried.ForeColor = colorList.color2;
            usrDivorced.ForeColor = colorList.color2;
            usrParticipated.ForeColor = colorList.color2;
        }
    }
}
