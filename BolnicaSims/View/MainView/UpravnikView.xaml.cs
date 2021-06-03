using BolnicaSims.Controller;
using BolnicaSims.HelpView;
using BolnicaSims.Model;
using BolnicaSims.MVVM.HelpView;
using BolnicaSims.MVVM.Views;
using BolnicaSims.Storage;
using BolnicaSims.View.AddView;
using BolnicaSims.View.DeleteView;
using BolnicaSims.View.EditView;
using BolnicaSims.View.NotificationsView;
using BolnicaSims.View.SettingsView;
using BolnicaSims.View.TransferView;
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
    /// Interaction logic for UpravnikView.xaml
    /// </summary>
    public partial class UpravnikView : Window
    {
        private static UpravnikView instance = null;
        public static UpravnikView Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UpravnikView();
                }
                return instance;
            }
        }
        public String[] parametri = { "naziv", "proizvodjac", "kolicina" };
        //UpravnikMainView
        ObservableCollection<Inventar> filteredInventar = new ObservableCollection<Inventar>();
        public UpravnikView()
        {
            InitializeComponent();
           
            dataGridProstorije.ItemsSource = ProstorijaController.Instance.getProstorije();
            dataGridOsoblje.ItemsSource = KorisnikController.Instance.getZaposleni();
            dataGridInventar.ItemsSource = InventarController.Instance.getInventar();
            dataGridLekovi.ItemsSource = LekoviController.Instance.getLekovi();
            comboFilter.ItemsSource = ProstorijaController.Instance.getNazivi();
            comboPretraga.ItemsSource = parametri;
        }
       
       
       
        //prostorije
        private void DodajProstorija_Click(object sender, RoutedEventArgs e)
        {
            var s = new DodavanjeProstorije();
            s.Show();
        }

        private void UkloniProstorija_Click(object sender, RoutedEventArgs e)
        {
            //ProstorijeStorage.Instance.selektovanaProstorija = (Prostorija)dataGridProstorije.SelectedItem;
            ProstorijaController.Instance.setSelektovanaProstorija((Prostorija)dataGridProstorije.SelectedItem);
            if (ProstorijaController.Instance.getSelektovanaProstorija() != null)
            {
                var s = new BrisanjeProstorija();
                s.Show();
            }
            else
            {
                MessageBox.Show("Nije izabrana prostorija.");
            }
        }
        private void DetaljiProstorija_Click(object sender, RoutedEventArgs e)
        {
            //ProstorijeStorage.Instance.selektovanaProstorija = (Prostorija)dataGridProstorije.SelectedItem;
            ProstorijaController.Instance.setSelektovanaProstorija((Prostorija)dataGridProstorije.SelectedItem);
            if (ProstorijaController.Instance.getSelektovanaProstorija() != null)
            {
                var s = new IzmenaProstorije();
            s.Show();
            }
            else
            {
                MessageBox.Show("Nije izabrana prostorija.");
            }
        }
        private void RenoviranjeProstorija_Click(object sender, RoutedEventArgs e)
        {
            //ProstorijeStorage.Instance.selektovanaProstorija = (Prostorija)dataGridProstorije.SelectedItem;
            ProstorijaController.Instance.setSelektovanaProstorija((Prostorija)dataGridProstorije.SelectedItem);
            if (ProstorijaController.Instance.getSelektovanaProstorija() != null)
            {
                var s = new RenoviranjeProstorije();
                s.Show();
            }
            else
            {
                MessageBox.Show("Nije izabrana prostorija.");
            }
        }
        private void IzvestajProstorija_Click(object sender, RoutedEventArgs e)
        {

        }
        //Osoblje
        private void DodajOsoblje_Click(object sender, RoutedEventArgs e)
        {
            var s = new DodavanjeOsoblja();
            s.Show();
        }
        private void UkloniOsoblje_Click(object sender, RoutedEventArgs e)
        {
            //KorisniciStorage.Instance.selektovaniKorisnik = (Korisnik)dataGridOsoblje.SelectedItem;
            KorisnikController.Instance.setSelektovaniKorisnik((Korisnik)dataGridOsoblje.SelectedItem);
            if (KorisnikController.Instance.getSelektovaniKorisnik() != null)
            {
                var s = new BrisanjeOsoblja();
                s.Show();
            }
            else
            {
                MessageBox.Show("Nije izabrana osoba.");
                return;
            }
        }
        private void DetaljiOsoblje_Click(object sender, RoutedEventArgs e)
        {
            if(dataGridOsoblje.SelectedItem == null)
            {
                MessageBox.Show("Nije izabrana osoba.");
                return;
            }
            //KorisniciStorage.Instance.selektovaniKorisnik = (Korisnik)dataGridOsoblje.SelectedItem;
            KorisnikController.Instance.setSelektovaniKorisnik((Korisnik)dataGridOsoblje.SelectedItem);
            if (KorisnikController.Instance.getSelektovaniKorisnik().Zvanje == "Doktor")
            {
                DoktoriStorage.Instance.selektovaniDoktor = DoktorController.Instance.GetDoktor(KorisniciStorage.Instance.selektovaniKorisnik);
                DoktorController.Instance.setSelektovaniDoktor(DoktorController.Instance.GetDoktor(KorisniciStorage.Instance.selektovaniKorisnik));
                var s = new IzmenaDoktora();
                s.Show();
            }
            else
            {
                return;
            }
        }
        private void TransferOsoblje_Click(object sender, RoutedEventArgs e)
        {

        }
        private void IzvestajOsoblje_Click(object sender, RoutedEventArgs e)
        {

        }
        //Inventar
        private void DodajInventar_Click(object sender, RoutedEventArgs e)
        {
            var s = new DodavanjeInventara();
            s.Show();
        }
        private void UkloniInventar_Click(object sender, RoutedEventArgs e)
        {
            InventarController.Instance.setSelektovaniInventar((Inventar)dataGridInventar.SelectedItem);
            var s = new BrisanjeInventara();
            s.ShowDialog();
        }
        private void DetaljiInventar_Click(object sender, RoutedEventArgs e)
        {

        }
        private void TransferInventar_Click(object sender, RoutedEventArgs e)
        {
            //InventarStorage.Instance.selektovaniInventar = (Inventar)dataGridInventar.SelectedItem;
            InventarController.Instance.setSelektovaniInventar((Inventar)dataGridInventar.SelectedItem);
            
            if (InventarController.Instance.getSelektovaniInventar() == null)
            {
                MessageBox.Show("Nije izabran inventar za transfer");
            }
            else
            {                
                var s = new TransferInventar();
                s.Show();
            }
        }
        private void IzvestajInventar_Click(object sender, RoutedEventArgs e)
        {

        }
        //Lekovi
        private void DodajLekovi_Click(object sender, RoutedEventArgs e)
        {
            var s = new DodavanjeLekova();
            s.Show();
        }
        private void UkloniLekovi_Click(object sender, RoutedEventArgs e)
        {
            //LekoviStorage.Instance.selektovanLek = (Lek)dataGridLekovi.SelectedItem;
            LekoviController.Instance.setSelektovanLek((Lek)dataGridLekovi.SelectedItem);
            if (LekoviController.Instance.getSelektovanLek() == null)
            {
                MessageBox.Show("Nije izabran lek.");
            }
            else
            {

                var s = new BrisanjeLeka();
                s.Show();
            }
        }
        private void DetaljiLekovi_Click(object sender, RoutedEventArgs e)
        {            
            //LekoviStorage.Instance.selektovanLek = (Lek)dataGridLekovi.SelectedItem;
            LekoviController.Instance.setSelektovanLek((Lek)dataGridLekovi.SelectedItem);
            if (LekoviController.Instance.getSelektovanLek() == null)
            {
                MessageBox.Show("Nije izabran lek.");
            }
            else
            {
                var s = new IzmenaLekaUpravnik();
                s.Show();
            }
        }
        private void TransferLekovi_Click(object sender, RoutedEventArgs e)
        {

        }
        private void IzvestajLekovi_Click(object sender, RoutedEventArgs e)
        {
            var s = new IzvestajUpravnikView();
            s.ShowDialog();
        }
        

        private void ButtonOdjavi_Click(object sender, RoutedEventArgs e)
        {
            var s = new MainWindow();
            s.Show();
            Close();

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //CollectionViewSource.GetDefaultView(UpravnikView.Instance.dataGridProstorije.ItemsSource).
            switch ((String)comboPretraga.SelectedItem)
            {
                case "naziv":
                    PretragaNaziv();
                    break;
                case "proizvodjac":
                    PretragaProizvodjac();
                    break;
                case "kolicina":
                    PretragaKolicina();
                    break;
                default:
                    PretragaNaziv();
                    break;

            }
            

        }

        private void txtPretragaProstorije_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtPretragaOsoblje_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtPretragaLekovi_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void checkStaticka_Checked(object sender, RoutedEventArgs e)
        {
            
            filteredInventar.Clear();
            if ((Boolean)checkDinamicka.IsChecked)
            {
                //filteredInventar = InventarStorage.Instance.Read();
                dataGridInventar.ItemsSource = InventarController.Instance.getInventar();
            }
            else
            {
                foreach (Inventar inventar in InventarController.Instance.getInventar())
                {

                    if (inventar.Staticki)
                    {
                        filteredInventar.Add(inventar);
                    }
                }
                dataGridInventar.ItemsSource = filteredInventar;
            }

            //dataGridInventar.ItemsSource = filteredInventar;
            CollectionViewSource.GetDefaultView(dataGridProstorije.ItemsSource).Refresh();

        }

        private void checkStaticka_Unchecked(object sender, RoutedEventArgs e)
        {
            
            filteredInventar.Clear();
            if (!(Boolean)checkDinamicka.IsChecked)
            {
                //filteredInventar = InventarStorage.Instance.Read();
                dataGridInventar.ItemsSource = InventarController.Instance.getInventar();
            }
            else
            {
                foreach (Inventar inventar in InventarController.Instance.getInventar())
                {

                    if (!inventar.Staticki)
                    {
                        filteredInventar.Add(inventar);
                    }
                }
                dataGridInventar.ItemsSource = filteredInventar;
            }

            //dataGridInventar.ItemsSource = filteredInventar;
            CollectionViewSource.GetDefaultView(dataGridProstorije.ItemsSource).Refresh();

        }

        private void checkDinamicka_Checked(object sender, RoutedEventArgs e)
        {
            
            filteredInventar.Clear();
            if ((Boolean)checkStaticka.IsChecked)
            {
                //filteredInventar = InventarStorage.Instance.Read();
                dataGridInventar.ItemsSource = InventarController.Instance.getInventar();
            }
            else
            {
                foreach (Inventar inventar in InventarController.Instance.getInventar())
                {

                    if (!inventar.Staticki)
                    {
                        filteredInventar.Add(inventar);
                    }
                }
                dataGridInventar.ItemsSource = filteredInventar;
            }

            //dataGridInventar.ItemsSource = filteredInventar;
            CollectionViewSource.GetDefaultView(dataGridProstorije.ItemsSource).Refresh();

        }

        private void checkDinamicka_Unchecked(object sender, RoutedEventArgs e)
        {
            
            filteredInventar.Clear();
            if (!(Boolean)checkStaticka.IsChecked)
            {
                //filteredInventar = InventarStorage.Instance.Read();
                dataGridInventar.ItemsSource = InventarController.Instance.getInventar();
            }
            else
            {
                foreach (Inventar inventar in InventarController.Instance.getInventar())
                {

                    if (inventar.Staticki)
                    {
                        filteredInventar.Add(inventar);
                    }
                }
                dataGridInventar.ItemsSource = filteredInventar;
            }

            //dataGridInventar.ItemsSource = filteredInventar;
            CollectionViewSource.GetDefaultView(dataGridProstorije.ItemsSource).Refresh();

        }

        private void obavestenjaBtn_Click(object sender, RoutedEventArgs e)
        {
            var s = new NotifikacijeUpravnik();
            s.Show();
        }
        private void PretragaNaziv()
        {
            filteredInventar.Clear();
            if (txtPretragaInventar.Equals(""))
            {
                filteredInventar = InventarController.Instance.getInventar();
            }
            else
            {
                foreach (Inventar inventar in InventarController.Instance.getInventar())
                {

                    if (inventar.Naziv.Contains(txtPretragaInventar.Text))
                    {
                        filteredInventar.Add(inventar);
                    }
                }
            }

            dataGridInventar.ItemsSource = filteredInventar;
            CollectionViewSource.GetDefaultView(dataGridProstorije.ItemsSource).Refresh();

        }
        private void PretragaProizvodjac()
        {
            filteredInventar.Clear();
            if (txtPretragaInventar.Equals(""))
            {
                filteredInventar = InventarController.Instance.getInventar();
            }
            else
            {
                foreach (Inventar inventar in InventarController.Instance.getInventar())
                {

                    if (inventar.Proizvodjac.Contains(txtPretragaInventar.Text))
                    {
                        filteredInventar.Add(inventar);
                    }
                }
            }

            dataGridInventar.ItemsSource = filteredInventar;
            CollectionViewSource.GetDefaultView(dataGridProstorije.ItemsSource).Refresh();

        }
        private void PretragaKolicina()
        {
            filteredInventar.Clear();
            int parsedValue;
            if (txtPretragaInventar.Equals(""))
            {
                filteredInventar = InventarController.Instance.getInventar();
            }
            else
            {
                foreach (Inventar inventar in InventarController.Instance.getInventar())
                {
                    if(!int.TryParse(txtPretragaInventar.Text, out parsedValue))
                    {
                        MessageBox.Show("Dozvoljen je unos samo brojeva za kolicinu.");
                        return;
                    }
                    if (inventar.Kolicina <= parsedValue)
                    {
                        filteredInventar.Add(inventar);
                    }
                }
            }

            dataGridInventar.ItemsSource = filteredInventar;
            CollectionViewSource.GetDefaultView(dataGridProstorije.ItemsSource).Refresh();

        }

        private void comboFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            filteredInventar.Clear();
            /*
            if((Boolean)checkStaticka.IsChecked)
            {
                foreach (Inventar inventar in InventarStorage.Instance.Read())
                {

                    if (inventar.Staticki)
                    {
                        filteredInventar.Add(inventar);
                    }
                }
                //dataGridInventar.ItemsSource = filteredInventar;
            }
            else if ((Boolean)checkDinamicka.IsChecked)
            {
                foreach (Inventar inventar in InventarStorage.Instance.Read())
                {

                    if (!inventar.Staticki)
                    {
                        filteredInventar.Add(inventar);
                    }
                }
                //dataGridInventar.ItemsSource = filteredInventar;
            }
            else
            {
                filteredInventar = InventarStorage.Instance.Read();
            }
            */
            //filteredInventar.Clear();
            if (comboFilter.SelectedItem != null)
            {
                
                foreach (Inventar inventar in InventarController.Instance.getInventar())
                {
                    /* OVAJ KOD NE RADI NE ZNAM ZASTO, ALI NE KONTA PRVA DVA IF-A
                    if((Boolean)checkDinamicka.IsChecked && (!(Boolean)checkStaticka.IsChecked) && (inventar.prostorija.Naziv == (String)comboFilter.SelectedItem) && (!inventar.Staticki))
                    {
                        
                        filteredInventar.Add(inventar);
                        
                    }
                    else if ((!(Boolean)checkDinamicka.IsChecked) && (Boolean)checkStaticka.IsChecked && (inventar.prostorija.Naziv == (String)comboFilter.SelectedItem) && (inventar.Staticki))
                    {

                        filteredInventar.Add(inventar);

                    }*/
                    if (inventar.prostorija.Naziv == (String)comboFilter.SelectedItem)
                    {
                        filteredInventar.Add(inventar);
                    }
                }
                dataGridInventar.ItemsSource = filteredInventar;
            }
            else
            {
                dataGridInventar.ItemsSource = filteredInventar;
            }

            //dataGridInventar.ItemsSource = filteredInventar;
            CollectionViewSource.GetDefaultView(dataGridProstorije.ItemsSource).Refresh();

        }

        private void ponistiFilterBtn_Click(object sender, RoutedEventArgs e)
        {
            comboFilter.SelectedItem = null;
            
        }

        private void podesavanjaBtn_Click(object sender, RoutedEventArgs e)
        {
            var s = new PodesavanjaUpravnik();
            s.ShowDialog();
        }

        private void helpBtn_Click(object sender, RoutedEventArgs e)
        {
            //ContentArea.Content = new PomocMainView();
            var s = new PomocMainViewWin();
            s.ShowDialog();
        }
    }

}
