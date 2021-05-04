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

namespace BolnicaSims
{
    /// <summary>
    /// Interaction logic for DodavanjePregleda.xaml
    /// </summary>
    public partial class DodavanjePregleda : Window
    {

        public Termin tempTermin = new Termin();

        public DodavanjePregleda()
        {
            InitializeComponent();
            comboBox1.ItemsSource = DoktoriStorage.Instance.doktoriImena;
            if (!PacijentController.Instance.proveriBan(DateTime.Now, PacijentService.Instance.getUlogovaniPacijent(KorisniciStorage.Instance.ulogovaniKorisnik)))
            {
                dodavanjeBtn.IsEnabled = true;
                
            }

        }



        private void dodavanjeBtn_Click(object sender, RoutedEventArgs e)
        {
            PacijentService.Instance.getUlogovaniPacijent(KorisniciStorage.Instance.ulogovaniKorisnik).brojZakazivanja++;
            if(PacijentService.Instance.getUlogovaniPacijent(KorisniciStorage.Instance.ulogovaniKorisnik).brojZakazivanja == 3)
            {
                MessageBox.Show("Pokusali ste da zakazete previse pregleda. Funkcija vam je onemogucena do sutra, pocevsi od sledeceg logovanja.");
                PacijentController.Instance.banujPacijenta(DateTime.Now, PacijentService.Instance.getUlogovaniPacijent(KorisniciStorage.Instance.ulogovaniKorisnik));
                dodavanjeBtn.IsEnabled = false;               
                return;
                
            }
            TerminController.Instance.dodajTermin(txtBox1.Text, (String)comboBox1.SelectedItem, (KorisniciStorage.Instance.ulogovaniKorisnik.Ime + " " + KorisniciStorage.Instance.ulogovaniKorisnik.Prezime));
            this.Close();  
          
        }

      


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

       /* private void RadioDoktor_Checked(object sender, RoutedEventArgs e)
        {
            comboBox1.IsEnabled = true;
            txtBox1.IsEnabled = false;
            if (comboBox1.SelectedItem != null)
            {
                txtBox1.Text = DoktorService.Instance.getDoktor((String)comboBox1.SelectedItem).termini[DoktorService.Instance.getDoktor((String)comboBox1.SelectedItem).termini.Count - 1].KrajTermina.AddMinutes(10).ToString();
            }
            else
            {
                MessageBox.Show("Niste izabrali doktora");
                radioDoktor.IsChecked = false;

            }
        }
       */
        private void RadioDatum_Checked(object sender, RoutedEventArgs e)
        {
            comboBox1.IsEnabled = false;
            txtBox1.IsEnabled = true;
            comboBox1.SelectedItem = DoktoriStorage.Instance.doktoriImena[1];
        }

        private void txtBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }
        private void ComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (DoktorService.Instance.getDoktor((String)comboBox1.SelectedItem).termini.Count == 0)
            {
                txtBox1.Text = DateTime.Now.ToString();
            }
            else
            {
                txtBox1.Text = DoktorService.Instance.getDoktor((String)comboBox1.SelectedItem).termini[DoktorService.Instance.getDoktor((String)comboBox1.SelectedItem).termini.Count - 1].KrajTermina.AddMinutes(10).ToString();
            }
      
        }


        private void radioDatum_Unchecked(object sender, RoutedEventArgs e)
        {
            txtBox1.Clear();
            comboBox1.IsEnabled = true;
        }

  
    }
}
