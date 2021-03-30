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
    /// Interaction logic for ListaPacijenata.xaml
    /// </summary>
    public partial class ListaPacijenata : Window
    {
        private static ListaPacijenata instance = null;
        public static ListaPacijenata Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ListaPacijenata();
                }
                return instance;
            }
        }

        public ObservableCollection<Pacijent> pacijenti = PacijentiStorage.Instance.Read();
        public Pacijent getSelektovanPacijent()
        {
            Pacijent selektovan = (Pacijent)dataGridPacijenti.SelectedItem;
            return selektovan;
        }
        public ListaPacijenata()
        {
            InitializeComponent();
            dataGridPacijenti.ItemsSource = pacijenti;
        }

        private void ButtonUkloni_Click(object sender, RoutedEventArgs e)
        {
            Pacijent selektovan = (Pacijent)dataGridPacijenti.SelectedItem;
            pacijenti.Remove(selektovan);
            PacijentiStorage.Instance.Save();


        }
        private void ButtonDodaj_Click(object sender, RoutedEventArgs e)
        {
            {
                var s = new DodavanjePacijenta();
                s.Show();
            }
        }

        private void ButtonIzmeni_Click(object sender, RoutedEventArgs e)
        {
            {             
                var s = new IzmenaPacijenta();
                s.Show();               
            }
        }
        public void izmeniPacijenta(Pacijent pacijent)
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
            PacijentiStorage.Instance.Save();
            dataGridPacijenti.Items.Refresh();


        }
    }
}
