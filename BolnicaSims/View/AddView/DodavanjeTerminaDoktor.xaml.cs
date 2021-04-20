using BolnicaSims.Controller;
using BolnicaSims.Service;
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

namespace BolnicaSims.View.AddView
{
    /// <summary>
    /// Interaction logic for DodavanjeTerminaDoktor.xaml
    /// </summary>
    public partial class DodavanjeTerminaDoktor : Window
    {
        public DodavanjeTerminaDoktor()
        {
            InitializeComponent();
            comboBox2.ItemsSource = PacijentiStorage.Instance.pacijentiImena;
        }

        private void dodavanjeBtn_Click(object sender, RoutedEventArgs e)
        {
            TerminController.Instance.dodajTermin(txtBox1.Text, KorisniciStorage.Instance.ulogovaniKorisnik.Ime + ' ' + KorisniciStorage.Instance.ulogovaniKorisnik.Prezime, (string)comboBox2.SelectedItem);
            ListaSopstvenihTermina.Instance.dokTermini.Add(new Termin(TerminService.Instance.GenID(), txtBox1.Text, KorisniciStorage.Instance.ulogovaniKorisnik.Ime + ' ' + KorisniciStorage.Instance.ulogovaniKorisnik.Prezime));
            ListaSopstvenihTermina.Instance.refreshListaSopstvenihTermina();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Pacijenti_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
