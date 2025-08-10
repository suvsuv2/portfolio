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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        MainWindow main = new MainWindow();
        public static MainContextx context = new MainContextx();
        public AddWindow(System.Threading.Tasks.Task btn)
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
                Services task = new Services()
                {
                    Name = nameTask.Text,
                    Time = TypeTask.LineCount,
                    Cost = Data.LineCount,
                    Sale = Dis.LineCount,

                    //Time = int.Parse(TypeTask.Text);
                    //Cost = int.Parse(Data.Text);
                    //Sale = int.Parse(Dis.Text);

                };
                context.services.Add(task);
                context.SaveChanges();
                main.lists.Clear();
                var services = context.services.ToList();
                foreach (var item in services)
                {

                    //task.ID = 0; 
                    //context.Entry(task).State = EntityState.Added;
                    context.SaveChanges();
                    main.lists.Add(item);
                }

                this.DialogResult = true;

                this.Close();
            }
        }
    }
}
