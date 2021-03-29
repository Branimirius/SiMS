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
        public ObservableCollection<Termin> Termini
        {
            get;
            set;
        }
        public ListaTermina()
        {
            InitializeComponent();
            this.DataContext = this;
            
            Termini = new ObservableCollection<Termin>();
            Termini.Add(new Termin() { IdTermina = "1", VremeTermina = new DateTime(2021, 3, 1, 7, 0, 0), ImePrezimeDoktora="Petar Petrovic" });
            Termini.Add(new Termin() { IdTermina = "5", VremeTermina = new DateTime(2021, 3, 25, 9, 0, 0), ImePrezimeDoktora = "Petar Petrovic" });
            Termini.Add(new Termin() { IdTermina = "21", VremeTermina = new DateTime(2021, 4, 28, 11, 0, 0), ImePrezimeDoktora = "Nikola Nikolic" });

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
