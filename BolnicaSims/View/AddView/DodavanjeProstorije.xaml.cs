using BolnicaSims.Controller;
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
    /// Interaction logic for DodavanjeProstorije.xaml
    /// </summary>
    public partial class DodavanjeProstorije : Window
    {
        public DodavanjeProstorije()
        {
            InitializeComponent();
            comboTip.ItemsSource = Enum.GetValues(typeof(TipProstorije));
        }

        private void buttonPotvrdi_Click(object sender, RoutedEventArgs e)
        {
            ProstorijaController.Instance.dodajProstoriju((TipProstorije)comboTip.SelectedItem ,txtBox1.Text, txtBox2.Text);
            this.Close();
        }
        private void buttonOdustani_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            
        }
    }
}
