using BolnicaSims.Controller;
using BolnicaSims.MVVM.HelpView;
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
            ProstorijaController.Instance.dodajProstoriju((TipProstorije)comboTip.SelectedItem ,txtBox2.Text, txtBox1.Text);
            this.Close();
        }
        private void buttonOdustani_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            
        }
        private void helpBtn_Click(object sender, RoutedEventArgs e)
        {
            //ContentArea.Content = new PomocMainView();
            var s = new PomocMainViewWin();
            s.ShowDialog();
        }
    }
}
