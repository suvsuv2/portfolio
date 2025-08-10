using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using TaskManadgerr.Models;
using Input = TaskManadgerr.Models.Input;

namespace TaskManadgerr
{
    /// <summary>
    /// Логика взаимодействия для NewInput.xaml
    /// </summary>
    public partial class NewInput : Window
    {
        MainWindow main = new MainWindow();
        public static MainContextz context = new MainContextz();
        public NewInput(System.Threading.Tasks.Task btn)
        {
            InitializeComponent();
            DataContext = btn;
        }
        private void addNewTask_Click(object sender, RoutedEventArgs e)
        {
            if (TypeTask.Text == "" || Data.Text == "")
            {
                MessageBoxResult result = MessageBox.Show("Остались пустые поля", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                Input task = new Input
                {
                    Name = nameTask.Text,
                    Type = TypeTask.Text,
                    Date = Data.Text,
                    
                };

                context.Inputs.Add(task);
                context.SaveChanges();
                main.Inputlists.Clear();
                var services = context.Inputs.ToList();
                foreach (var item in services)
                {

                    //task.ID = 0; 
                    //context.Entry(task).State = EntityState.Added;
                    context.SaveChanges();
                    main.Inputlists.Add(item);
                }

                this.DialogResult = true;

                this.Close();
            }
        }
    }
}
