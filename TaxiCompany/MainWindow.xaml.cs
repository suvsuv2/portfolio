using Microsoft.VisualBasic;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

using TaxiCompany.Models;

namespace TaxiCompany
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
     
        List<DriverGosling> driverlist = new List<DriverGosling>();
        public MainWindow()
        {
            InitializeComponent();
            MainContext mainContext = new MainContext();
           // mainContext.DriverGoslingZ.AddRange(new[]
           //{
           //      new DriverGosling{ Name="pudge", Surname="zxc" , PhoneNumber=798817937, Cars= "Toyota, Honda" }
           //  });
           // mainContext.SaveChanges();


         
            driverlist = mainContext.DriverGoslingZ.ToList();
            InputList.ItemsSource = driverlist;
           
        }
       
        private void EditButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            NewInput newInputWindow = new NewInput(driverlist);
            newInputWindow.ShowDialog();
        }

        private void TransportButton_Click(object sender, RoutedEventArgs e)
        {
            Transport a = new Transport();
            a.Show();
        }

        private void ZakaZZButton_Click(object sender, RoutedEventArgs e)
        {
            Order b = new Order();
            b.Show();
        }
    }
}
