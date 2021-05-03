using BolnicaSims.Controller;
using BolnicaSims.Model;
using BolnicaSims.Storage;
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
    /// Interaction logic for ValidacijaLekova.xaml
    /// </summary>
    public partial class ValidacijaLekova : Window
    {
        public ValidacijaLekova()
        {
            InitializeComponent();
            listViewVerifikacija.ItemsSource = LekoviStorage.Instance.neverifikovaniLekovi;
        }

        private void verifikujBtn_Click(object sender, RoutedEventArgs e)
        {
            if (listViewVerifikacija.SelectedItem != null)
            {
                LekoviController.Instance.validacijaLeka((Lek)listViewVerifikacija.SelectedItem);
            }
            else
            {
                MessageBox.Show("Nije izabran lek iz liste.");
            }
        }

        private void zavrsiBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void odbiVerifikacijuBtn_Click(object sender, RoutedEventArgs e)
        {
            if (listViewVerifikacija.SelectedItem != null)
            {
                LekoviController.Instance.odbijanjeLeka((Lek)listViewVerifikacija.SelectedItem);
            }
            else
            {
                MessageBox.Show("Nije izabran lek iz liste.");
            }
        }
    }
}
