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
        }

        private void btnPotvrdi_Click(object sender, RoutedEventArgs e)
        {     
            DateTime pocetak = (DateTime)datePocetak.SelectedDate;
            DateTime krajRenoviranja = pocetak.AddDays(int.Parse(txtTrajanje.Text));
            if(!TerminController.Instance.slobodnaProstorija(pocetak, krajRenoviranja, ProstorijeStorage.Instance.selektovanaProstorija))
            {
                MessageBox.Show("Prostorija je zauzeta u izabrano vreme.");
                return;
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
    }
}
