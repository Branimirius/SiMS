using BolnicaSims.Controller;
using BolnicaSims.Service;
using BolnicaSims.Storage;
using BolnicaSims.View.MainView;
using BolnicaSims.View.NotificationsView;
using Model;
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

namespace BolnicaSims
{
    /// <summary>
    /// Interaction logic for PacijentView.xaml
    /// </summary>
    public partial class PacijentView : Window
    { 
     private static PacijentView instance = null;
    public static PacijentView Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new PacijentView();
            }
            return instance;
        }
    }

        public ObservableCollection<Termin> termini = TerminStorage.Instance.Read();
        public ObservableCollection<Termin> pacTermini = new ObservableCollection<Termin>();

        public PacijentView()
        {
            InitializeComponent();
            dataGridTermini.ItemsSource = PacijentService.Instance.getUlogovaniPacijent(KorisniciStorage.Instance.ulogovaniKorisnik).termini;
        }

        public void ObavestenjeRecept(String pacijent, String doktor, String lek, DateTime kreni, String naSati, String kolikoPut)
        {
            DateTime trenutnoSati = DateTime.Now;
            DateTime vremeZaPodsetnik = trenutnoSati.AddHours(-2);

            if (kreni == vremeZaPodsetnik)
            {
                MessageBox.Show("Za 2 sata treba da popijete lek");
            }
        }
    
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var s = new NotifikacijePacijent();
            s.Show();
        }

        private void ButtonZakazi_Click(object sender, RoutedEventArgs e)
        {
            var s = new DodavanjePregleda();
            s.Show();
        }

        private void ButtonIzmeniTermin_Click(object sender, RoutedEventArgs e)
        {
            if (dataGridTermini.SelectedItem is Termin)
            {
                Termin selektovan = (Termin)dataGridTermini.SelectedItem;
                TerminStorage.Instance.selektovanTermin = selektovan;

                var s = new IzmenaPregleda();
                s.Show();

            }
            else
            {
                MessageBox.Show("Nije izabran termin za izmenu");
                return;
            }

        }

        private void ButtonOtkazi_Click(object sender, RoutedEventArgs e)
        {
            if (dataGridTermini.SelectedItem is Termin)
            {
                Termin selektovan = (Termin)dataGridTermini.SelectedItem;
                TerminController.Instance.ukloniTermin(selektovan);

            }
            else
            {
                MessageBox.Show("Nije izabran termin za izmenu");
                return;
            }
        }

        private void ButtonObavestenja_Click(object sender, RoutedEventArgs e)
        {
            var s = new NotifikacijePacijent();
            s.Show();
        }

    }
}
