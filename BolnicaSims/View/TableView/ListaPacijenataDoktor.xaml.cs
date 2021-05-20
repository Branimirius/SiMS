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
    /// Interaction logic for ListaPacijenataDoktor.xaml
    /// </summary>
    public partial class ListaPacijenataDoktor : Page
    {
        public ListaPacijenataDoktor()
        {
            InitializeComponent();
            dataGridPacijenti.ItemsSource = PacijentiStorage.Instance.Read();
            ShowsNavigationUI = false;
        }

        private void button_karton_Click(object sender, RoutedEventArgs e)
        {
            Pacijent selektovan = (Pacijent)dataGridPacijenti.SelectedItem;
            if (selektovan == null)
            {
                MessageBox.Show("niste izabrali pacijenta.");
                return;
            }

            PacijentiStorage.Instance.selektovanPacijent = selektovan;

            var s = new PregledKartona();
            s.Show();
        }
    }
}
