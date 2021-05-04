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
    /// Interaction logic for DodavanjeTerminaAdvanced.xaml
    /// </summary>
    public partial class DodavanjeTerminaAdvanced : Window
    {
        public DodavanjeTerminaAdvanced()
        {
            InitializeComponent();
            listDoktor.ItemsSource = DoktoriStorage.Instance.specijalisti;
            listProstorija.ItemsSource = ProstorijeStorage.Instance.Read();
            comboTip.ItemsSource = Enum.GetValues(typeof(TipTermina));
        }

        private void ButtonIzmeni_Click(object sender, RoutedEventArgs e)
        {
            TimeSpan vreme = new TimeSpan(int.Parse(txtSati.Text), int.Parse(txtMinuti.Text), 0);
            DateTime pocetak = (DateTime)datePocetak.SelectedDate + vreme;
            DateTime kraj = pocetak.AddMinutes(int.Parse(txtBox1.Text));
            TerminController.Instance.dodajTerminAdvanced(pocetak, kraj, (Doktor)listDoktor.SelectedItem, PacijentiStorage.Instance.selektovanPacijent, (Prostorija)listProstorija.SelectedItem, (TipTermina)comboTip.SelectedItem);
            this.Close();
        }

        private void odustaniBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void comboTip_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(comboTip.Text == "OPERACIJA")
            {
                listProstorija.ItemsSource = null;
                listProstorija.ItemsSource = ProstorijeStorage.Instance.ordinacije;
            }
            else if(comboTip.Text == "PREGLED")
            {
                listProstorija.ItemsSource = null;
                listProstorija.ItemsSource = ProstorijeStorage.Instance.sale;
            }    
        }
    }
}
