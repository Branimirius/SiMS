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
    /// Interaction logic for IzmenaPregleda.xaml
    /// </summary>
    public partial class IzmenaPregleda : Window
    {
        public IzmenaPregleda()
        {
            InitializeComponent();
            comboBox1.ItemsSource = DoktoriStorage.Instance.doktoriImena;
        }

        private void ButtonIzmeni_Click(object sender, RoutedEventArgs e)
        {
            Termin tempTermin = new Termin();
             
            tempTermin = TerminStorage.Instance.selektovanTermin;
            int i = 0;
            //int m = 0;
            //tempTermin.VremeTermina = DateTime.Parse(txtBox1.Text);

            foreach (Doktor d in DoktoriStorage.Instance.doktori)
            {
                //i++;
                if ((d.korisnik.Ime + " " + d.korisnik.Prezime) == ((String)comboBox1.SelectedItem))
                {
                    tempTermin.doktori.Add(d);
                    tempTermin.ImePrezimeDoktora = d.korisnik.Ime + " " + d.korisnik.Prezime;
                    i++;
                }
            }
            DoktoriStorage.Instance.Read()[i].AddTermin(tempTermin);
            DoktoriStorage.Instance.Save();

            TerminController.Instance.izmeniTermin(tempTermin, txtBox1.Text);
            ListaTermina.Instance.dataGridTermini.Items.Refresh();
            
            this.Close();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }

}
