using Conference.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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

namespace Conference
{
    /// <summary>
    /// Логика взаимодействия для ParticipantWindow.xaml
    /// </summary>
    public partial class ParticipantWindow : Window
    {
        public ParticipantWindow(string enteredID)
        {
            InitializeComponent();
            using (var context = new MaincontextM())
            {
                int id = int.Parse(enteredID);
                Participant participant = context.ParticipantZ.FirstOrDefault(v => v.ID == id);
                if (participant != null)
                {
                    // Заполнение элементов данными из объекта Organizer

                    image.Source = new BitmapImage(new Uri(participant.Photo));
                    listBox.ItemsSource = new List<string>
                {
                    $"ID: {participant.ID}",
                    $"ФИО: {participant.FIO}",
                    $"Gender: {participant.Gender}",
                    $"Mail: {participant.Mail}",
                    $"Дата рождения: {participant.BirthdayData}",
                    $"Страна: {participant.Country}",
                    $"Номер телефона: {participant.TelephoneNumber}",
                    $"Ваш пароль: {participant.Password}",

                };
                }

            }
        }
       
        private void ChangeButton_Click(object sender, RoutedEventArgs e)
        {
            int enteredID = int.Parse(IDcheck.Text);
            using (var context = new MaincontextM())
            {
                try
                {
                    Participant participant = context.ParticipantZ.FirstOrDefault(z => z.ID == enteredID);


                    if (participant != null)
                    {
                        participant.FIO = FIOTextBox.Text;
                        participant.Mail = MailTextBox.Text;
                        participant.BirthdayData = Date.SelectedDate;
                        participant.Country = CountryTextBox.Text;
                        participant.TelephoneNumber = TelephoneTextBox.Text;
                        participant.Password = PasswordTextBox.Text;
                        participant.Gender = GenderTextBox.Text;
                        context.SaveChanges(); // Сохраняем изменения в базе данных
                        MessageBox.Show("Данные успешно изменены.");
                    }
                    else
                    {
                        MessageBox.Show("Участник с указанным ID не найден.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка добавления данных: " + ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            }
        }
    
    
}
