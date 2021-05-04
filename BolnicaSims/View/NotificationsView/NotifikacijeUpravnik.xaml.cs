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
    }
}
