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

namespace BolnicaSims.View.EditView
{
    /// <summary>
    /// Interaction logic for IzmenaBolnickogLecenja.xaml
    /// </summary>
    public partial class IzmenaBolnickogLecenja : Window
    {
        public IzmenaBolnickogLecenja()
        {
            InitializeComponent();
            comboBoxPacijenti.ItemsSource = PacijentiStorage.Instance.Read();
            comboBoxPacijenti.SelectedItem = PacijentiStorage.Instance.selektovanPacijent;
            comboBoxSobe.ItemsSource = ProstorijeStorage.Instance.ordinacije;
            comboBoxSobe.SelectedItem = ProstorijeStorage.Instance.selektovanaProstorija;
        }

        private void button_odustani_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
