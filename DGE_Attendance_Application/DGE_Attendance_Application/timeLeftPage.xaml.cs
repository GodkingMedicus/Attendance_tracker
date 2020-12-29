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
using System.Data;
using System.Data.SqlClient;

namespace DGE_Attendance_Application
{
    /// <summary>
    /// Interaction logic for timeLeftPage.xaml
    /// </summary>
    public partial class timeLeftPage : Page
    {
        public timeLeftPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            try
            {


                dbClass.openConnection();
                dbClass.sql = "UPDATE SESSION SET DATETIMELEFT =" + "'" + dateTimeLeft_picker.SelectedDate.ToString() + "'" + "WHERE [USERID] =" + "'" + userID_tb.Text + "'" + ";";
                dbClass.cmd = new SqlCommand(dbClass.sql, dbClass.con);
                dbClass.cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }






            dbClass.closeConnection();
            MessageBox.Show("Entry updated for user " + userID_tb.Text);
        }
    }
}
