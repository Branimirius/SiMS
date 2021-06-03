﻿using BolnicaSims.Controller;
using BolnicaSims.DTO;
using BolnicaSims.Service;
using BolnicaSims.Storage;
using BolnicaSims.View.MainView;
using Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BolnicaSims
{
    /// <summary>
    /// Interaction logic for IzmenaPregleda.xaml
    /// </summary>
    public partial class IzmenaPregleda : Window
    {
        public IzmenaPregleda()
        {
            InitializeComponent();
        }

        private void ButtonIzmeni_Click(object sender, RoutedEventArgs e)
        {
            TerminDTO tempTermin = new TerminDTO(TerminController.Instance.getSelektovaniTermin());
            if (!valid())
            {
                return;
            }
            if (proveraPomeranje(tempTermin, txtBox1.Text))
            {
                tempTermin.VremeTermina = DateTime.Parse(txtBox1.Text);
                TerminController.Instance.izmeniTermin(tempTermin);
            }

            switch (KorisniciStorage.Instance.ulogovaniKorisnik.Zvanje)
            {
                case "Pacijent":
                    CollectionViewSource.GetDefaultView(PacijentView.Instance.dataGridTermini.ItemsSource).Refresh();
                    break;
                case "Doktor":
                    CollectionViewSource.GetDefaultView(ListaTerminaDoktor.Instance.dataGridSopstveniTermini.ItemsSource).Refresh();
                    break;
                case "Sekretar":
                    CollectionViewSource.GetDefaultView(SekretarView.Instance.dataGridTermini.ItemsSource).Refresh();
                    break;
            }


            this.Close();
        }
        public Boolean proveraPomeranje(TerminDTO termin, String vreme)
        {
            DateTime stariTermin = termin.VremeTermina;
            DateTime noviTermin = DateTime.Parse(vreme);
            DateTime noviTermin2 = DateTime.Parse(vreme);
            DateTime noviTermin3 = stariTermin.AddDays(-1);
            if (DateTime.UtcNow > noviTermin)
            {
                MessageBox.Show("Termin ne moze da se pomera u proslost");
                return false;
            }
            if (DateTime.Now > noviTermin3)
            {
                MessageBox.Show("Termin ne moze da se pomera 24h pre termina");
                return false;
            }

            noviTermin = noviTermin.AddDays(2);
            noviTermin2 = noviTermin2.AddDays(-2);

            if (stariTermin > noviTermin)
            {
                MessageBox.Show("Datum ne sme biti pomeren vise od 2 dana unazad");
                return false;
            }
            if (stariTermin < noviTermin2)
            {
                MessageBox.Show("Datum ne sme biti pomeren za vise od 2 dana");
                return false;
            }

            return true;
        }

        private bool valid()
        {
            CultureInfo enUS = new CultureInfo("en-US");
            string dateString = txtBox1.Text;
            DateTime dateValue;
            if (!DateTime.TryParseExact(dateString, "M/dd/yyyy hh:mm tt", enUS,
                               DateTimeStyles.None, out dateValue))
            {
                MessageBox.Show("Nije unesen dobar format za datum M/dd/yyyy hours:minutes PM (5/09/2021 09:30 AM)");
                return false;
            }
            return true;

        }
    }

}
