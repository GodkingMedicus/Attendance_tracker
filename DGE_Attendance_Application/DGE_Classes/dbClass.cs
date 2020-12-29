using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DGE_Classes
{
    public class dbClass
    {

        public static string sql;
        public static SqlConnection con = new SqlConnection();
        public static SqlCommand cmd = new SqlCommand("", con);
        public static SqlDataReader rd;
        public static DataTable dt;
        public static SqlDataAdapter da;

        public static void openConnection()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.ConnectionString = "Server=tcp:dge-application.database.windows.net,1433;Initial Catalog=dge-application;Persist Security Info=False;" +
                        "User ID=milan;Password=Dgeapp1*;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
                    con.Open();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to establish a connection");
            }
        }

        public static void closeConnection()
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            } 
            catch (Exception)
            {

            }
        }
    }
}
