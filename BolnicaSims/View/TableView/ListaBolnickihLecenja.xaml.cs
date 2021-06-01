using BolnicaSims.Controller;
using BolnicaSims.Model;
using BolnicaSims.Storage;
using BolnicaSims.View.AddView;
using BolnicaSims.View.EditView;
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
        private static ListaBolnickihLecenja instance = null;
        public static ListaBolnickihLecenja Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ListaBolnickihLecenja();
                }
                return instance;
            }
        }
        public ListaBolnickihLecenja()
        {
            InitializeComponent();
            dataGridLecenja.ItemsSource = LecenjaStorage.Instance.Read();
        }

        private void button_karton_Click(object sender, RoutedEventArgs e)
        {

            if ((Lecenje)dataGridLecenja.SelectedItem == null)
            {
                MessageBox.Show("niste izabrali lecenje (pacijenta).");
                return;
            }
            PacijentController.Instance.setSelectovaniPacijent((Lecenje)dataGridLecenja.SelectedItem);

            DoktorView.Instance.stavi_Karton();
        }

        private void button_dodaj_Click(object sender, RoutedEventArgs e)
        {
            var s = new DodavanjeBolnickogLecenja();
            s.Show();
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            if ((Lecenje)dataGridLecenja.SelectedItem == null)
            {
                MessageBox.Show("niste izabrali lecenje (pacijenta).");
                return;
            }

            PacijentController.Instance.setSelectovaniPacijent((Lecenje)dataGridLecenja.SelectedItem);
            LecenjeController.Instance.selektovanoLecenje = (Lecenje)dataGridLecenja.SelectedItem; 

            var s = new IzmenaBolnickogLecenja();
            s.Show();
        }
    }
}
