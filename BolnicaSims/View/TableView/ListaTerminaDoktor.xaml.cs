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
using System.Windows.Navigation;
using System.Windows.Shapes;
using BolnicaSims.Controller;
using BolnicaSims.Model;
using BolnicaSims.Service;
using BolnicaSims.Storage;
using BolnicaSims.View.AddView;
using BolnicaSims.View.MainView;
using Model;

namespace BolnicaSims.View.MainView
{
    /// <summary>
    /// Interaction logic for ListaTerminaDoktor.xaml
    /// </summary>
    public partial class ListaTerminaDoktor : Page
    {
        private static ListaTerminaDoktor instance = null;
        public static ListaTerminaDoktor Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ListaTerminaDoktor();
                }
                return instance;
            }
        }

        public ListaTerminaDoktor()
        {
            InitializeComponent();
            dataGridSopstveniTermini.ItemsSource = DoktorService.Instance.getKorisnikDoktor(KorisniciStorage.Instance.ulogovaniKorisnik).termini;
            ShowsNavigationUI = false;
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            var s = new DodavanjeTerminaDoktor();
            s.Show();
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {

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

                TerminController.Instance.ukloniTermin((Termin)dataGridSopstveniTermini.SelectedItem);
            }
            else
            {
                MessageBox.Show("Nije izabran termin za izmenu");
                return;
            }

        }
        private void button_karton_Click(object sender, RoutedEventArgs e)
        {
            
            Termin selektovan = (Termin)dataGridSopstveniTermini.SelectedItem;
            if((Termin)dataGridSopstveniTermini.SelectedItem == null)
            {
                MessageBox.Show("niste izabrali termin (pacijenta).");
                return;
            }
            Pacijent selektovanPacijent = PacijentController.Instance.getPacijent(selektovan.pacijent);
            PacijentiStorage.Instance.selektovanPacijent = selektovanPacijent;

            var s = new PregledKartona();
            s.Show();


        }

        private void dataGridSopstveniTermini_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void searchbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            DateTime date = DateTime.Parse(searchbox.Text);
            DoktorController.Instance.searchTermini(date);
        }
    }
}
