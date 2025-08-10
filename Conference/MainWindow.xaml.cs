using Conference.Models;

using Microsoft.EntityFrameworkCore;

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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

using static System.Net.Mime.MediaTypeNames;

namespace Conference
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        public ObservableCollection<object> Items { get; set; }
        public static MaincontextM context = new MaincontextM();
        public ObservableCollection<Events> events { get; set; }
        public List<Events> EventsList { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            EventsList = context.EventsZ.ToList();
            events = new ObservableCollection<Events>();          
            InputList.ItemsSource = EventsList;
          

        }

        private void ApplyFilters()
        {
            List<Events> filteredEvents = EventsList;

            ComboBoxItem selectedYearItem = Combobox1.SelectedItem as ComboBoxItem;
            ComboBoxItem selectedDirectionItem = Combobox2.SelectedItem as ComboBoxItem;

            if (selectedYearItem != null && selectedYearItem.Content.ToString() != "All")
            {
                string selectedYear = selectedYearItem.Content.ToString();
                filteredEvents = filteredEvents.Where(ev => ev.EventDate.ToString().Contains(selectedYear)).ToList();
            }

            if (selectedDirectionItem != null && selectedDirectionItem.Content.ToString() != "All")
            {
                string selectedDirection = selectedDirectionItem.Content.ToString();
                filteredEvents = filteredEvents.Where(ev => ev.EventDirection.ToString().Contains(selectedDirection)).ToList();
            }

            InputList.ItemsSource = filteredEvents;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ApplyFilters();
        }

        private void ComboBox_SelectionChanged2(object sender, SelectionChangedEventArgs e)
        {
            ApplyFilters();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Captcha a = new Captcha();
             a.ShowDialog();
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            EventsList = context.EventsZ.ToList();
            events = new ObservableCollection<Events>();
            InputList.ItemsSource = EventsList;
            Combobox1.Text = "";
            Combobox2.Text = "";

        }


    }
}

// дизайн из чата гопота <ListBox x:Name="InputList" Height="NaN" Margin="9,38,195,72" Width="NaN" BorderBrush="#FFA4D7FF" ItemsSource="{Binding Items}">
//    < ListBox.ItemTemplate >
//        < DataTemplate >
//            < Border BorderThickness = "1" BorderBrush = "Black" Margin = "5" >
//                < Grid >
//                    < Grid.RowDefinitions >
//                        < RowDefinition Height = "Auto" />
//                        < RowDefinition Height = "Auto" />
//                        < RowDefinition Height = "Auto" />
//                    </ Grid.RowDefinitions >
//                    < Grid.ColumnDefinitions >
//                        < ColumnDefinition Width = "Auto" />
//                        < ColumnDefinition Width = "Auto" />
//                    </ Grid.ColumnDefinitions >

            //                    < TextBlock Text = "{Binding Path=EventName}" Grid.Row = "0" Grid.Column = "0" />
            //                    < TextBlock Text = "{Binding Path=EventDate}" Grid.Row = "1" Grid.Column = "0" />
            //                    < TextBlock Text = "{Binding Path=Profession}" Grid.Row = "2" Grid.Column = "0" />

            //                    < Image Source = "{Binding EventPicture}" Width = "50" Height = "50" Grid.Row = "0" Grid.Column = "1" Grid.RowSpan = "3" />
            //                </ Grid >
            //            </ Border >
            //        </ DataTemplate >
            //    </ ListBox.ItemTemplate >
            //</ ListBox >


            // МОЙ ДИЗУИН  <ListBox x:Name="InputList" Height="NaN" Margin="9,38,195,72" Width="NaN" BorderBrush="#FFA4D7FF" ItemsSource="{Binding Items}">
        //    < ListBox.ItemTemplate >
        //        < DataTemplate >
        //            < Grid >
        //                < Grid.RowDefinitions >
        //                    < RowDefinition Height = "Auto" />
        //                    < RowDefinition Height = "Auto" />
        //                    < RowDefinition Height = "Auto" />
        //                </ Grid.RowDefinitions >
        //                < Border BorderThickness = "1" BorderBrush = "Black" Margin = "5" >
        //                    < StackPanel >
        //                        < Border >
        //                            < TextBlock Text = "{Binding Path=EventName}" />
        //                        </ Border >
        //                        < Border >
        //                            < Image Source = "{Binding EventPicture}" Width = "50" Height = "50" />
        //                        </ Border >
        //                        < Border >
        //                            < TextBlock Text = "{Binding Path=EventDate}" />
        //                        </ Border >
        //                        < Border >
        //                            < TextBlock Text = "{Binding Path=Profession}" />
        //                        </ Border >
        //                    </ StackPanel >
        //                </ Border >
        //            </ Grid >
        //        </ DataTemplate >
        //    </ ListBox.ItemTemplate >
        //</ ListBox >


//public static MainContextzz context = new MainContextzz();
//public List<Events> EventsList { get; set; }
//public List<Moderator> ModeratorList { get; set; }
//public List<object> CombinedList { get; set; }
//public ObservableCollection<object> Items { get; set; }

//public MainWindow()
//{
//    InitializeComponent();

//    EventsList = context.EventsZ.ToList();
//    ModeratorList = context.ModeratorZ.ToList();

//    CombinedList = new List<object>();
//    CombinedList.AddRange(EventsList);
//    CombinedList.AddRange(ModeratorList);

//    Items = new ObservableCollection<object>(CombinedList);
//    InputList.ItemsSource = Items;
//}
