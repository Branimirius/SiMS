using BolnicaSims.Controller;
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
            prostorijaInventarDataGrid.ItemsSource = ProstorijeStorage.Instance.selektovanaProstorija.inventar;
            comboTip.ItemsSource = Enum.GetValues(typeof(TipProstorije));

        }

        private void buttonIzmena_Click(object sender, RoutedEventArgs e)
        {
            /*
            Prostorija tempProstorija = new Prostorija(TerminService.Instance.GenID(), txtBox2.Text, txtBox3.Text, txtBox4.Text, txtBox5.Text);
            ListaProstorija.Instance.izmeniProstoriju(tempProstorija, txtBox2.Text, txtBox3.Text, txtBox4.Text, txtBox5.Text);
            */
            if (comboTip.SelectedItem == null)
            {
                MessageBox.Show("nije izabran tip");
                return;
            }
            else
            {
                ProstorijaController.Instance.izmeniProstoriju((TipProstorije)comboTip.SelectedItem, txtBox2.Text, txtBox1.Text);
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
    }
}
