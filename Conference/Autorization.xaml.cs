using Conference.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
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
    /// Логика взаимодействия для Autorization.xaml
    /// </summary>
    public partial class Autorization : Window
    {
        public Autorization()
        {
            InitializeComponent();
          

        }
        private int incorrectAttempts = 0;

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            int enteredID = int.Parse(textBox_ID.Text);
            string enteredPassword = passwordBox.Text;

            using (var context = new MaincontextM()) 
            {
                Shuri shuri = context.ShuriZ.FirstOrDefault(s => s.ID == enteredID && s.Password == enteredPassword);
                Participant participant = context.ParticipantZ.FirstOrDefault(z => z.ID == enteredID && z.Password == enteredPassword);
                Organizer organizer = context.OrganizerZ.FirstOrDefault(v => v.ID == enteredID && v.Password == enteredPassword);
                Moderator moderator = context.ModeratorZ.FirstOrDefault(o => o.ID == enteredID &&  o.Password == enteredPassword);
              
                if (shuri != null)
                {
                    ShuriWindow shuriWindow = new ShuriWindow();
                    shuriWindow.Show();
                    Close();
                    return;
                }
                if (participant != null)
                {
                    ParticipantWindow participantWindow = new ParticipantWindow(enteredID.ToString());
                    participantWindow.Show();
                    Close();
                    return;
                }
                if (organizer != null)
                {
                    Organizator orga = new Organizator(enteredID.ToString());
                    orga.Show();
                    Close();
                    return;
                }
                if (moderator != null)
                {
                    ModeratorWindow moderatorWindow = new ModeratorWindow(/*enteredID.ToString()*/);
                    moderatorWindow.Show();
                    Close();
                    return;
                }
                //if (shuri == null || participant == null || organizer == null || moderator == null)
                //{
                //    MessageBox.Show("Пустое окно.");
                //}

                else
                {
                    MessageBox.Show("Неверный ID или пароль.");
                }
                incorrectAttempts++;
                if (incorrectAttempts >= 3)
                {
                    incorrectAttempts = 0;
                   
                    textBox_ID.IsEnabled = false;
                    passwordBox.IsEnabled = false;
                    abno.IsEnabled= false;

                 
                    MessageBox.Show("Слишком много запросов, 10 секунд timeout");

                  
                    Timer timer = new Timer(10000);
                    timer.Elapsed += Timer_Elapsed;
                    timer.AutoReset = false;
                    timer.Enabled = true;

                    return;
                }

            }

        }
        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
           
            Dispatcher.Invoke(() =>
            {
                textBox_ID.IsEnabled = true;
                passwordBox.IsEnabled = true;
                abno.IsEnabled = true;
            });
        }
    }
}
