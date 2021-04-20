﻿using Model;
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

namespace BolnicaSims.View.MainView
{
    /// <summary>
    /// Interaction logic for PregledKartona.xaml
    /// </summary>
    public partial class PregledKartona : Window
    {
        public PregledKartona()
        {
            InitializeComponent();
            labelIme.Content = PacijentiStorage.Instance.selektovanPacijent.korisnik.Ime;
            labelPrezime.Content = PacijentiStorage.Instance.selektovanPacijent.korisnik.Prezime;
            labelGod.Content = (DateTime.Today.Year - PacijentiStorage.Instance.selektovanPacijent.korisnik.DatumRodjenja.Year).ToString();
            labelPol.Content = "M";
            //textBox.Text = PacijentiStorage.Instance.selektovanPacijent.zdravstveniKarton.Anamneza;
            if (anam != "prazno") 
            {
                textBox.Text = anam;
            }
            else
            {
                textBox.Text = "Unesite anamnezu....";
            }
        }

        private void button_recept_Click(object sender, RoutedEventArgs e)
        {
            
        }

        public static string anam = "prazno";
        private void button_sacuvaj_Click(object sender, RoutedEventArgs e)
        {
            anam = textBox.Text; 
        }
    }
}