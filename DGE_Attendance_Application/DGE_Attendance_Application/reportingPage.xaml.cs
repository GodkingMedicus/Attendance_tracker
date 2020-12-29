using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DGE_Classes;
using DGE_Attendance_Application;
using System.Security.Cryptography.X509Certificates;
using System.Data.SqlClient;
using System.Data;

namespace DGE_Attendance_Application
{
    /// <summary>
    /// Interaction logic for reportingPage.xaml
    /// </summary>
    public partial class reportingPage : Page
    {
        public reportingPage()
        {    
            InitializeComponent();
            searchBy.SelectedItem = Room;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string userID = userID_tb.Text;
            string roomID = userID_tb.Text;

            if(searchBy.SelectedItem == Room)
            {
                dbClass.openConnection();
                dbClass.sql = "SELECT * FROM SESSION WHERE [ROOMID] LIKE" + "'" + roomID + "'" + ";";
                dbClass.cmd.CommandType = CommandType.Text;
                dbClass.cmd.CommandText = dbClass.sql;

                dbClass.da = new SqlDataAdapter(dbClass.cmd);
                dbClass.dt = new DataTable();
                dbClass.da.Fill(dbClass.dt);

                reportingDataGrid.ItemsSource = dbClass.dt.DefaultView;
                dbClass.closeConnection();

            }
            else
            {
                dbClass.openConnection();
                dbClass.sql = "SELECT * FROM SESSION WHERE [USERID] LIKE" + "'" + userID + "'" + ";";
                dbClass.cmd.CommandType = CommandType.Text;
                dbClass.cmd.CommandText = dbClass.sql;

                dbClass.da = new SqlDataAdapter(dbClass.cmd);
                dbClass.dt = new DataTable();
                dbClass.da.Fill(dbClass.dt);

                reportingDataGrid.ItemsSource = dbClass.dt.DefaultView;
                dbClass.closeConnection();


            }



            

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
