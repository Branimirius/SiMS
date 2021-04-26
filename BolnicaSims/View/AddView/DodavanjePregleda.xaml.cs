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
          
        }



        private void dodavanjeBtn_Click(object sender, RoutedEventArgs e)
        {
            
            //tempTermin.IdTermina = TerminService.Instance.GenID();
           // tempTermin.VremeTermina= DateTime.Parse(txtBox1.Text);
      
           /*foreach(Doktor d in DoktoriStorage.Instance.doktori)
            {
                if((d.korisnik.Ime + " " + d.korisnik.Prezime) == ((String)comboBox1.SelectedItem))
                {
                    tempTermin.doktori.Add(d);
                    tempTermin.ImePrezimeDoktora = d.korisnik.Ime + " " + d.korisnik.Prezime;
                    tempTermin.pacijent = 
                }
            }*/
           TerminController.Instance.dodajTermin(txtBox1.Text, (String)comboBox1.SelectedItem, (KorisniciStorage.Instance.ulogovaniKorisnik.Ime + " " + KorisniciStorage.Instance.ulogovaniKorisnik.Prezime));

            //TerminStorage.Instance.Read().Add(tempTermin);
            //TerminStorage.Instance.Save();

            //ListaTermina.Instance.refreshListaTermina();
            

            this.Close();
            
            
        }

      


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void RadioDoktor_Checked(object sender, RoutedEventArgs e)
        {
            comboBox1.IsEnabled = true;
            txtBox1.IsEnabled = false;
            txtBox1.Text = "02/02/2021 12:15:00AM";
       
        }

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
           
        }
    }
}
