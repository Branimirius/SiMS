using BolnicaSims.Model;
using BolnicaSims.Storage;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for NotifikacijeDoktor.xaml
    /// </summary>
    public partial class NotifikacijeDoktor : Window
    {
        public ObservableCollection<Notifikacija> Notifikacije = KorisniciStorage.Instance.ulogovaniKorisnik.Notifikacije;
        public NotifikacijeDoktor()
        {
            InitializeComponent();
            listBoxNotifikacije.ItemsSource = KorisniciStorage.Instance.ulogovaniKorisnik.Notifikacije;
        }
        private void HandleDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var notifikacija = ((ListViewItem)sender).Content as Notifikacija; //Casting back to the binded 
            MessageBox.Show(notifikacija.Tekst);
        }
        private void listBoxNotifikacije_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var notifikacija = (Notifikacija)listBoxNotifikacije.SelectedItem;
            MessageBox.Show(notifikacija.Tekst);
        }
    }
}

