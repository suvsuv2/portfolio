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


namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainContextx context = new MainContextx();
        public ObservableCollection<Services> lists { get; set; }
        public List<Services> fullList { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            fullList = Constans.Context.services.ToList();
            lists = new ObservableCollection<Services>(fullList);
            InputList.ItemsSource = lists;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var btn = (e.Source as Button).DataContext as System.Threading.Tasks.Task;

            AddWindow createSevice = new AddWindow(btn);
            var create = createSevice.ShowDialog();

            if (create == true)
            {
                InitializeComponent();
                fullList = Constans.Context.services.ToList();
                lists = new ObservableCollection<Services>(fullList);
                InputList.ItemsSource = lists;

            }
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (InputList.SelectedItem != null)
            {
                var selectedItem = (Services)InputList.SelectedItem;

                var dataSource = (ObservableCollection<Services>)InputList.ItemsSource;


                using (var db = new MainContextx())
                {
                    var itemToDelete = db.services.FirstOrDefault(item => item.Id == selectedItem.Id);
                    if (itemToDelete != null)
                    {
                        db.services.Remove(itemToDelete);
                        db.SaveChanges();
                    }
                }

                dataSource.Remove(selectedItem);
                InputList.ItemsSource = null;
                InputList.ItemsSource = dataSource;
            }
        }
    }
}
