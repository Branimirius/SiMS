﻿using BolnicaSims.Controller;
using BolnicaSims.MVVM.HelpView;
using BolnicaSims.Service;
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
    /// Interaction logic for IzmenaProstorije.xaml
    /// </summary>
    public partial class IzmenaProstorije : Window
    {
        public IzmenaProstorije()
        {
            InitializeComponent();
            prostorijaInventarDataGrid.ItemsSource = ProstorijaController.Instance.getSelektovanaProstorija().inventar;
            comboTip.ItemsSource = Enum.GetValues(typeof(TipProstorije));

        }

        private void buttonIzmena_Click(object sender, RoutedEventArgs e)
        {
           
            if (!valid())
            {
                return;
            }
            if (comboTip.SelectedItem == null)
            {
                MessageBox.Show("nije izabran tip");
                return;
            }
            else
            {
                ProstorijaController.Instance.izmeniProstoriju((TipProstorije)comboTip.SelectedItem, txtBox2.Text, txtBox1.Text);
                CollectionViewSource.GetDefaultView(UpravnikView.Instance.dataGridProstorije.ItemsSource).Refresh();
                this.Close();
            }
            
        
        }

        private void radioIzmeni_Checked(object sender, RoutedEventArgs e)
        {
            txtBox1.IsEnabled = true;
            txtBox2.IsEnabled = true;
            btnIzmeni.IsEnabled = true;
        }

        

        private void checkIzmeni_Checked(object sender, RoutedEventArgs e)
        {
            txtBox1.IsEnabled = true;
            txtBox2.IsEnabled = true;
            btnIzmeni.IsEnabled = true;
        }

        private void checkIzmeni_Unchecked(object sender, RoutedEventArgs e)
        {
            txtBox1.IsEnabled = false;
            txtBox2.IsEnabled = false;
            btnIzmeni.IsEnabled = false;
        }
        private void helpBtn_Click(object sender, RoutedEventArgs e)
        {
            //ContentArea.Content = new PomocMainView();
            var s = new PomocMainViewWin();
            s.ShowDialog();
        }
        private bool valid()
        {

            
            int parsedValue;
            if (!int.TryParse(txtBox1.Text, out parsedValue))
            {
                MessageBox.Show("U polju za broj su dozvoljene samo cifre");
                return false;
            }
            if (!int.TryParse(txtBox2.Text, out parsedValue))
            {
                MessageBox.Show("U polju za sprat su dozvoljene samo cifre");
                return false;
            }
            return true;
        }
    }
}
