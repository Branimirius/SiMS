using BolnicaSims.Controller;
using BolnicaSims.Service;
using BolnicaSims.Storage;
using BolnicaSims.View.MainView;
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

           
            if (TerminController.Instance.proveraPomeranja(tempTermin, txtBox1.Text))
            {
                tempTermin.VremeTermina = DateTime.Parse(txtBox1.Text);
                TerminController.Instance.izmeniTermin(tempTermin);
            }
     
 
            switch (KorisniciStorage.Instance.ulogovaniKorisnik.Zvanje)
            {
                case "Pacijent":
                    CollectionViewSource.GetDefaultView(PacijentView.Instance.dataGridTermini.ItemsSource).Refresh();
                    break;
                case "Doktor":
                    CollectionViewSource.GetDefaultView(ListaTerminaDoktor.Instance.dataGridSopstveniTermini.ItemsSource).Refresh();
                    break;
                case "Sekretar":
                    CollectionViewSource.GetDefaultView(SekretarView.Instance.dataGridTermini.ItemsSource).Refresh();
                    break;
            }
            

            this.Close();
        }

     
    }

}
