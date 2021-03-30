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
    /// Interaction logic for DoktorView.xaml
    /// </summary>
    public partial class DoktorView : Window
    {
        public DoktorView()
        {
            InitializeComponent();
        }

        private void ManualColumns_Click(object sender, RoutedEventArgs e)
        {
            var s = new ListaSopstvenihTermina();
            s.Show();
        }
    }
}
