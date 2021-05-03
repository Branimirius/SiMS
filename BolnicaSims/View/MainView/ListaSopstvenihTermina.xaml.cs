using BolnicaSims.Controller;
using BolnicaSims.Model;
using BolnicaSims.Service;
using BolnicaSims.Storage;
using BolnicaSims.View.AddView;
using BolnicaSims.View.MainView;
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
    /// Interaction logic for ListaSopstvenihTermina.xaml
    /// </summary>
    public partial class ListaSopstvenihTermina : Window
    {
        private static ListaSopstvenihTermina instance = null;
        public static ListaSopstvenihTermina Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ListaSopstvenihTermina();
                }
                return instance;
            }
        }

        public ObservableCollection<Termin> termini = TerminStorage.Instance.Read();
        public ObservableCollection<Termin> dokTermini = new ObservableCollection<Termin>();
        public ListaSopstvenihTermina()
        {
            InitializeComponent();
            /* 
             foreach(Termin t in termini)
             {
                 if (t.ImePrezimeDoktora == KorisniciStorage.Instance.ulogovaniKorisnik.Ime + ' ' + KorisniciStorage.Instance.ulogovaniKorisnik.Prezime)
                 {
                     dokTermini.Add(t);
                 }    
             }
            */
            dataGridSopstveniTermini.ItemsSource = DoktorService.Instance.getUlogovaniDoktor(KorisniciStorage.Instance.ulogovaniKorisnik).termini;
            //dataGridSopstveniTermini.ItemsSource = dokTermini;
        }
        
        public void refreshListaSopstvenihTermina()
        {
            termini = TerminStorage.Instance.Read();
            dokTermini.Clear();
            foreach (Termin t in termini)
            {
                if (t.ImePrezimeDoktora == KorisniciStorage.Instance.ulogovaniKorisnik.Ime + ' ' + KorisniciStorage.Instance.ulogovaniKorisnik.Prezime)
                {
                    dokTermini.Add(t);
                }
            }

            dataGridSopstveniTermini.ItemsSource = dokTermini;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var s = new DodavanjeTerminaDoktor();
            s.Show();
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            /*if ((Termin)dataGridSopstveniTermini.SelectedItem == null)
            {
                MessageBox.Show("Nije izabran termin za izmenu");
                return;
            }*/
            if (dataGridSopstveniTermini.SelectedItem is Termin)
            { 
                TerminStorage.Instance.selektovanTermin = (Termin)dataGridSopstveniTermini.SelectedItem;
                var s = new IzmenaPregleda();
                s.Show();
            }
            else
            {
                MessageBox.Show("Nije izabran termin za izmenu");
                return;
            }
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            if (dataGridSopstveniTermini.SelectedItem is Termin)
            {
                Termin selektovan = (Termin)dataGridSopstveniTermini.SelectedItem;
                TerminController.Instance.ukloniTermin(selektovan);
            }
            else
            {
                MessageBox.Show("Nije izabran termin za izmenu");
                return;
            }

                //refreshListaSopstvenihTermina();           
        }
        private void button_karton_Click(object sender, RoutedEventArgs e)
        {
            Termin selektovan = (Termin)dataGridSopstveniTermini.SelectedItem;
            Pacijent selektovanPacijent = selektovan.pacijent;
            PacijentiStorage.Instance.selektovanPacijent = selektovanPacijent;

            var s = new PregledKartona();
            s.Show();
        }

        private void dataGridSopstveniTermini_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
