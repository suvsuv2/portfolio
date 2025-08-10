using System;
using System.Collections;
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
using System.Xml.Linq;
using TaskManadgerr.Models;
using Input = TaskManadgerr.Models.Input;
namespace TaskManadgerr
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainContextz context = new MainContextz();
        public ObservableCollection<Input> Inputlists { get; set; }
        public ObservableCollection<Output> Outputlists { get; set; }
        public ObservableCollection<Work_in_progress> WIPlists { get; set; }
        public List<Input> fullList { get; set; }
        public List<Output> fullList2 { get; set; }
        public List<Work_in_progress> fullList3 { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            fullList = Constants.Context.Inputs.ToList();
            fullList2 = Constants.Context.Outputs.ToList();
            fullList3 = Constants.Context.Work_in_progresses.ToList();

            Inputlists = new ObservableCollection<Input>(fullList);
            Outputlists = new ObservableCollection<Output>(fullList2);
            WIPlists = new ObservableCollection<Work_in_progress>(fullList3);
            InputList.ItemsSource = Inputlists;
            OutputList.ItemsSource = Outputlists;
            WorkList.ItemsSource = WIPlists;


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var btn = (e.Source as Button).DataContext as System.Threading.Tasks.Task;

            NewInput createSevice = new NewInput(btn);
            var create = createSevice.ShowDialog();

            if (create == true)
            {
                InitializeComponent();
                fullList = Constants.Context.Inputs.ToList();
                Inputlists = new ObservableCollection<Input>(fullList);
                InputList.ItemsSource = Inputlists;
                
            }
        }
        private void deleteTask_Click(object sender, RoutedEventArgs e)
        {
            if (InputList.SelectedItem != null)
            {
                var selectedItem = (Input)InputList.SelectedItem;

                var dataSource = (ObservableCollection<Input>)InputList.ItemsSource;

                
                using (var db = new MainContextz())
                {
                    var itemToDelete = db.Inputs.FirstOrDefault(item => item.ID == selectedItem.ID);
                    if (itemToDelete != null)
                    {
                        db.Inputs.Remove(itemToDelete);
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
