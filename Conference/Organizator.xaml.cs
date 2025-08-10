using Conference.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Conference
{
    /// <summary>
    /// Логика взаимодействия для Organizator.xaml
    /// </summary>
    public partial class Organizator : Window
    {

        //private string organizerID;

        public Organizator(string enteredID)
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMinutes(1);
            timer.Tick += LabelGoodMorning_LayoutUpdated;
            timer.Start();
            //organizerID = enteredID;
            using (var context = new MaincontextM())
            {
                int id = int.Parse(enteredID);
                Organizer organizer = context.OrganizerZ.FirstOrDefault(v => v.ID == id);

                if (organizer != null)
                {

                    if (organizer.Gender == "мужской" || organizer.Gender =="Мужской")
                    {
                        label_FIO.Content = $"Ms {organizer.FIO}";
                    }
                    else if (organizer.Gender == "женский" || organizer.Gender == "Женский")
                    {
                        label_FIO.Content = $"Mrs {organizer.FIO}";
                    }
                    image.Source = new BitmapImage(new Uri(organizer.Photo));
                    listBox.ItemsSource = new List<string>
                {
                    //$"Gender: {organizer.Gender}",
                    $"Mail: {organizer.Mail}",
                    $"Birthday Date: {organizer.BirthdayData}",
                    $"Country: {organizer.Country}",
                    $"Telephone Number: {organizer.TelephoneNumber}",
                    //$"Profession: {organizer.Profession}",
                    //$"Event: {organizer.Event}"
                };
                }
            }
        }

        //private void Window_Loaded(object sender, RoutedEventArgs e)
        //{
        //    using (var context = new literalydontcare())
        //    {
        //        Organizer organizer = context.OrganizerZ.FirstOrDefault(v => v.ID.Equals(organizerID));

        //        if (organizer != null)
        //        {
        //            // Заполнение элементов данными из объекта Organizer
        //            label_FIO.Content = organizer.FIO;
        //            image.Source = new BitmapImage(new Uri(organizer.Photo));
        //            listBox.ItemsSource = new List<string>
        //        {
        //            $"Gender: {organizer.Gender}",
        //            $"Mail: {organizer.Mail}",
        //            $"Birthday Date: {organizer.BirthdayData}",
        //            $"Country: {organizer.Country}",
        //            $"Telephone Number: {organizer.TelephoneNumber}",
        //            $"Profession: {organizer.Profession}",
        //            $"Event: {organizer.Event}"
        //        };
        //        }
        //    }
        //}

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ShuriRegistration a = new ShuriRegistration();
            a.ShowDialog();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            EventRegistration a = new EventRegistration();
            a.ShowDialog();
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            ParticipantRegistration a = new ParticipantRegistration();
            a.ShowDialog();
        }
        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            ModerRegistration a = new ModerRegistration();
            a.ShowDialog();
        }

        private void LabelGoodMorning_LayoutUpdated(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            int hour = now.Hour;

            if (hour >= 5 && hour < 12)
            {
                LabelGoodMorning.Content = "Доброе утро!";
            }
            else if (hour >= 12 && hour < 17)
            {
                LabelGoodMorning.Content = "Добрый день!";
            }
            else
            {
                LabelGoodMorning.Content = "Добрый вечер!";
            }
        }
    }
}
