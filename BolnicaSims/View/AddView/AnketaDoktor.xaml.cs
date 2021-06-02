using BolnicaSims.Controller;
using BolnicaSims.Service;
using BolnicaSims.Storage;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for AnketaDoktor.xaml
    /// </summary>
    public partial class AnketaDoktor : Window, INotifyPropertyChanged
    {
        public AnketaDoktor()
        {

            InitializeComponent();
      
            comboBoxDoktor.ItemsSource = DoktoriStorage.Instance.doktoriAnketa;
            DoktoriStorage.Instance.doktoriAnketa.Clear();
            foreach (Termin t in PacijentController.Instance.getUlogovaniPacijent().termini)
            {
                if (DateTime.Now > t.VremeTermina)
                {
                    DoktoriStorage.Instance.doktoriAnketa.Add(t.ImePrezimeDoktora);
                }
            }
            comboBoxDoktor.ItemsSource = DoktoriStorage.Instance.doktoriAnketa;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void Button_Click_Potvrdi(object sender, RoutedEventArgs e)
        {
            if(!valid())
            {
                return;
            }

            AnketaController.Instance.dodajAnketuDoktor((String)comboBoxDoktor.SelectedItem, txtBoxOcena.Text, txtBoxKomentar.Text, (KorisniciStorage.Instance.ulogovaniKorisnik.Ime + " " + KorisniciStorage.Instance.ulogovaniKorisnik.Prezime));
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
            if(comboBoxDoktor.SelectedItem == null)
            {
                MessageBox.Show("Niste izabrali doktora");
                return false;
            }
            if(!int.TryParse(txtBoxOcena.Text,out parsedValue))
            {
                MessageBox.Show("U polju za unos ocene su dozvoljene samo cifre");
                return false;
            }
            else if(int.Parse(txtBoxOcena.Text) > 10 || int.Parse(txtBoxOcena.Text) == 0)
            {
                MessageBox.Show("Mogu se uneti cifre samo od 1 do 10 za ocenu");
                return false;
            }
            return true;
        }
    }
}
