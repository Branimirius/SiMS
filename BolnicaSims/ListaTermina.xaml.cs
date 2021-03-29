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
    /// Interaction logic for ListaTermina.xaml
    /// </summary>
    public partial class ListaTermina : Window
    {
        private int colNum = 0;
        //TerminStorage storage = new TerminStorage();
       
        public ListaTermina()
        {
            InitializeComponent();
            // this.DataContext = this;
            dataGridTermini.ItemsSource = TerminStorage.Instance.Load();
            

        }

        private void ButtonZakazi_Click(object sender, RoutedEventArgs e)
        {
            var s = new DodavanjePregleda();
            s.Show();
        }

        private void ButtonIzmeni_Click(object sender, RoutedEventArgs e)
        {
            var s = new IzmenaPregleda();
            s.Show();
        }

        private void ButtonOtkazi_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
