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
            txtNaziv.Text = LekoviStorage.Instance.selektovanLek.ImeLeka;
            txtProizvodjac.Text = LekoviStorage.Instance.selektovanLek.Proizvodjac;
            txtDoza.Text = LekoviStorage.Instance.selektovanLek.Doza;
            txtAlergen.Text = LekoviStorage.Instance.selektovanLek.Alergija;
            txtKolicina.Text = LekoviStorage.Instance.selektovanLek.Kolicina.ToString();
            CheckBox.IsChecked = LekoviStorage.Instance.selektovanLek.Verifikovan;
   
        }

        private void btnPotvrdi_Click(object sender, RoutedEventArgs e)
        {
            LekoviController.Instance.izmeniLek(new Lek(txtNaziv.Text, txtProizvodjac.Text, txtDoza.Text, txtAlergen.Text, txtKolicina.Text, LekoviStorage.Instance.selektovanLek.IdLeka, (bool)CheckBox.IsChecked));
            CollectionViewSource.GetDefaultView(PregledLekovaDoktor.Instance.dataGridLekovi.ItemsSource).Refresh();
            this.Close();
        }

        private void btnOdustani_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
