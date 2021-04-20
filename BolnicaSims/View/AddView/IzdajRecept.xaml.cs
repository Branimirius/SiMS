using BolnicaSims.Model;
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
            comboBox.ItemsSource = LekoviStorage.Instance.lekoviImena;
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
                Recept tempRecept = new Recept(labelPacijent.Content.ToString(), labelDoktor.Content.ToString(), comboBox.SelectedItem.ToString(), DateTime.Parse(textBox1.Text), textBox2.Text, textBox3.Text);
                ReceptiStorage.Instance.Read().Add(tempRecept);
                ReceptiStorage.Instance.Save();
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
