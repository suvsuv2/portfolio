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
    /// Логика взаимодействия для ModeratorWindow.xaml
    /// </summary>
    public partial class ModeratorWindow : Window
    {
        public ObservableCollection<object> Items { get; set; }
        public static MaincontextM context = new MaincontextM();
        public ObservableCollection<Activity> activities { get; set; }
        public List<Activity> ActivitesList { get; set; }
        public ModeratorWindow()
        {
            InitializeComponent();
            ActivitesList = context.ActivityZ.ToList();
            activities = new ObservableCollection<Activity>();
            InputList.ItemsSource = ActivitesList;
        }
    }
}
