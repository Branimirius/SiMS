﻿using BolnicaSims.Controller;
using BolnicaSims.Model;
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
    }
}
