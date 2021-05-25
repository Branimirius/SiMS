using BolnicaSims.Model;
using BolnicaSims.Storage;
using BolnicaSims.View.MainView;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BolnicaSims.View.TableView
{
    /// <summary>
    /// Interaction logic for ListaBolnickihLecenja.xaml
    /// </summary>
    public partial class ListaBolnickihLecenja : Page
    {
        public ListaBolnickihLecenja()
        {
            InitializeComponent();
            dataGridLecenja.ItemsSource = LecenjaStorage.Instance.Read();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_karton_Click(object sender, RoutedEventArgs e)
        {
            Lecenje selektovan = (Lecenje)dataGridLecenja.SelectedItem;
            if (selektovan == null)
            {
                MessageBox.Show("niste izabrali termin (pacijenta).");
                return;
            }
            PacijentiStorage.Instance.selektovanPacijent = selektovan.Pacijent;

            var s = new PregledKartona();
            s.Show();
        }
    }
}
