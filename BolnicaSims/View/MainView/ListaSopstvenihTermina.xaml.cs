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
    /// Interaction logic for ListaSopstvenihTermina.xaml
    /// </summary>
    public partial class ListaSopstvenihTermina : Window
    {
        private static ListaSopstvenihTermina instance = null;
        public static ListaSopstvenihTermina Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ListaSopstvenihTermina();
                }
                return instance;
            }
        }

        public ObservableCollection<Termin> termini = TerminStorage.Instance.Read();
        public ObservableCollection<Termin> dokTermini = new ObservableCollection<Termin>();
        public ListaSopstvenihTermina()
        {
            InitializeComponent();

            foreach(Termin t in termini)
            {
                if (t.ImePrezimeDoktora == "Petar Petrovic")
                {
                    dokTermini.Add(t);
                }    
            }
            
            dataGridSopstveniTermini.ItemsSource = dokTermini;
        }

        public void refreshListaSopstvenihTermina()
        {
            this.Close();
            this.InitializeComponent();
            dataGridSopstveniTermini.ItemsSource = null;
            dataGridSopstveniTermini.ItemsSource = termini;
            dataGridSopstveniTermini.Items.Refresh();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var s = new DodavanjePregleda();
            s.Show();
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            var s = new IzmenaPregleda();
            s.Show();
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Termin selektovan = (Termin)dataGridSopstveniTermini.SelectedItem;
            termini.Remove(selektovan);
            TerminStorage.Instance.Save();
        }
    }
}
