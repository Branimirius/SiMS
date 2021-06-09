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
            listDoktor.ItemsSource = DoktorController.Instance.getSpecijalisti();
            listProstorija.ItemsSource = ProstorijaController.Instance.getProstorije();
            comboTip.ItemsSource = Enum.GetValues(typeof(TipTermina));
        }

        private void ButtonIzmeni_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)checkBox.IsChecked)
            {
                TerminController.Instance.dodajHitanTermin(PacijentiStorage.Instance.selektovanPacijent, comboTip.Text);
            }
            else
            {
                if(Int32.Parse(txtSati.Text) > 23 || Int32.Parse(txtMinuti.Text) >60)
                {
                    MessageBox.Show("Unesite validnu satnicu");
                }
                else if (txtSati.Text == "h" || txtMinuti.Text == "Min")
                {
                    MessageBox.Show("Unesite vreme pocetka termina");
                }
                else if (datePocetak.SelectedDate == null)
                {
                    MessageBox.Show("Izaberite datum termina");
                }
                else if (listDoktor.SelectedItem == null || listProstorija.SelectedItem == null)
                {
                    MessageBox.Show("Morate da izaberete doktora i prostoriju");
                }
                else
                {
                    TimeSpan vreme = new TimeSpan(int.Parse(txtSati.Text), int.Parse(txtMinuti.Text), 0);
                    DateTime pocetak = (DateTime)datePocetak.SelectedDate + vreme;
                    DateTime kraj = pocetak.AddMinutes(int.Parse(txtBox1.Text));
                    TerminController.Instance.dodajTerminAdvanced(pocetak, kraj, (Doktor)listDoktor.SelectedItem, PacijentiStorage.Instance.selektovanPacijent, (Prostorija)listProstorija.SelectedItem, (TipTermina)comboTip.SelectedItem);
                    this.Close();
                }
            }
            
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
                listProstorija.ItemsSource = ProstorijaController.Instance.getOrdinacije();
            }
            else if(comboTip.Text == "PREGLED")
            {
                listProstorija.ItemsSource = null;
                listProstorija.ItemsSource = ProstorijaController.Instance.getSale();
            }    
        }

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
