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
    /// Interaction logic for IzmenaPregleda.xaml
    /// </summary>
    public partial class IzmenaPregleda : Window
    {
        public IzmenaPregleda()
        {
            InitializeComponent();
        }

        private void ButtonIzmeni_Click(object sender, RoutedEventArgs e)
        {
            Termin terminTemp = new Termin(txtBox3.Text, txtBox1.Text, txtBox2.Text);
            ListaTermina.Instance.izmeniPregled(terminTemp, txtBox1.Text);
            this.Close();
        }

    }

}
