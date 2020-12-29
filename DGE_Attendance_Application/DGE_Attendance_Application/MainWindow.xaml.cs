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
using System.Configuration;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;

namespace DGE_Attendance_Application
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = new timeEnteredPage();
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = new reportingPage();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = new timeLeftPage();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }
    }
}
