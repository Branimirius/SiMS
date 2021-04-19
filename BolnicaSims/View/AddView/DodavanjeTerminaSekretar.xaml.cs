using BolnicaSims.Controller;
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

namespace BolnicaSims.View.AddView
{
    /// <summary>
    /// Interaction logic for DodavanjeTerminaSekretar.xaml
    /// </summary>
    public partial class DodavanjeTerminaSekretar : Window
    {
        public DodavanjeTerminaSekretar()
        {
            InitializeComponent(); comboBox1.ItemsSource = DoktoriStorage.Instance.doktoriImena;
            comboBox2.ItemsSource = PacijentiStorage.Instance.pacijentiImena;
        }

        private void dodavanjeBtn_Click(object sender, RoutedEventArgs e)
        {

            TerminController.Instance.dodajTermin(txtBox1.Text, (String)comboBox1.SelectedItem, (String)comboBox2.SelectedItem);

            ListaTermina.Instance.refreshListaTermina();


            this.Close();


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Doktori_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Pacijenti_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
