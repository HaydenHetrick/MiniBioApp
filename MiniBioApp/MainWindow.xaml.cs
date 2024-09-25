using System.Windows;

namespace MiniBioApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new Page1()); // Load Page 1 by default
        }

        private void Button_Click_Page1(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Page1());
        }

        private void Button_Click_Page2(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Page2());
        }

        private void Button_Click_Page3(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Page3());
        }
    }
}
