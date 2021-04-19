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
using BolnicaSims.Service;
using BolnicaSims.Controller;
using BolnicaSims.View.AddView;
using BolnicaSims.View.NotificationsView;

namespace BolnicaSims
{
    /// <summary>
    /// Interaction logic for ListaPacijenata.xaml
    /// </summary>
    public partial class SekretarView : Window
    {
        private static SekretarView instance = null;
        public static SekretarView Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SekretarView();
                }
                return instance;
            }
        }

        public ObservableCollection<Pacijent> pacijenti = PacijentiStorage.Instance.Read();
        public void refreshPacijenti()
        {
            pacijenti = PacijentiStorage.Instance.Read();
            dataGridPacijenti.ItemsSource = PacijentiStorage.Instance.Read();
        }
        public void refreshTermini()
        {
            
            dataGridTermini.ItemsSource = TerminStorage.Instance.Read();
        }
        public Pacijent getSelektovanPacijent()
        {
            Pacijent selektovan = (Pacijent)dataGridPacijenti.SelectedItem;
            return selektovan;
        }
        public SekretarView()
        {
            InitializeComponent();
            dataGridPacijenti.ItemsSource = PacijentiStorage.Instance.Read();
            dataGridTermini.ItemsSource = TerminStorage.Instance.Read();
        }

        private void ButtonUkloni_Click(object sender, RoutedEventArgs e)
        {
            Pacijent selektovan = (Pacijent)dataGridPacijenti.SelectedItem;
            PacijentiStorage.Instance.Read().Remove(selektovan);
            PacijentiStorage.Instance.Save();


        }
        private void ButtonDodaj_Click(object sender, RoutedEventArgs e)
        {
            
            var s = new DodavanjePacijenta();
            s.Show();
            
        }

        private void ButtonIzmeni_Click(object sender, RoutedEventArgs e)
        {
                         
            var s = new IzmenaPacijenta();
            s.Show();               
            
        }
        private void ButtonZakazi_Click(object sender, RoutedEventArgs e)
        {
            
            var s = new DodavanjeTerminaSekretar();
            s.Show();
            
        }
        private void ButtonOtkazi_Click(object sender, RoutedEventArgs e)
        {
            Termin selektovan = (Termin)dataGridTermini.SelectedItem;
            TerminStorage.Instance.Read().Remove(selektovan);
            TerminStorage.Instance.Save();
        }
        private void ButtonIzmeniTermin_Click(object sender, RoutedEventArgs e)
        {
            
            var s = new IzmenaPregleda();
            s.Show();
            
        }

        private void ButtonObavestenja_Click(object sender, RoutedEventArgs e)
        {
            var s = new NotifikacijeSekretar();
            s.Show();
        }
        /* public void izmeniPacijenta(Pacijent pacijent)
{
    for (int i = 0; i < pacijenti.Count; i++)
    {

        if (pacijent.zdravstveniKarton.BrojKartona == pacijenti[i].zdravstveniKarton.BrojKartona)

            {
            if (pacijent.korisnik.Ime != "")
            {
                pacijenti[i].korisnik.Ime = pacijent.korisnik.Ime;
            }
            if (pacijent.korisnik.Prezime != "")
            {
                pacijenti[i].korisnik.Prezime = pacijent.korisnik.Prezime;
            }
            if (pacijent.zdravstveniKarton.ImeRoditelja != "")
            {
                pacijenti[i].zdravstveniKarton.ImeRoditelja = pacijent.zdravstveniKarton.ImeRoditelja;
            }
            if (pacijent.zdravstveniKarton.BrojKartona != "")
            {
                pacijenti[i].zdravstveniKarton.BrojKartona = pacijent.zdravstveniKarton.BrojKartona;
            }
        }

    }
PacijentController.Instance.izmeniPacijenta(pacijent);
   PacijentiStorage.Instance.Save();
   dataGridPacijenti.Items.Refresh();


}*/
    }
}
