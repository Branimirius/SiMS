using BolnicaSims.Controller;
using BolnicaSims.View.AddView;
using BolnicaSims.View.EditView;
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

namespace BolnicaSims.View.MainView
{
    /// <summary>
    /// Interaction logic for PregledKartona.xaml
    /// </summary>
    public partial class PregledKartona : Window
    {
        public PregledKartona()
        {
            InitializeComponent();
            labelIme.Content = PacijentiStorage.Instance.selektovanPacijent.korisnik.Ime;
            labelPrezime.Content = PacijentiStorage.Instance.selektovanPacijent.korisnik.Prezime;
            labelGod.Content = (DateTime.Today.Year - PacijentiStorage.Instance.selektovanPacijent.korisnik.DatumRodjenja.Year).ToString();
            labelPol.Content = PacijentiStorage.Instance.selektovanPacijent.zdravstveniKarton.getPol();
            textBoxAlergija.Text = PacijentiStorage.Instance.selektovanPacijent.zdravstveniKarton.Alergije;
            textBox.Text = PacijentiStorage.Instance.selektovanPacijent.zdravstveniKarton.Anamneza;
            if (textBox.Text == String.Empty) 
            {
                textBox.Text = "Unesite anamnezu....";
            }
            
            //textBoxAlergija.Text = al;
        }

        private void button_recept_Click(object sender, RoutedEventArgs e)
        {
            var s = new IzdajRecept();
            s.Show();
        }

        private void button_sacuvaj_Click(object sender, RoutedEventArgs e)
        {
            PacijentController.Instance.izmeniAnamnezu(textBox.Text, textBoxAlergija.Text);
            MessageBox.Show("Anamneza je sacuvana");
            this.Close();

        }

        private void buttonUput_Click(object sender, RoutedEventArgs e)
        {
            var s = new DodavanjeTerminaAdvanced();
            s.Show();
        }

        private void buttonLecenje_Click(object sender, RoutedEventArgs e)
        {
            var s = new DodavanjeBolnickogLecenja();
            s.Show();
        }
    }
}
