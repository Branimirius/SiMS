﻿using BolnicaSims.Storage;
using BolnicaSims.View.AddView;
using BolnicaSims.View.DeleteView;
using BolnicaSims.View.EditView;
using BolnicaSims.View.TransferView;
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

namespace BolnicaSims
{
    /// <summary>
    /// Interaction logic for UpravnikView.xaml
    /// </summary>
    public partial class UpravnikView : Window
    {
        private static UpravnikView instance = null;
        public static UpravnikView Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UpravnikView();
                }
                return instance;
            }
        }
        //UpravnikMainView
        ObservableCollection<Inventar> filteredInventar = new ObservableCollection<Inventar>();
        public UpravnikView()
        {
            InitializeComponent();
           
            dataGridProstorije.ItemsSource = ProstorijeStorage.Instance.Read();
            dataGridOsoblje.ItemsSource = KorisniciStorage.Instance.zaposleni;
            dataGridInventar.ItemsSource = InventarStorage.Instance.Read();
            dataGridLekovi.ItemsSource = LekoviStorage.Instance.Read();
        }
       
       
       
        //prostorije
        private void DodajProstorija_Click(object sender, RoutedEventArgs e)
        {
            var s = new DodavanjeProstorije();
            s.Show();
        }

        private void UkloniProstorija_Click(object sender, RoutedEventArgs e)
        {
            ProstorijeStorage.Instance.selektovanaProstorija = (Prostorija)dataGridProstorije.SelectedItem;
            var s = new BrisanjeProstorija();
            s.Show();
        }
        private void DetaljiProstorija_Click(object sender, RoutedEventArgs e)
        {
            ProstorijeStorage.Instance.selektovanaProstorija = (Prostorija)dataGridProstorije.SelectedItem;
            var s = new IzmenaProstorije();
            s.Show();
        }
        private void RenoviranjeProstorija_Click(object sender, RoutedEventArgs e)
        {
            ProstorijeStorage.Instance.selektovanaProstorija = (Prostorija)dataGridProstorije.SelectedItem;
            var s = new RenoviranjeProstorije();
            s.Show();
        }
        private void IzvestajProstorija_Click(object sender, RoutedEventArgs e)
        {

        }
        //Osoblje
        private void DodajOsoblje_Click(object sender, RoutedEventArgs e)
        {
            var s = new DodavanjeOsoblja();
            s.Show();
        }
        private void UkloniOsoblje_Click(object sender, RoutedEventArgs e)
        {
            KorisniciStorage.Instance.selektovaniKorisnik = (Korisnik)dataGridOsoblje.SelectedItem;
            var s = new BrisanjeOsoblja();
            s.Show();
        }
        private void DetaljiOsoblje_Click(object sender, RoutedEventArgs e)
        {

        }
        private void TransferOsoblje_Click(object sender, RoutedEventArgs e)
        {

        }
        private void IzvestajOsoblje_Click(object sender, RoutedEventArgs e)
        {

        }
        //Inventar
        private void DodajInventar_Click(object sender, RoutedEventArgs e)
        {
            var s = new DodavanjeInventara();
            s.Show();
        }
        private void UkloniInventar_Click(object sender, RoutedEventArgs e)
        {

        }
        private void DetaljiInventar_Click(object sender, RoutedEventArgs e)
        {

        }
        private void TransferInventar_Click(object sender, RoutedEventArgs e)
        {
            InventarStorage.Instance.selektovaniInventar = (Inventar)dataGridInventar.SelectedItem;
            
            if (InventarStorage.Instance.selektovaniInventar == null)
            {
                MessageBox.Show("Nije izabran inventar za transfer");
            }
            else
            {                
                var s = new TransferInventar();
                s.Show();
            }
        }
        private void IzvestajInventar_Click(object sender, RoutedEventArgs e)
        {

        }
        //Lekovi
        private void DodajLekovi_Click(object sender, RoutedEventArgs e)
        {
            var s = new DodavanjeLekova();
            s.Show();
        }
        private void UkloniLekovi_Click(object sender, RoutedEventArgs e)
        {

        }
        private void DetaljiLekovi_Click(object sender, RoutedEventArgs e)
        {

        }
        private void TransferLekovi_Click(object sender, RoutedEventArgs e)
        {

        }
        private void IzvestajLekovi_Click(object sender, RoutedEventArgs e)
        {

        }
        

        private void ButtonOdjavi_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //CollectionViewSource.GetDefaultView(UpravnikView.Instance.dataGridProstorije.ItemsSource).
            filteredInventar.Clear();
            if (txtPretragaInventar.Equals(""))
            {
                filteredInventar = InventarStorage.Instance.Read();
            }
            else
            {
                foreach (Inventar inventar in InventarStorage.Instance.Read())
                {

                    if (inventar.Naziv.Contains(txtPretragaInventar.Text))
                    {
                        filteredInventar.Add(inventar);
                    }
                }
            }

            dataGridInventar.ItemsSource = filteredInventar;
            CollectionViewSource.GetDefaultView(dataGridProstorije.ItemsSource).Refresh();

        }

        private void txtPretragaProstorije_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtPretragaOsoblje_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtPretragaLekovi_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void checkStaticka_Checked(object sender, RoutedEventArgs e)
        {
            filteredInventar.Clear();
            if ((Boolean)checkDinamicka.IsChecked)
            {
                //filteredInventar = InventarStorage.Instance.Read();
                dataGridInventar.ItemsSource = InventarStorage.Instance.Read();
            }
            else
            {
                foreach (Inventar inventar in InventarStorage.Instance.Read())
                {

                    if (inventar.Staticki)
                    {
                        filteredInventar.Add(inventar);
                    }
                }
                dataGridInventar.ItemsSource = filteredInventar;
            }

            //dataGridInventar.ItemsSource = filteredInventar;
            CollectionViewSource.GetDefaultView(dataGridProstorije.ItemsSource).Refresh();

        }

        private void checkStaticka_Unchecked(object sender, RoutedEventArgs e)
        {
            filteredInventar.Clear();
            if (!(Boolean)checkDinamicka.IsChecked)
            {
                //filteredInventar = InventarStorage.Instance.Read();
                dataGridInventar.ItemsSource = InventarStorage.Instance.Read();
            }
            else
            {
                foreach (Inventar inventar in InventarStorage.Instance.Read())
                {

                    if (!inventar.Staticki)
                    {
                        filteredInventar.Add(inventar);
                    }
                }
                dataGridInventar.ItemsSource = filteredInventar;
            }

            //dataGridInventar.ItemsSource = filteredInventar;
            CollectionViewSource.GetDefaultView(dataGridProstorije.ItemsSource).Refresh();

        }

        private void checkDinamicka_Checked(object sender, RoutedEventArgs e)
        {
            filteredInventar.Clear();
            if ((Boolean)checkStaticka.IsChecked)
            {
                //filteredInventar = InventarStorage.Instance.Read();
                dataGridInventar.ItemsSource = InventarStorage.Instance.Read();
            }
            else
            {
                foreach (Inventar inventar in InventarStorage.Instance.Read())
                {

                    if (!inventar.Staticki)
                    {
                        filteredInventar.Add(inventar);
                    }
                }
                dataGridInventar.ItemsSource = filteredInventar;
            }

            //dataGridInventar.ItemsSource = filteredInventar;
            CollectionViewSource.GetDefaultView(dataGridProstorije.ItemsSource).Refresh();

        }

        private void checkDinamicka_Unchecked(object sender, RoutedEventArgs e)
        {
            filteredInventar.Clear();
            if (!(Boolean)checkStaticka.IsChecked)
            {
                //filteredInventar = InventarStorage.Instance.Read();
                dataGridInventar.ItemsSource = InventarStorage.Instance.Read();
            }
            else
            {
                foreach (Inventar inventar in InventarStorage.Instance.Read())
                {

                    if (inventar.Staticki)
                    {
                        filteredInventar.Add(inventar);
                    }
                }
                dataGridInventar.ItemsSource = filteredInventar;
            }

            //dataGridInventar.ItemsSource = filteredInventar;
            CollectionViewSource.GetDefaultView(dataGridProstorije.ItemsSource).Refresh();

        }
    }

}
