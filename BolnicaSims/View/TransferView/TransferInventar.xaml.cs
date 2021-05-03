using BolnicaSims.Controller;
using BolnicaSims.Service;
using BolnicaSims.Storage;
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
using System.Windows.Shapes;

namespace BolnicaSims.View.TransferView
{
    /// <summary>
    /// Interaction logic for TransferInventar.xaml
    /// </summary>
    public partial class TransferInventar : Window
    {
        public TransferInventar()
        {
            InitializeComponent();
            listOdrediste.ItemsSource = ProstorijeStorage.Instance.prostorije;
            txtInventar.Text = InventarStorage.Instance.selektovaniInventar.Naziv;
            txtProstorija.Text = InventarStorage.Instance.selektovaniInventar.prostorija.Naziv;
            txtKolicina.Text = InventarStorage.Instance.selektovaniInventar.Kolicina.ToString();
            if (!InventarStorage.Instance.selektovaniInventar.Staticki)
            {
                txtBoxVreme.IsEnabled = false;
                txtBoxVremeMinuti.IsEnabled = false;
                datumInventar.IsEnabled = false;
            }
            else
            {
                txtBoxVreme.IsEnabled = true;
                txtBoxVremeMinuti.IsEnabled = true;
                datumInventar.IsEnabled = true;
            }
        }

        private void btnPotvrdi_Click(object sender, RoutedEventArgs e)
        {
            if(datumInventar.IsEnabled)
            {
                if(datumInventar.SelectedDate == null || txtBoxVreme.Text == String.Empty)
                {
                    MessageBox.Show("Nisu uneti datum i vreme.");
                    return;
                }
                DateTime vreme = (DateTime)datumInventar.SelectedDate;
                TimeSpan ts = new TimeSpan(int.Parse(txtBoxVreme.Text), int.Parse(txtBoxVremeMinuti.Text), 0);
                DateTime vremeSati = vreme.Add(ts);
                if (!TerminController.Instance.slobodnaProstorija(vremeSati, vremeSati, (Prostorija)listOdrediste.SelectedItem))
                {
                    MessageBox.Show("Prostorija nije slobodna u izabrano vreme.");
                    return;
                }
                if (ProstorijaController.Instance.prostorijaRadovi(vremeSati, vremeSati, (Prostorija)listOdrediste.SelectedItem))
                {
                    MessageBox.Show("Prostorija se renovira u izabrano vreme.");
                    return;
                }
            }         
            
            if (int.Parse(txtBoxKolicina.Text) > InventarStorage.Instance.selektovaniInventar.Kolicina)
            {
                MessageBox.Show("Izabrana kolicina je prevelika.");
                return;
            }
            
            InventarController.Instance.transferujInventar(int.Parse(txtBoxKolicina.Text), (Prostorija)listOdrediste.SelectedItem);
            CollectionViewSource.GetDefaultView(UpravnikView.Instance.dataGridInventar.ItemsSource).Refresh();
            this.Close();
            
        }

        private void btnOdustani_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
