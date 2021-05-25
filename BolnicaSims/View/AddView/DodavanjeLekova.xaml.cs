using BolnicaSims.Controller;
using BolnicaSims.Storage;
using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    }
}
