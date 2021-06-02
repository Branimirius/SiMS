using BolnicaSims.Controller;
using BolnicaSims.Storage;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
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
            if (!valid())
            {
                return;
            }
            AnketaController.Instance.dodajAnketuBolnica( txtBoxOcena.Text, txtBoxKomentar.Text, (KorisniciStorage.Instance.ulogovaniKorisnik.Ime + " " + KorisniciStorage.Instance.ulogovaniKorisnik.Prezime));
            MessageBox.Show("Uspesno ste popunili anketu.");
            this.Close();
        }

        private void Button_Click_Ponisti(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private bool valid()
        {
            Regex regex = new Regex("^[a-zA-Z]+$");
            int parsedValue;
       
            if (!int.TryParse(txtBoxOcena.Text, out parsedValue))
            {
                MessageBox.Show("U polju za unos ocene su dozvoljene samo cifre");
                return false;
            }
            else if (int.Parse(txtBoxOcena.Text) > 10 || int.Parse(txtBoxOcena.Text) == 0)
            {
                MessageBox.Show("Mogu se uneti cifre samo od 1 do 10 za ocenu");
                return false;
            }
            return true;
        }
    }
}
