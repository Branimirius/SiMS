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
    /// Interaction logic for DodavanjePregleda.xaml
    /// </summary>
    public partial class DodavanjePregleda : Window
    {
      

        public DodavanjePregleda()
        {
            InitializeComponent();
        }



        private void dodavanjeBtn_Click(object sender, RoutedEventArgs e)
        {
            Termin tempTermin = new Termin();
            tempTermin.VremeTermina= DateTime.Parse(txtBox1.Text);
            tempTermin.ImePrezimeDoktora = txtBox2.Text;


            TerminStorage storage = new TerminStorage();
            storage.Read().Add(tempTermin);
            storage.Save();

           
        }
    }
}
