using BolnicaSims.Controller;
using BolnicaSims.Service;
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

namespace BolnicaSims.View.TransferView
{
    /// <summary>
    /// Interaction logic for TransferInventar.xaml
    /// </summary>
    public partial class TransferInventar : Window
    {
        public TransferInventar()
        {
            InitializeComponent();
            listOdrediste.ItemsSource = ProstorijeStorage.Instance.prostorije;
            txtInventar.Text = InventarStorage.Instance.selektovaniInventar.Naziv;
            txtProstorija.Text = InventarStorage.Instance.selektovaniInventar.prostorija.Naziv;
            txtKolicina.Text = InventarStorage.Instance.selektovaniInventar.Kolicina.ToString();
        }

        private void btnPotvrdi_Click(object sender, RoutedEventArgs e)
        {
            if (int.Parse(txtBoxKolicina.Text) > InventarStorage.Instance.selektovaniInventar.Kolicina)
            {
                MessageBox.Show("Izabrana kolicina je prevelika.");
            }
            else
            {
                InventarController.Instance.transferujInventar(int.Parse(txtBoxKolicina.Text), (Prostorija)listOdrediste.SelectedItem);
                this.Close();
            }
        }

        private void btnOdustani_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
