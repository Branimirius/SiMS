using BolnicaSims.Controller;
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

namespace BolnicaSims.View.AddView
{
    /// <summary>
    /// Interaction logic for AnketaBolnica.xaml
    /// </summary>
    public partial class AnketaBolnica : Window
    {
        public AnketaBolnica()
        {
            InitializeComponent();
        }

        private void Button_Click_Potvrdi(object sender, RoutedEventArgs e)
        {
            AnketaController.Instance.dodajAnketuBolnica( txtBoxOcena.Text, txtBoxKomentar.Text, (KorisniciStorage.Instance.ulogovaniKorisnik.Ime + " " + KorisniciStorage.Instance.ulogovaniKorisnik.Prezime));
            MessageBox.Show("Uspesno ste popunili anketu.");
            this.Close();
        }

        private void Button_Click_Ponisti(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
