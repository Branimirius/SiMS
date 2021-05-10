using BolnicaSims.View.EditView;
using BolnicaSims.View.MainView;
using BolnicaSims.View.NotificationsView;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BolnicaSims
{
    /// <summary>
    /// Interaction logic for DoktorView.xaml
    /// </summary>
    public partial class DoktorView : Window
    {
        Page p1 = new ListaTerminaDoktor();

        public DoktorView()
        {
            InitializeComponent();
            frame.Content = p1;
            menuItem1.Background = Brushes.DarkCyan;
        }

        private void ManualColumns_Click(object sender, RoutedEventArgs e)
        {
            frame.Content = p1;
            menuItem1.Background = Brushes.Blue;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var s = new NotifikacijeDoktor();
            s.Show();
        }

        private void validacijaBtn_Click(object sender, RoutedEventArgs e)
        {
            var s = new ValidacijaLekova();
            s.Show();
        }

        private void ManualColumns_Click2(object sender, RoutedEventArgs e)
        {
            var s = new PregledLekovaDoktor();
            s.Show();
        }

        private void ButtonLogOut_Click(object sender, RoutedEventArgs e)
        {
            var s = new MainWindow();
            s.Show();
            Close();
        }
    }
}
