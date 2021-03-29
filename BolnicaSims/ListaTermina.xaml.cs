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
            Termini.Add(new Termin() { IdTermina = "1", VremeTermina = new DateTime(2008, 3, 1, 7, 0, 0), ImePrezimeDoktora="Petar Petrovic" });
        }

        

    }
}
