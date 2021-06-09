using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for ListaProstorija.xaml
    /// </summary>
    public partial class ListaProstorija : Window
    {
        private static ListaProstorija instance = null;
        public static ListaProstorija Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ListaProstorija();
                }
                return instance;
            }
        }

        public ObservableCollection<Prostorija> prostorije = ProstorijeStorage.Instance.prostorije;

        public ListaProstorija()
        {
            InitializeComponent();
            dataGridProstorije.ItemsSource = prostorije;
        }

        public void refreshListaProstorija()
        {
            this.Close();
            this.InitializeComponent();
            dataGridProstorije.ItemsSource = null;
            dataGridProstorije.ItemsSource = prostorije;
            dataGridProstorije.Items.Refresh();
        }

        private void buttonDodaj_Click(object sender, RoutedEventArgs e)
        {
            var s = new DodavanjeProstorije();
            s.Show();
        }
        private void buttonObrisi_Click(object sender, RoutedEventArgs e)
        {
            Prostorija selektovana = (Prostorija)dataGridProstorije.SelectedItem;
            prostorije.Remove(selektovana);
            ProstorijeStorage.Instance.Save();
        }
        private void buttonIzmeni_Click(object sender, RoutedEventArgs e)
        {
            var s = new IzmenaProstorije();
            s.Show();
        }

       /* public void izmeniProstoriju(Prostorija prostorija, String sprat, String broj, String Od, String Do)
        {
            for (int i = 0; i < prostorije.Count; i++)
            {

                if (prostorija.IdProstorije == prostorije[i].IdProstorije)

                {
                    if (prostorija.IdProstorije != "")
                    {
                        prostorije[i].IdProstorije = prostorija.IdProstorije;
                    }
                    if (sprat != "")
                    {
                        prostorije[i].Sprat = prostorija.Sprat;
                    }
                    if (broj != "")
                    {
                        prostorije[i].BrojProstorije = prostorija.BrojProstorije;
                    }
                    if (Od != "")
                    {
                        prostorije[i].RezervisanaOd = prostorija.RezervisanaOd;
                    }
                    if (Do != "")
                    {
                        prostorije[i].RezervisanaDo = prostorija.RezervisanaDo;
                    }
                }

            }
            ProstorijeStorage.Instance.Save();
            dataGridProstorije.Items.Refresh();


        }*/
    }
}
