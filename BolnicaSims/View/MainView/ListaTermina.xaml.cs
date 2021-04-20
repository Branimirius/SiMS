﻿using Model;
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
    /// Interaction logic for ListaTermina.xaml
    /// </summary>
    public partial class ListaTermina : Window
    {

        private static ListaTermina instance = null;
        public static ListaTermina Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ListaTermina();
                }
                return instance;
            }
        }


        public ListaTermina()
        {
            InitializeComponent();
            // this.DataContext = this;
           
            dataGridTermini.ItemsSource = TerminStorage.Instance.Read(); 
           

        }
        public void refreshListaTermina()
        {
            this.Close();
            this.InitializeComponent();
            dataGridTermini.ItemsSource = null;
            dataGridTermini.ItemsSource = TerminStorage.Instance.Read(); ;
            dataGridTermini.Items.Refresh();
        }

        private void ButtonZakazi_Click(object sender, RoutedEventArgs e)
        {
            var s = new DodavanjePregleda();
            s.Show();
        }
     
        private void ButtonIzmeni_Click(object sender, RoutedEventArgs e)
        {
           
            Termin selektovan = (Termin)dataGridTermini.SelectedItem;
            TerminStorage.Instance.selektovanTermin = selektovan;

            var s = new IzmenaPregleda();
            s.Show();
        }

        private void ButtonOtkazi_Click(object sender, RoutedEventArgs e)
        {
            Termin selektovan = (Termin)dataGridTermini.SelectedItem;
            TerminStorage.Instance.Read().Remove(selektovan);
            TerminStorage.Instance.Save();
        }
    }
}