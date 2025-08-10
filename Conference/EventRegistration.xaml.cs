using Conference.Models;
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
using System.Windows.Shapes;

namespace Conference
{
    /// <summary>
    /// Логика взаимодействия для EventRegistration.xaml
    /// </summary>
    public partial class EventRegistration : Window
    {
        public EventRegistration()
        {
            InitializeComponent();
            String allowchar = "";

            allowchar += "1,2,3,4,5,6,7,8,9,0";

            char[] a = { ',' };

            String[] ar = allowchar.Split(a);

            String pwd = "";

            string temp = "";

            Random r = new Random();



            for (int i = 0; i < 4; i++)

            {

                temp = ar[(r.Next(0, ar.Length))];



                pwd += temp;

            }



            TextBox1.Text = pwd;
        }
        private void AddEventButton_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new MaincontextM()) 
            {
                try
                {
                    var newEvent = new Events();
               
                    newEvent.ID = int.Parse(TextBox1.Text);
                    newEvent.EventNumber = int.Parse(NumberTextBox.Text);
                    newEvent.EventName = NameTextBox.Text;

                    if (Date.SelectedDate.HasValue)
                        newEvent.EventDate = Date.SelectedDate.Value;

                    newEvent.EventDays = int.Parse(DayTextBox.Text);
                    newEvent.EventCity = int.Parse(CityTextBox.Text);
                    newEvent.EventDirection = DirectionTextBox.Text;

              
                    context.EventsZ.Add(newEvent);
                    context.SaveChanges();

                    MessageBox.Show("Данные успешно добавлены", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка добавления данных: " + ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
    }
