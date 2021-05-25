using BolnicaSims.Controller;
using BolnicaSims.Model;
using BolnicaSims.Service;
using BolnicaSims.Storage;
using BolnicaSims.View.AddView;
using BolnicaSims.View.MainView;
using BolnicaSims.View.NotificationsView;
using BolnicaSims.View.TableView;
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
        public ObservableCollection<Recept> recepti = ReceptiStorage.Instance.Read();
        public ObservableCollection<Recept> pacRecepti = new ObservableCollection<Recept>();
        

        public PacijentView()
        {
            InitializeComponent();
            

            if(PacijentController.Instance.proveriBan(DateTime.Now,PacijentController.Instance.getUlogovaniPacijent()))
            {
                zakazi.IsEnabled = false;
                izmeni.IsEnabled = false;
            }
            dataGridTermini.ItemsSource = PacijentController.Instance.getUlogovaniPacijent().termini;
            dataGridRecepti.ItemsSource = PacijentController.Instance.getUlogovaniPacijent().recepti;           
            
            PacijentController.Instance.zabeleziOdradjenePreglede();

            if ((PacijentController.Instance.getUlogovaniPacijent().brojOdradjenihPregleda)  % 3 == 0)
            {
                btnAnketaBolnica.IsEnabled = true;
            }
            else
            {
                btnAnketaBolnica.IsEnabled = false;
            }

            PacijentController.Instance.getUlogovaniPacijent().brojZakazivanja = 0;

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
                
                TerminController.Instance.ukloniTermin((Termin)dataGridTermini.SelectedItem);

            }
            else
            {
                MessageBox.Show("Nije izabran termin za izmenu");
                return;
            }
        }

        private void ButtonObavestenja_Click(object sender, RoutedEventArgs e)
        {
         
            foreach(Recept r in PacijentController.Instance.getUlogovaniPacijent().recepti)
            {
                ReceptController.Instance.notifikacijaLek(r);
            }
            var s = new NotifikacijePacijent();
            s.Show();
        }

        private void Button_Click_AnketaDoktor(object sender, RoutedEventArgs e)
        {
            var s = new AnketaDoktor();
            s.Show();
        
        }

        private void Button_Click_AnketaBolnica(object sender, RoutedEventArgs e)
        {
            var s = new AnketaBolnica();
            s.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var s = new MainWindow();
            s.Show();
            Close();
        }

        private void karton_Click(object sender, RoutedEventArgs e)
        {
            var s = new PacijentKarton();
            s.Show();
        }
    }
}
