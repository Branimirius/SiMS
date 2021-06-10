﻿using BolnicaSims.Controller;
using BolnicaSims.MVVM.HelpView;
using Model;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for RenoviranjeProstorije.xaml
    /// </summary>
    public partial class RenoviranjeProstorije : Window
    {

        public RenoviranjeProstorije()
        {
            InitializeComponent();
            
            listRenoviranja.ItemsSource = ProstorijaController.Instance.getSelektovanaProstorija().renoviranja;
            txtBlock1.Text = ProstorijaController.Instance.getSelektovanaProstorija().Naziv;
            //ProstorijaController.Instance.getProstorijaByNaziv(ProstorijeStorage.Instance.selektovanaProstorija.Naziv).susedneProstorije = ProstorijaController.Instance.getSusedneProstorijeNazivi(ProstorijeStorage.Instance.selektovanaProstorija);
            comboProstorija.ItemsSource = ProstorijaController.Instance.getSelektovanaProstorija().susedneProstorije; 
        }

        private void btnPotvrdi_Click(object sender, RoutedEventArgs e)
        {
            if (datePocetak.SelectedDate == null)
            {
                MessageBox.Show("Datum nije izabran.");
                return;
            }
            if (!valid())
            {
                return;
            }
            
            DateTime pocetak = (DateTime)datePocetak.SelectedDate;
            TimeSpan vreme = new TimeSpan(int.Parse(txtSati.Text), int.Parse(txtMinuti.Text), 0);
            pocetak = pocetak.Add(vreme);
            DateTime krajRenoviranja = pocetak.AddDays(int.Parse(txtTrajanje.Text));
            if(!TerminController.Instance.slobodnaProstorija(pocetak, krajRenoviranja, ProstorijeStorage.Instance.selektovanaProstorija))
            {
                MessageBox.Show("Prostorija je zauzeta u izabrano vreme.");
                return;
            }
            if (checkSpajanje.IsChecked == true)
            {
                if (comboProstorija.SelectedItem == null)
                {
                    MessageBox.Show("Nije izabrana prostorija za spajanje.");
                    return;
                }
                RenoviranjeController.Instance.zakaziSpajanje(pocetak, int.Parse(txtTrajanje.Text),(String)comboProstorija.SelectedItem, ProstorijeStorage.Instance.selektovanaProstorija);
            }
            if (checkDeljenje.IsChecked == true)
            {               
                RenoviranjeController.Instance.zakaziDeljenje(pocetak, int.Parse(txtTrajanje.Text), ProstorijeStorage.Instance.selektovanaProstorija);
            }
            RenoviranjeController.Instance.zakaziRenoviranje(pocetak, int.Parse(txtTrajanje.Text), ProstorijeStorage.Instance.selektovanaProstorija);
            
            this.Close();
        }

        private void btnOdustani_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnOtkazi_Click(object sender, RoutedEventArgs e)
        {

        }

        private void checkSpajanje_Checked(object sender, RoutedEventArgs e)
        {
            comboProstorija.IsEnabled = true;
            checkDeljenje.IsChecked = false;
            checkDeljenje.IsEnabled = false;
        }

        private void checkSpajanje_Unchecked(object sender, RoutedEventArgs e)
        {
            comboProstorija.IsEnabled = false;
            comboProstorija.SelectedItem = null;
            checkDeljenje.IsEnabled = true;
        }

        private void checkDeljenje_Checked(object sender, RoutedEventArgs e)
        {
            comboProstorija.SelectedItem = null;
            comboProstorija.IsEnabled = false;           
            checkSpajanje.IsChecked = false;
            checkSpajanje.IsEnabled = false;
        }

        private void checkDeljenje_Unchecked(object sender, RoutedEventArgs e)
        {
            checkSpajanje.IsEnabled = true;
            checkSpajanje.IsChecked = false;

        }
        private void helpBtn_Click(object sender, RoutedEventArgs e)
        {
            //ContentArea.Content = new PomocMainView();
            var s = new PomocMainViewWin();
            s.ShowDialog();
        }
        private bool valid()
        {
            DateTime datum = (DateTime)datePocetak.SelectedDate;
            DateTime juce = DateTime.Now.AddDays(-1);
            /*
            if(datum < juce)
            {
                MessageBox.Show("Ne sme se uneti datum iz proslosti");
                return false;
            }
            */
            
            int parsedValue;
            if (!int.TryParse(txtTrajanje.Text, out parsedValue))
            {
                MessageBox.Show("U polju za trajanje(dani) su dozvoljene samo cifre");
                return false;
            }
            if (!int.TryParse(txtSati.Text, out parsedValue))
            {
                MessageBox.Show("U polju za sate su dozvoljene samo cifre");
                return false;
            }
            if (!int.TryParse(txtMinuti.Text, out parsedValue))
            {
                MessageBox.Show("U polju za minute su dozvoljene samo cifre");
                return false;
            }
            if(int.Parse(txtSati.Text) > 24 || int.Parse(txtSati.Text) < 0)
            {
                MessageBox.Show("U polju za sate unos nije ispravan.");
                return false;
            }
            if (int.Parse(txtMinuti.Text) > 59 || int.Parse(txtMinuti.Text) < 0)
            {
                MessageBox.Show("U polju za minute unos nije ispravan.");
                return false;
            }

            return true;
        }
    }
}
