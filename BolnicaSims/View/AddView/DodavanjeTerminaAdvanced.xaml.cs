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
    /// Interaction logic for DodavanjeTerminaAdvanced.xaml
    /// </summary>
    public partial class DodavanjeTerminaAdvanced : Window
    {
        public DodavanjeTerminaAdvanced()
        {
            InitializeComponent();
            listDoktor.ItemsSource = DoktoriStorage.Instance.specijalisti;
            //listProstorija.ItemsSource = ProstorijeStorage.Instance.Read();
            listProstorija.ItemsSource = ProstorijeStorage.Instance.sale;
            comboTip.ItemsSource = Enum.GetValues(typeof(TipTermina));
        }

        private void ButtonIzmeni_Click(object sender, RoutedEventArgs e)
        {

        }

        private void odustaniBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
