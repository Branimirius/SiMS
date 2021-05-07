using BolnicaSims.Controller;
using BolnicaSims.Model;
using BolnicaSims.Storage;
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
    /// Interaction logic for IzmenaLekaUpravnik.xaml
    /// </summary>
    public partial class IzmenaLekaUpravnik : Window
    {
        public IzmenaLekaUpravnik()
        {
            InitializeComponent();
            listAlternative.ItemsSource = LekoviStorage.Instance.selektovanLek.Alternative;
            txtNaziv.Text = LekoviStorage.Instance.selektovanLek.ImeLeka;
            txtProizvodjac.Text = LekoviStorage.Instance.selektovanLek.Proizvodjac;
            txtDoza.Text = LekoviStorage.Instance.selektovanLek.Doza;
            txtAlergen.Text = LekoviStorage.Instance.selektovanLek.Alergija;
            txtKolicina.Text = LekoviStorage.Instance.selektovanLek.Kolicina.ToString();
            comboAlternative.ItemsSource = LekoviStorage.Instance.lekoviImena;
        }

        private void dodajAltBtn_Click(object sender, RoutedEventArgs e)
        {
            LekoviController.Instance.dodajAlternativu((String)comboAlternative.SelectedItem);
            
        }

        private void ukloniAltBtn_Click(object sender, RoutedEventArgs e)
        {
            LekoviController.Instance.ukloniAlternativu((Lek)listAlternative.SelectedItem);
        }

        private void izmeniBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void nazadBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
