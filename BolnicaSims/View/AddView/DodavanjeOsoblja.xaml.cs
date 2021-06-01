using BolnicaSims.MVVM.HelpView;
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

namespace BolnicaSims.View.AddView
{
    /// <summary>
    /// Interaction logic for DodavanjeOsoblja.xaml
    /// </summary>
    public partial class DodavanjeOsoblja : Window
    {
        public DodavanjeOsoblja()
        {
            InitializeComponent();
        }

        private void btnLekar_Click(object sender, RoutedEventArgs e)
        {
            var s = new DodavanjeDoktora();
            s.Show();
            this.Close();
        }

        private void btnSekretar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnOdustani_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void helpBtn_Click(object sender, RoutedEventArgs e)
        {
            //ContentArea.Content = new PomocMainView();
            var s = new PomocMainViewWin();
            s.ShowDialog();
        }
    }
}
