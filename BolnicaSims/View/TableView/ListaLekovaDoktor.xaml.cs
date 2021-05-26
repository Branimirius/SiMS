using BolnicaSims.Controller;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BolnicaSims.View.MainView
{
    /// <summary>
    /// Interaction logic for ListaLekovaDoktor.xaml
    /// </summary>
    public partial class ListaLekovaDoktor : Page
    {
        private static ListaLekovaDoktor instance = null;
        public static ListaLekovaDoktor Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ListaLekovaDoktor();
                }
                return instance;
            }
        }

        public ListaLekovaDoktor()
        {
            InitializeComponent();
            dataGridLekovi.ItemsSource = LekoviStorage.Instance.Read();
            ShowsNavigationUI = false;
        }

        private void button_Izmeni_Click(object sender, RoutedEventArgs e)
        {
            if (dataGridLekovi.SelectedItem is Lek)
            {
                LekoviController.Instance.setSelektovanLek((Lek)dataGridLekovi.SelectedItem);
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
