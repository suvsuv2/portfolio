using Conference.Models;
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
using System.Windows.Shapes;

namespace Conference
{
    /// <summary>
    /// Логика взаимодействия для ShuriWindow.xaml
    /// </summary>
    public partial class ShuriWindow : Window
    {
        public ObservableCollection<object> Items { get; set; }
        public static MaincontextM context = new MaincontextM();
        public ObservableCollection<Events> events { get; set; }     
        public List<Events> EventsList { get; set; }

        public ObservableCollection<Participant> participants { get; set; }

        public List<Participant> ParticipantList {  get; set; }

        public ShuriWindow()
        {
            InitializeComponent();
            EventsList = context.EventsZ.ToList();
            events = new ObservableCollection<Events>();
            InputList.ItemsSource = EventsList;

            ParticipantList = context.ParticipantZ.ToList();
            participants = new ObservableCollection<Participant>();
            InputList2.ItemsSource = ParticipantList;
        }
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                ComboBoxItem selectedItem = e.AddedItems[0] as ComboBoxItem;

                if (selectedItem.Content.ToString() == "2022" || selectedItem.Content.ToString() == "2023")
                {
                    string selectedValue = selectedItem.Content.ToString();
                    List<Events> filteredEvents = new List<Events>();

                    foreach (Events ev in EventsList)
                    {
                        if (ev.EventDate.ToString().Contains(selectedValue))
                        {
                            filteredEvents.Add(ev);
                        }
                    }

                    InputList.ItemsSource = filteredEvents;
                }
            }
        }

        private void ComboBox_SelectionChanged2(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                ComboBoxItem selectedItem = e.AddedItems[0] as ComboBoxItem;

                if (selectedItem.Content.ToString() == "Биг дата" || selectedItem.Content.ToString() == "Аналитика" || selectedItem.Content.ToString() == "Дизайн" || selectedItem.Content.ToString() == "Информационная" || selectedItem.Content.ToString() == "ИТ")
                {
                    string selectedValue = selectedItem.Content.ToString();
                    List<Events> filteredEvents = new List<Events>();

                    foreach (Events ev in EventsList)
                    {
                        if (ev.EventDirection.ToString().Contains(selectedValue))
                        {
                            filteredEvents.Add(ev);
                        }
                    }

                    InputList.ItemsSource = filteredEvents;
                }
            }
        }

      
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            EventsList = context.EventsZ.ToList();
            events = new ObservableCollection<Events>();
            InputList.ItemsSource = EventsList;
        }


    }
}
