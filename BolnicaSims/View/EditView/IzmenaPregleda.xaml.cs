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
        }

        private void ButtonIzmeni_Click(object sender, RoutedEventArgs e)
        {
            Termin tempTermin = new Termin();
             
            tempTermin = TerminStorage.Instance.selektovanTermin;
            DateTime stariTermin = tempTermin.VremeTermina;
            DateTime noviTermin = tempTermin.VremeTermina = DateTime.Parse(txtBox1.Text);
            DateTime noviTermin2 = tempTermin.VremeTermina = DateTime.Parse(txtBox1.Text);
            noviTermin = noviTermin.AddDays(2);
            noviTermin2 = noviTermin2.AddDays(-2);

            if (stariTermin > noviTermin || stariTermin < noviTermin2)
            {
                if (stariTermin > noviTermin)
                    MessageBox.Show("Datum ne sme biti pomeren vise od 2 dana unazad");
                if (stariTermin < noviTermin2)
                    MessageBox.Show("Datum ne sme biti pomeren za vise od 2 dana");
                return;
            }

            TerminController.Instance.izmeniTermin(tempTermin);
            //CollectionViewSource.GetDefaultView(PacijentView.Instance.dataGridProstorije.ItemsSource).Refresh();
            switch (KorisniciStorage.Instance.ulogovaniKorisnik.Zvanje)
            {
                case "Pacijent":
                    CollectionViewSource.GetDefaultView(ListaTermina.Instance.dataGridTermini.ItemsSource).Refresh();
                    break;
                case "Doktor":
                    CollectionViewSource.GetDefaultView(ListaSopstvenihTermina.Instance.dataGridSopstveniTermini.ItemsSource).Refresh();
                    break;
                case "Sekretar":
                    CollectionViewSource.GetDefaultView(SekretarView.Instance.dataGridTermini.ItemsSource).Refresh();
                    break;


            }

            //ListaTermina.Instance.dataGridTermini.Items.Refresh();
            //DoktoriStorage.Instance.Save();
            //PacijentiStorage.Instance.Save();
            //KorisniciStorage.Instance.Save();
            this.Close();
        }

     
    }

}
