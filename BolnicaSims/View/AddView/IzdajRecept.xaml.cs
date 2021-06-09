using BolnicaSims.Controller;
using BolnicaSims.Model;
using BolnicaSims.Service;
using BolnicaSims.Storage;
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
            comboBox.ItemsSource = LekoviController.Instance.getLekovi();
            //comboBox.DisplayMemberPath = "ImeLeka";
            labelDoktor.Content = KorisnikController.Instance.getUlogovaniKorisnik().Ime + ' ' + KorisnikController.Instance.getUlogovaniKorisnik().Prezime;
            labelPacijent.Content = PacijentController.Instance.getSelektovanPacijent().korisnik.Ime + ' ' + PacijentController.Instance.getSelektovanPacijent().korisnik.Prezime;
            textBox1.Text = DateTime.Now.AddDays(1).Date.ToString("dd/MM/yyyy");
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text=="")
            {
                MessageBox.Show("Unesite sve potrebne parametre");
            }
            else
            {
                if (comboBox.SelectedItem == null)
                {
                    MessageBox.Show("Izaberite lek");
                    return;
                }
                else
                {   if (((Lek)comboBox.SelectedItem).Alergija == PacijentiStorage.Instance.selektovanPacijent.zdravstveniKarton.Alergije)
                    {
                        MessageBox.Show(" Pacijent je alegican na izabrani lek. \n Alternative: " + LekoviController.Instance.getAlternative((Lek)comboBox.SelectedItem));
                    }
                    else
                    {
                        Recept tempRecept = new Recept(PacijentiStorage.Instance.selektovanPacijent, DoktorService.Instance.getKorisnikDoktor(KorisniciStorage.Instance.ulogovaniKorisnik), comboBox.SelectedItem.ToString(), DateTime.Parse(textBox1.Text), textBox2.Text, textBox3.Text); ;
                        ReceptiStorage.Instance.recepti.Add(tempRecept);
                        PacijentService.Instance.getPacijent(PacijentiStorage.Instance.selektovanPacijent).recepti.Add(tempRecept);
                        ReceptiStorage.Instance.Save();
                        PacijentiStorage.Instance.Save();
                        this.Close();
                        MessageBox.Show("Recept je izdat");
                    }
                }
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
