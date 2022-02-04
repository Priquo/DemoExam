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
using System.Windows.Navigation;
using System.Windows.Shapes;
using DemoViewModel;

namespace DemoExam.pages
{
    /// <summary>
    /// Логика взаимодействия для ServicesList.xaml
    /// </summary>
    public partial class ServicesList : Page
    {
       
        public ServicesList()
        {
            InitializeComponent();
            LoadServices loadServices = new LoadServices();
            listboxServices.ItemsSource = loadServices.Services;
        }

        private void listboxServices_Loaded(object sender, RoutedEventArgs e)
        {
            ListBox listBox = (ListBox)sender;

        }
    }
}
