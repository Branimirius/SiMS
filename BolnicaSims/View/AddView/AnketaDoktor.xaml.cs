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
    /// Interaction logic for AnketaDoktor.xaml
    /// </summary>
    public partial class AnketaDoktor : Window
    {
        public AnketaDoktor()
        {

            InitializeComponent();
            comboBoxDoktor.ItemsSource = DoktoriStorage.Instance.doktoriAnketa;
            DoktoriStorage.Instance.doktoriAnketa.Clear();
            foreach (Termin t in PacijentService.Instance.getUlogovaniPacijent(KorisniciStorage.Instance.ulogovaniKorisnik).termini)
            {
                if (DateTime.Now > t.VremeTermina)
                {
                    DoktoriStorage.Instance.doktoriAnketa.Add(t.ImePrezimeDoktora);
                }
            }
            comboBoxDoktor.ItemsSource = DoktoriStorage.Instance.doktoriAnketa;
        }

        private void Button_Click_Potvrdi(object sender, RoutedEventArgs e)
        {
            AnketaController.Instance.dodajAnketu((String)comboBoxDoktor.SelectedItem, txtBoxOcena.Text, txtBoxKomentar.Text, (KorisniciStorage.Instance.ulogovaniKorisnik.Ime + " " + KorisniciStorage.Instance.ulogovaniKorisnik.Prezime));
            this.Close();
        }

        private void Button_Click_Ponisti(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
