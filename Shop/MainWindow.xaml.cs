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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new Menu());
            Navigation.MainFrame = MainFrame;
        }

        public void Backbutton_clicked(object sender, RoutedEventArgs e)
        {
            try
            {
                Navigation.MainFrame.GoBack();
            }
            catch (Exception)
            {

            }
        }

        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {
            Backbutton.Visibility = Visibility.Hidden;

            if (MainFrame.CanGoBack)
            {
                Backbutton.Visibility = Visibility.Visible;
            }
        }
    }
}