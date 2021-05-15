using BolnicaSims.Controller;
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
    /// Interaction logic for RenoviranjeProstorije.xaml
    /// </summary>
    public partial class RenoviranjeProstorije : Window
    {

        public RenoviranjeProstorije()
        {
            InitializeComponent();
            
            listRenoviranja.ItemsSource = ProstorijeStorage.Instance.selektovanaProstorija.renoviranja;
            txtBlock1.Text = ProstorijeStorage.Instance.selektovanaProstorija.Naziv;
            comboProstorija.ItemsSource = ProstorijaController.Instance.getSusedneProstorijeNazivi(ProstorijeStorage.Instance.selektovanaProstorija);
        }

        private void btnPotvrdi_Click(object sender, RoutedEventArgs e)
        {     
            DateTime pocetak = (DateTime)datePocetak.SelectedDate;
            TimeSpan vreme = new TimeSpan(int.Parse(txtSati.Text), int.Parse(txtMinuti.Text), 0);
            pocetak = pocetak.Add(vreme);
            DateTime krajRenoviranja = pocetak.AddDays(int.Parse(txtTrajanje.Text));
            if(!TerminController.Instance.slobodnaProstorija(pocetak, krajRenoviranja, ProstorijeStorage.Instance.selektovanaProstorija))
            {
                MessageBox.Show("Prostorija je zauzeta u izabrano vreme.");
                return;
            }
            if (checkSpajanje.IsChecked == true)
            {
                if (comboProstorija.SelectedItem == null)
                {
                    MessageBox.Show("Nije izabrana prostorija za spajanje.");
                    return;
                }
                RenoviranjeController.Instance.zakaziSpajanje(pocetak, int.Parse(txtTrajanje.Text),(String)comboProstorija.SelectedItem, ProstorijeStorage.Instance.selektovanaProstorija);


            }
            RenoviranjeController.Instance.zakaziRenoviranje(pocetak, int.Parse(txtTrajanje.Text), ProstorijeStorage.Instance.selektovanaProstorija);
            
            this.Close();
        }

        private void btnOdustani_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnOtkazi_Click(object sender, RoutedEventArgs e)
        {

        }

        private void checkSpajanje_Checked(object sender, RoutedEventArgs e)
        {
            comboProstorija.IsEnabled = true;
            checkDeljenje.IsChecked = false;
            checkDeljenje.IsEnabled = false;
        }

        private void checkSpajanje_Unchecked(object sender, RoutedEventArgs e)
        {
            comboProstorija.IsEnabled = false;
            comboProstorija.SelectedItem = null;
            checkDeljenje.IsEnabled = true;
        }

        private void checkDeljenje_Checked(object sender, RoutedEventArgs e)
        {
            comboProstorija.SelectedItem = null;
            comboProstorija.IsEnabled = false;           
            checkSpajanje.IsChecked = false;
            checkSpajanje.IsEnabled = false;
        }

        private void checkDeljenje_Unchecked(object sender, RoutedEventArgs e)
        {
            checkSpajanje.IsEnabled = true;
            checkSpajanje.IsChecked = false;

        }
    }
}
