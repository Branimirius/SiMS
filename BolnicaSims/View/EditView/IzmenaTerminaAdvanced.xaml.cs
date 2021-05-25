using BolnicaSims.Controller;
using BolnicaSims.DTO;
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

namespace BolnicaSims.View.EditView
{
    /// <summary>
    /// Interaction logic for IzmenaTerminaAdvanced.xaml
    /// </summary>
    public partial class IzmenaTerminaAdvanced : Window
    {
        public IzmenaTerminaAdvanced()
        {
            InitializeComponent();
            listOdrediste.ItemsSource = ProstorijaController.Instance.getProstorije();
            datePocetak.SelectedDate = TerminController.Instance.getSelektovaniTermin().VremeTermina;
            txtSati.Text = TerminController.Instance.getSelektovaniTermin().VremeTermina.Hour.ToString();
            txtMinuti.Text = TerminController.Instance.getSelektovaniTermin().VremeTermina.Minute.ToString();
            comboTip.ItemsSource = Enum.GetValues(typeof(TipTermina));
        }

        private void ButtonIzmeni_Click(object sender, RoutedEventArgs e)
        {
            TerminDTO tempTermin = new TerminDTO(TerminController.Instance.getSelektovaniTermin());
            TimeSpan ts = new TimeSpan(int.Parse(txtSati.Text), int.Parse(txtMinuti.Text), 0);
            
            tempTermin.VremeTermina = (DateTime)datePocetak.SelectedDate;
            tempTermin.VremeTermina = tempTermin.VremeTermina.Add(ts);
            if (txtBox1.Text != String.Empty)
            {
                tempTermin.KrajTermina = tempTermin.VremeTermina.AddMinutes(int.Parse(txtBox1.Text));
            }
            if (listOdrediste.SelectedItem is Prostorija)
            {
                tempTermin.prostorija = (Prostorija)listOdrediste.SelectedItem;
            }
            if (comboTip.SelectedItem != null)
            {
                tempTermin.TipTermina = (TipTermina)comboTip.SelectedItem;
            }
            
            DateTime stariTermin = tempTermin.VremeTermina;
            DateTime noviTermin = tempTermin.VremeTermina.AddDays(2);
            DateTime noviTermin2 = tempTermin.VremeTermina.AddDays(-2);
            DateTime noviTermin3 = stariTermin.AddDays(-1);
            if (DateTime.Now > noviTermin3)
            {
                MessageBox.Show("Termin ne moze da se pomera 24h pre termina");
                return;
            }           

            if (stariTermin > noviTermin)
            {
                MessageBox.Show("Datum ne sme biti pomeren vise od 2 dana unazad");
                return;
            }
            if (stariTermin < noviTermin2)
            {
                MessageBox.Show("Datum ne sme biti pomeren za vise od 2 dana");
                return;
            }

            if(ProstorijaController.Instance.prostorijaRadovi(tempTermin.VremeTermina, tempTermin.KrajTermina, tempTermin.prostorija))
            {
                MessageBox.Show("Prostorija se renovira u izabranom terminu. ");
                return;
            }

            TerminController.Instance.izmeniTermin(tempTermin);
            //CollectionViewSource.GetDefaultView(PacijentView.Instance.dataGridProstorije.ItemsSource).Refresh();
            switch (KorisnikController.Instance.getUlogovaniKorisnik().Zvanje)
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

        private void odustaniBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
