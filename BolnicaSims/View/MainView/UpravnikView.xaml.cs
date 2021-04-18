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
    /// Interaction logic for UpravnikView.xaml
    /// </summary>
    public partial class UpravnikView : Window
    {
        public UpravnikView()
        {
            InitializeComponent();
        }

        private void ManualColumnsPacijenti_Click(object sender, RoutedEventArgs e)
        {
            var s = new ListaProstorija();
            s.Show();
        }
    }

}
