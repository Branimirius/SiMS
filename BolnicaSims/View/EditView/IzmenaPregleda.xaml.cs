﻿using BolnicaSims.Controller;
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

namespace BolnicaSims
{
    /// <summary>
    /// Interaction logic for IzmenaPregleda.xaml
    /// </summary>
    public partial class IzmenaPregleda : Window
    {
        public IzmenaPregleda()
        {
            InitializeComponent();
        }

        private void ButtonIzmeni_Click(object sender, RoutedEventArgs e)
        {
            Termin tempTermin = new Termin();
             
            tempTermin = TerminStorage.Instance.selektovanTermin;
            DateTime stariTermin = tempTermin.VremeTermina;
            DateTime noviTermin = tempTermin.VremeTermina = DateTime.Parse(txtBox1.Text);
            DateTime noviTermin2 = tempTermin.VremeTermina = DateTime.Parse(txtBox1.Text);
            noviTermin = noviTermin.AddDays(2);
            noviTermin2 = noviTermin2.AddDays(-2);

            if (stariTermin > noviTermin || stariTermin < noviTermin2)
            {
                if (stariTermin > noviTermin)
                    MessageBox.Show("Datum ne sme biti pomeren vise od 2 dana unazad");
                if (stariTermin < noviTermin2)
                    MessageBox.Show("Datum ne sme biti pomeren za vise od 2 dana");
                return;
            }

            TerminController.Instance.izmeniTermin(tempTermin);
            ListaTermina.Instance.dataGridTermini.Items.Refresh();
            
            this.Close();
        }

     
    }

}