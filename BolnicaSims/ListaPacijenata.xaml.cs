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
    /// Interaction logic for ListaPacijenata.xaml
    /// </summary>
    public partial class ListaPacijenata : Window
    {
        private static ListaPacijenata instance = null;
        public static ListaPacijenata Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ListaPacijenata();
                }
                return instance;
            }
        }

        public ObservableCollection<Pacijent> pacijenti = PacijentiStorage.Instance.Read();
        public ListaPacijenata()
        {
            InitializeComponent();
            dataGridPacijenti.ItemsSource = pacijenti;
        }

        private void ButtonUkloni_Click(object sender, RoutedEventArgs e)
        {
            Pacijent selektovan = (Pacijent)dataGridPacijenti.SelectedItem;
            pacijenti.Remove(selektovan);
            PacijentiStorage.Instance.Save();


        }
        private void ButtonDodaj_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
