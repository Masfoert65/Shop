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

namespace Shop
{
    /// <summary>
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : Page
    {
        public Menu()
        {
            InitializeComponent();
        }

        public void button_clicked(object sender, RoutedEventArgs e)
        {
            Navigation.MainFrame.Navigate(new Shop());
        }

        public void Statisticbutton_clicked(object sender, RoutedEventArgs e)
        {
            Navigation.MainFrame.Navigate(new Static());

        }

        public void Zakazbutton_clicked(object sender, RoutedEventArgs e)
        {
            Navigation.MainFrame.Navigate(new Zakaz());

        }

        public void Exitbutton_clicked(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

