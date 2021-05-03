using BolnicaSims.Model;
using BolnicaSims.Storage;
using BolnicaSims.View.EditView;
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

namespace BolnicaSims.View.MainView
{
    /// <summary>
    /// Interaction logic for PregledLekovaDoktor.xaml
    /// </summary>
    public partial class PregledLekovaDoktor : Window
    {
        private static PregledLekovaDoktor instance = null;
        public static PregledLekovaDoktor Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PregledLekovaDoktor();
                }
                return instance;
            }
        }
        public PregledLekovaDoktor()
        {
            InitializeComponent();
            dataGridLekovi.ItemsSource = LekoviStorage.Instance.Read();
        }

        private void validacijaBtn_Click(object sender, RoutedEventArgs e)
        {
            var s = new ValidacijaLekova();
            s.Show();
        }

        private void button_Izmeni_Click(object sender, RoutedEventArgs e)
        {
            if (dataGridLekovi.SelectedItem is Lek)
            {
                LekoviStorage.Instance.selektovanLek = (Lek)dataGridLekovi.SelectedItem;
                var s = new IzmenaLeka();
                s.Show();
            }
            else
            {
                MessageBox.Show("Nije izabran lek za izmenu");
                return;
            }
        }
    }
}
