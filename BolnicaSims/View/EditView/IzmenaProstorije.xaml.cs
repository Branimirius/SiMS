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
        }

        private void buttonIzmena_Click(object sender, RoutedEventArgs e)
        {
            /*
            Prostorija tempProstorija = new Prostorija(TerminService.Instance.GenID(), txtBox2.Text, txtBox3.Text, txtBox4.Text, txtBox5.Text);
            ListaProstorija.Instance.izmeniProstoriju(tempProstorija, txtBox2.Text, txtBox3.Text, txtBox4.Text, txtBox5.Text);
            this.Close();
        */
        }
    }
}
