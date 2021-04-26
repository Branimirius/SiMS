using BolnicaSims.Controller;
using BolnicaSims.Storage;
using Model;
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

namespace BolnicaSims.View.DeleteView
{
    /// <summary>
    /// Interaction logic for BrisanjeOsoblja.xaml
    /// </summary>
    public partial class BrisanjeOsoblja : Window
    {
        public BrisanjeOsoblja()
        {
            InitializeComponent();
        }

        private void btnPotvrdi_Click(object sender, RoutedEventArgs e)
        {
            KorisnikController.Instance.ukloniZaposlenog(KorisniciStorage.Instance.selektovaniKorisnik);
            this.Close();
        }

        private void btnOdustani_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
