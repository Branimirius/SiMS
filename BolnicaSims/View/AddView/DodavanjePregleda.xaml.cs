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
      

        public DodavanjePregleda()
        {
            InitializeComponent();
            comboBox1.ItemsSource = DoktoriStorage.Instance.doktoriImena;
          
        }



        private void dodavanjeBtn_Click(object sender, RoutedEventArgs e)
        {
            Termin tempTermin = new Termin();
            tempTermin.IdTermina = TerminService.Instance.GenID();
            tempTermin.VremeTermina= DateTime.Parse(txtBox1.Text);
      
           foreach(Doktor d in DoktoriStorage.Instance.doktori)
            {
                if((d.korisnik.Ime + " " + d.korisnik.Prezime) == comboBox1.SelectedItem)
                {
                    tempTermin.doktori.Add(d);
                    tempTermin.ImePrezimeDoktora = d.korisnik.Ime + " " + d.korisnik.Prezime;
                }
            }


            TerminStorage.Instance.Read().Add(tempTermin);
            TerminStorage.Instance.Save();

            ListaTermina.Instance.refreshListaTermina();
            

            this.Close();
            
            
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void RadioDoktor_Checked(object sender, RoutedEventArgs e)
        {
            comboBox1.IsEnabled = true;
            txtBox1.IsEnabled = false;
       
        }

        private void RadioDatum_Checked(object sender, RoutedEventArgs e)
        {
            comboBox1.IsEnabled = false;
            txtBox1.IsEnabled = true;
        }

    }
}
