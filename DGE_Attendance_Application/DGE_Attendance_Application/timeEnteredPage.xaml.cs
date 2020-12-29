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
using Microsoft.Win32;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DGE_Attendance_Application
{
    /// <summary>
    /// Interaction logic for timeEnteredPage.xaml
    /// </summary>
    public partial class timeEnteredPage : Page
    {
        public timeEnteredPage()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            

            if (ClassRadio.IsChecked == true)
            {
                dbClass.openConnection();
                dbClass.sql = "INSERT INTO SESSION (DATETIMEENTERED, DATETIMELEFT, ROOMID, SESSIONTYPE, USERID) VALUES ('" +
                    timeEnteredPicker.SelectedDate.ToString() + "'," + "''" + ",'" + roomIDtb.Text + "'," + "'Class'" + "," + "'" + userIDtbTimeEntered.Text + "');";

                dbClass.cmd = new SqlCommand(dbClass.sql, dbClass.con);
                dbClass.cmd.ExecuteNonQuery();







                dbClass.closeConnection();
                MessageBox.Show("Entry recorded for user " + userIDtbTimeEntered.Text);
            }
            else if(OfficeRadio.IsChecked == true)
            {
                dbClass.openConnection();
                dbClass.sql = "INSERT INTO SESSION (DATETIMEENTERED, DATETIMELEFT, ROOMID, SESSIONTYPE, USERID) VALUES ('" +
                    timeEnteredPicker.SelectedDate.ToString() + "'," + "''" + ",'" + roomIDtb.Text + "'," + "'Office'" + "," + "'" + userIDtbTimeEntered.Text + "');";

                dbClass.cmd = new SqlCommand(dbClass.sql, dbClass.con);
                dbClass.cmd.ExecuteNonQuery();




                dbClass.closeConnection();
                MessageBox.Show("Entry recorded for user " + userIDtbTimeEntered.Text);
            }
            else
            {
                MessageBox.Show("Please select a session type");
            }


            


        }

        /*private void Button_Click(object sender, RoutedEventArgs e)
        {
            Session session = new Session();

            //session.roomID =






        }*/

    }
}
