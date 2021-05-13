using BolnicaSims.Model;
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

namespace BolnicaSims.View.AddView
{
    /// <summary>
    /// Interaction logic for IzdajRecept.xaml
    /// </summary>
    public partial class IzdajRecept : Window
    {
        public IzdajRecept()
        {
            InitializeComponent();
            foreach(Lek l in LekoviStorage.Instance.lekovi)
            {
                if (l.Alergija == PacijentiStorage.Instance.selektovanPacijent.zdravstveniKarton.Alergije)
                {
                    LekoviStorage.Instance.lekoviAlergeni.Remove(l.ImeLeka + " " + l.Doza);
                }
            }    
            comboBox.ItemsSource = LekoviStorage.Instance.lekoviAlergeni;
            labelDoktor.Content = KorisniciStorage.Instance.ulogovaniKorisnik.Ime + ' ' + KorisniciStorage.Instance.ulogovaniKorisnik.Prezime;
            labelPacijent.Content = PacijentiStorage.Instance.selektovanPacijent.korisnik.Ime + ' ' + PacijentiStorage.Instance.selektovanPacijent.korisnik.Prezime;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Datum nije unet");
            }
            else
            {
                if(comboBox.SelectedItem == null)
                {
                    MessageBox.Show("Izaberite lek");
                    return;
                }
                Recept tempRecept = new Recept(PacijentiStorage.Instance.selektovanPacijent,DoktorService.Instance.getKorisnikDoktor(KorisniciStorage.Instance.ulogovaniKorisnik), comboBox.SelectedItem.ToString(), DateTime.Parse(textBox1.Text), textBox2.Text, textBox3.Text);
                ReceptiStorage.Instance.Read().Add(tempRecept);
                PacijentService.Instance.getPacijent(PacijentiStorage.Instance.selektovanPacijent).recepti.Add(tempRecept);
                ReceptiStorage.Instance.Save();
                PacijentiStorage.Instance.Save();
                this.Close();
                MessageBox.Show("Recept je izdat");
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
