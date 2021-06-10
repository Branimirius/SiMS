using BolnicaSims.Controller;
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

namespace BolnicaSims.View.AddView
{
    /// <summary>
    /// Interaction logic for DodavanjeLekova.xaml
    /// </summary>
    public partial class DodavanjeLekova : Window
    {
        public ObservableCollection<Doktor> izabraniDoktori = new ObservableCollection<Doktor>();
        public DodavanjeLekova()
        {
            InitializeComponent();
            listSviDoktori.ItemsSource = DoktorController.Instance.getDoktori();
            listIzabraniDoktori.ItemsSource = izabraniDoktori;
        }

        private void btnPotvrdi_Click(object sender, RoutedEventArgs e)
        {
            if (!valid())
            {
                return;
            }
            LekoviController.Instance.dodajLek(txtNaziv.Text, txtProizvodjac.Text, txtDoza.Text, txtAlergen.Text, txtKolicina.Text, izabraniDoktori);
            izabraniDoktori.Clear();
            this.Close();
            
        }

        private void btnOdustani_Click(object sender, RoutedEventArgs e)
        {
            izabraniDoktori.Clear();
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
