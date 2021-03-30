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
    /// Interaction logic for PacijentView.xaml
    /// </summary>
    public partial class PacijentView : Window
    {
        public PacijentView()
        {
            InitializeComponent();
        }
        private void ManualColumns_Click(object sender, RoutedEventArgs e)
        {
            var s = new ListaTermina();
            s.Show();
        }
    }
}
