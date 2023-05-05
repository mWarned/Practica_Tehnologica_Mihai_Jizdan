using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AppSondaj
{
    internal class dbActions
    {
        SqlDataAdapter dataAD;
        DataTable dt;

        public DataTable listaJudete()
        {
            try
            {
                using (IDbConnection connection = new SqlConnection
                (Helper.dbConn("dbSondaj")))
                {
                    dataAD = new SqlDataAdapter("select * from Judet", (SqlConnection)connection);
                    dt = new DataTable();
                    dataAD.Fill(dt);

                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                return null;
            }
        }
    }
}
