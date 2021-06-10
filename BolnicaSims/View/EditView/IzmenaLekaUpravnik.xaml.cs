using BolnicaSims.Controller;
using BolnicaSims.Model;
using BolnicaSims.MVVM.HelpView;
using BolnicaSims.Storage;
using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Text.RegularExpressions;
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
        public ObservableCollection<Doktor> izabraniDoktori = new ObservableCollection<Doktor>();
        public IzmenaLekaUpravnik()
        {
            InitializeComponent();
            listAlternative.ItemsSource = LekoviController.Instance.getSelektovanLek().Alternative;
            txtNaziv.Text = LekoviController.Instance.getSelektovanLek().ImeLeka;
            txtProizvodjac.Text = LekoviController.Instance.getSelektovanLek().Proizvodjac;
            txtDoza.Text = LekoviController.Instance.getSelektovanLek().Doza;
            txtAlergen.Text = LekoviController.Instance.getSelektovanLek().Alergija;
            txtKolicina.Text = LekoviController.Instance.getSelektovanLek().Kolicina.ToString();
            comboAlternative.ItemsSource = LekoviController.Instance.getLekoviImena();
            listSviDoktori.ItemsSource = DoktorController.Instance.getDoktori();
            listIzabraniDoktori.ItemsSource = izabraniDoktori;
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
            if (!valid())
            {
                return;
            }
            LekoviController.Instance.izmeniLek(LekoviController.Instance.getSelektovanLek());
            DoktorController.Instance.dodajLekValidacija(LekoviController.Instance.getSelektovanLek(), izabraniDoktori);
            this.Close();
        }

        private void nazadBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void listSviDoktori_Selected(object sender, RoutedEventArgs e)
        {
            izabraniDoktori.Add((Doktor)listSviDoktori.SelectedItem);
        }

        private void listIzabraniDoktori_Selected(object sender, RoutedEventArgs e)
        {
            izabraniDoktori.Remove((Doktor)listIzabraniDoktori.SelectedItem);
        }
        private void helpBtn_Click(object sender, RoutedEventArgs e)
        {
            //ContentArea.Content = new PomocMainView();
            var s = new PomocMainViewWin();
            s.ShowDialog();
        }
        private bool valid()
        {
            Regex regex = new Regex("^[a-zA-Z]+$");
            if (!regex.IsMatch(txtNaziv.Text))
            {
                MessageBox.Show("U polju za naziv su dozvoljena samo slova");
                return false;
            }
            if (!regex.IsMatch(txtAlergen.Text))
            {
                MessageBox.Show("U polju za alergen su dozvoljena samo slova");
                return false;
            }

            int parsedValue;
            if (!int.TryParse(txtKolicina.Text, out parsedValue))
            {
                MessageBox.Show("U polju za kolicinu su dozvoljene samo cifre");
                return false;
            }

            return true;
        }
    }
}
