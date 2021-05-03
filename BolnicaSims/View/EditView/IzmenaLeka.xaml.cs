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
        }

        private void btnPotvrdi_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnOdustani_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
