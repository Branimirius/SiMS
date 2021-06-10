using BolnicaSims.Controller;
using BolnicaSims.Model;
using BolnicaSims.Storage;
using BolnicaSims.View.MainView;
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
    /// Interaction logic for IzmenaLeka.xaml
    /// </summary>
    public partial class IzmenaLeka : Window
    {
        public IzmenaLeka()
        {
            InitializeComponent();
            txtNaziv.Text = LekoviController.Instance.getSelektovanLek().ImeLeka;
            txtProizvodjac.Text = LekoviController.Instance.getSelektovanLek().Proizvodjac;
            txtDoza.Text = LekoviController.Instance.getSelektovanLek().Doza;
            txtAlergen.Text = LekoviController.Instance.getSelektovanLek().Alergija;
            txtKolicina.Text = LekoviController.Instance.getSelektovanLek().Kolicina.ToString();
            checkBox.IsChecked = LekoviController.Instance.getSelektovanLek().Verifikovan;
   
        }

        private void btnPotvrdi_Click(object sender, RoutedEventArgs e)
        {
            if (txtDoza.Text == "" || txtKolicina.Text == "" || txtNaziv.Text == "" || txtProizvodjac.Text == "")
            {
                MessageBox.Show("Unesite sve potrebne parametre");
            }
            else {
                LekoviController.Instance.izmeniLek(new Lek(txtNaziv.Text, txtProizvodjac.Text, txtDoza.Text, txtAlergen.Text, txtKolicina.Text, LekoviStorage.Instance.selektovanLek.IdLeka, (bool)checkBox.IsChecked));
                CollectionViewSource.GetDefaultView(ListaLekovaDoktor.Instance.dataGridLekovi.ItemsSource).Refresh();
                this.Close();
            }
        }

        private void btnOdustani_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
