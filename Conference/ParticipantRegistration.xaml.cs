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
using System.Text.RegularExpressions;

namespace Conference
{
    /// <summary>
    /// Логика взаимодействия для ParticipantRegistration.xaml
    /// </summary>
    public partial class ParticipantRegistration : Window
    {
        public ParticipantRegistration()
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
                    var newParticipant = new Participant();
               
                    newParticipant.ID = int.Parse(TextBox1.Text);
                    newParticipant.FIO = FIOTextBox.Text;
                    newParticipant.Mail = MaleTextBox.Text;
                    if (Date.SelectedDate.HasValue)
                        newParticipant.BirthdayData = Date.SelectedDate.Value;
                    newParticipant.Country = CountryTextBox.Text;

                    string telephoneNumber = TelephoneNumberTextBox.Text;
                    string pattern = @"^(\+|-|\()?\d{1}[\d\-\+\(\)\s]{8,13}\d$";
                    bool isPhoneNumberValid = Regex.IsMatch(telephoneNumber, pattern);              
                    newParticipant.TelephoneNumber = TelephoneNumberTextBox.Text;

                    newParticipant.Password = passwordTextBox.Text;
                    newParticipant.Gender = GenderComboBox.Text;
                    if (isPhoneNumberValid)
                    {
                        if (passwordTextBox.Text == reenterPasswordTextBox.Text)
                        {
                            context.ParticipantZ.Add(newParticipant);
                            context.SaveChanges();
                            MessageBox.Show("Данные успешно добавлены", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                        else
                        {
                            MessageBox.Show("Пароли не совпадают.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Некорректный номер телефона. Пожалуйста, введите правильный номер.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка добавления данных: " + ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }



            }
            
        }
        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.TextBox textBox = (System.Windows.Controls.TextBox)sender;
            if (textBox.Text == "Password" || textBox.Text == "Re-enter password")
            {
                textBox.Text = "";
                textBox.FontStyle = FontStyles.Normal;
                textBox.Foreground = Brushes.Black;
            }
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.TextBox textBox = (System.Windows.Controls.TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = textBox.Name == "passwordTextBox" ? "Password" : "Re-enter password";
                textBox.FontStyle = FontStyles.Italic;
                textBox.Foreground = Brushes.LightGray;
            }
        }

        private string passwordText = "Password";
        private string reenterPasswordText = "Re-enter password";

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            passwordText = passwordTextBox.Text;
            reenterPasswordText = reenterPasswordTextBox.Text;

            passwordTextBox.Text = new string('*', passwordText.Length);
            reenterPasswordTextBox.Text = new string('*', reenterPasswordText.Length);
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            passwordTextBox.Text = passwordText;
            reenterPasswordTextBox.Text = reenterPasswordText;
        }
    }
}

