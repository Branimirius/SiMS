using BolnicaSims.Controller;
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

namespace BolnicaSims.View.AddView
{
    /// <summary>
    /// Interaction logic for DodavanjeTerminaSekretar.xaml
    /// </summary>
    public partial class DodavanjeTerminaSekretar : Window
    {
        public DodavanjeTerminaSekretar()
        {
            InitializeComponent();
            listDoktori.ItemsSource = DoktoriStorage.Instance.doktori;
            listPacijenti.ItemsSource = PacijentiStorage.Instance.pacijenti;
            listProstorija.ItemsSource = ProstorijeStorage.Instance.prostorije;
            comboTipTermina.ItemsSource = Enum.GetValues(typeof(TipTermina));

        }

        private void dodavanjeBtn_Click(object sender, RoutedEventArgs e)
        {
            if (listProstorija.SelectedItem == null || listDoktori.SelectedItem == null || listPacijenti.SelectedItem == null)
            {
                MessageBox.Show("Nisu selektovani svi parametri.");
                return;
            }
            if (dateTermin.SelectedDate == null || txtSati.Text == "" || txtMinuti.Text == "" || txtTrajanje.Text == "" || comboTipTermina.SelectedItem == null)
            {
                MessageBox.Show("Nisu upisani svi parametri.");
                return;
            }
            TimeSpan vreme = new TimeSpan(int.Parse(txtSati.Text), int.Parse(txtMinuti.Text), 0);
            DateTime pocetak = (DateTime)dateTermin.SelectedDate + vreme;
            DateTime kraj = pocetak.AddMinutes(int.Parse(txtTrajanje.Text));

            if (ProstorijaController.Instance.prostorijaRadovi(pocetak, kraj, (Prostorija)listProstorija.SelectedItem))
            {
                MessageBox.Show("Prostorija se renovira u izabranom terminu. ");
                return;
            }
            
            
            TerminController.Instance.dodajTerminAdvanced(pocetak, txtTrajanje.Text, (Doktor)listDoktori.SelectedItem, (Pacijent)listPacijenti.SelectedItem, (Prostorija)listProstorija.SelectedItem, (TipTermina)comboTipTermina.SelectedItem);

            //ListaTermina.Instance.refreshListaTermina();


            this.Close();


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Doktori_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Pacijenti_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
