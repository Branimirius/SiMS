using BolnicaSims.Model;
using BolnicaSims.Storage;
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

namespace BolnicaSims.View.NotificationsView
{
    /// <summary>
    /// Interaction logic for NotifikacijeUpravnik.xaml
    /// </summary>
    public partial class NotifikacijeUpravnik : Window
    {
        public NotifikacijeUpravnik()
        {
            InitializeComponent();
            listNotifikacijeUpravnik.ItemsSource = KorisniciStorage.Instance.ulogovaniKorisnik.Notifikacije;
        }

        private void okBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void HandleDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var notifikacija = ((ListViewItem)sender).Content as Notifikacija; //Casting back to the binded 
            MessageBox.Show(notifikacija.Tekst);
        }

        private void listNotifikacijeUpravnik_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var notifikacija = (Notifikacija)listNotifikacijeUpravnik.SelectedItem;
            MessageBox.Show(notifikacija.Tekst);
        }
    }
}
