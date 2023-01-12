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
    /// Логика взаимодействия для Zakaz.xaml
    /// </summary>
 
    public partial class Zakaz : Page
    {
        public Zakaz()
        {
            InitializeComponent();
        }
        public void post1button_clicked(object sender, RoutedEventArgs e)
        {
            Navigation.MainFrame.Navigate(new post1());

        }

        public void post2button_clicked(object sender, RoutedEventArgs e)
        {
            Navigation.MainFrame.Navigate(new post2());
        }
    }
}
