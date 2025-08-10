using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using TaxiCompany.Models;

using static System.Net.Mime.MediaTypeNames;

namespace TaxiCompany
{
    /// <summary>
    /// Логика взаимодействия для NewInput.xaml
    /// </summary>
    public partial class NewInput : Window
    {
        
        List<DriverGosling> driverlist;
        public static MainContext context = new MainContext();
        MainWindow main = new MainWindow();
        public NewInput(List<DriverGosling> driverlist)
    {
           
            InitializeComponent();
        this.driverlist = driverlist;
    }

    private void CreateDataButton_Click(object sender, RoutedEventArgs e)
    {
        
        DriverGosling newDriver = new DriverGosling
        {
            Name = NameTextBox.Text,
            Surname = SurnameTextBox.Text,
            PhoneNumber = Convert.ToInt32(PhoneNumberTextBox.Text),
            Cars = CarsTextBox.Text
        };    
        context.DriverGoslingZ.Add(newDriver);
        context.SaveChanges();
            //driverlist.Clear();
            
       
            this.DialogResult = true;
            this.Close();
    }
    }
}
































//    Для обновления ListBox после добавления нового элемента в driverlist вам нужно обновить источник данных элемента управления.Вам также стоит добавить привязку данных ListBox к driverlist. Примерно так:

//csharp
//Копировать
//public partial class NewInput : Window
//    {
//        public List<DriverGosling> driverlist;
//        public static MainContext context = new MainContext();
//        MainWindow main = new MainWindow();

//        public NewInput(List<DriverGosling> driverlist)
//        {
//            InitializeComponent();
//            this.driverlist = driverlist;
//        }

//        private void CreateDataButton_Click(object sender, RoutedEventArgs e)
//        {
//            DriverGosling newDriver = new DriverGosling
//            {
//                Name = NameTextBox.Text,
//                Surname = SurnameTextBox.Text,
//                PhoneNumber = Convert.ToInt32(PhoneNumberTextBox.Text),
//                Cars = CarsTextBox.Text
//            };

//            context.DriverGoslingZ.Add(newDriver);
//            context.SaveChanges();

//            // Обновление списка источника данных и ListBox
//            driverlist.Add(newDriver);
//            YourListBox.ItemsSource = null;
//            YourListBox.ItemsSource = driverlist;

//            this.DialogResult = true;
//            this.Close();
//        }
//    }


//    К сожалению, вы не предоставили достаточно информации о вашем коде или о том, как вы настроили ваш ListBox, чтобы я мог точно определить, в чем проблема.Однако, я могу предложить вам следующий подход для связывания ListBox с вашим driverlist.

//Допустим, у вас есть ListBox с именем driverListBox в разметке XAML вашего окна. Вы можете добавить привязку данных к ListBox следующим образом:

//xaml
//Копировать
//<listbox x:name= "driverListBox" itemssource= "{Binding driverlist}" >
//    < listbox.itemtemplate >
//        < datatemplate >
//            < stackpanel >
//                < textblock text= "{Binding Name}" >


//            </ stackpanel >
//        </ datatemplate >
//    </ listbox.itemtemplate >
//</ listbox >
//После этого в коде окна вы можете обновить свойство driverlist и уведомить ListBox об изменениях с помощью реализации интерфейса INotifyPropertyChanged.Например:

//csharp
//Копировать
//public partial class NewInput : Window, INotifyPropertyChanged
//    {
//        private List<DriverGosling> _driverlist;
//        public List<DriverGosling> driverlist
//        {
//            get { return _driverlist; }
//            set
//            {
//                _driverlist = value;
//                OnPropertyChanged("driverlist");
//            }
//        }

//        public NewInput(List<DriverGosling> driverlist)
//        {
//            InitializeComponent();
//            this.DataContext = this; // Чтобы привязки данных работали, устанавливаем контекст данных окна на само окно
//            this.driverlist = driverlist;
//        }

//        // Реализация интерфейса INotifyPropertyChanged
//        public event PropertyChangedEventHandler PropertyChanged;
//        protected void OnPropertyChanged(string propertyName)
//        {
//            if (PropertyChanged != null)
//            {
//                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
//            }
//        }

//        // Другие методы и события вашего окна
//    }
//    После этого, при обновлении driverlist, ListBox автоматически будет отображать новые данные благодаря механизму привязки данных и уведомлений об изменениях.

