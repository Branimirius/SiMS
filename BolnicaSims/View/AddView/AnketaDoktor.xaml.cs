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
    /// Interaction logic for AnketaDoktor.xaml
    /// </summary>
    public partial class AnketaDoktor : Window
    {
        public AnketaDoktor()
        {
            InitializeComponent();
        }

        private void Button_Click_Potvrdi(object sender, RoutedEventArgs e)
        {
            AnketaController.Instance.dodajAnketu((String)comboBoxDoktor.SelectedItem, (String)comboBoxOcena.SelectedItem, txtBoxKomentar.Text, (KorisniciStorage.Instance.ulogovaniKorisnik.Ime + " " + KorisniciStorage.Instance.ulogovaniKorisnik.Prezime));
        }

        private void Button_Click_Ponisti(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
