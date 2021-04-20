using BolnicaSims.Controller;
using BolnicaSims.Service;
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

namespace BolnicaSims
{
    /// <summary>
    /// Interaction logic for IzmenaPacijenta.xaml
    /// </summary>
    public partial class IzmenaPacijenta : Window
    {
        public IzmenaPacijenta()
        {
            InitializeComponent();
            labelGod.Content = (DateTime.Today.Year - PacijentiStorage.Instance.selektovanPacijent.korisnik.DatumRodjenja.Year).ToString();
            labelPol.Content = PacijentiStorage.Instance.selektovanPacijent.zdravstveniKarton.getPol();
            txtBox1.Text = PacijentiStorage.Instance.selektovanPacijent.korisnik.Ime;
            txtBox2.Text = PacijentiStorage.Instance.selektovanPacijent.korisnik.Prezime;
            textBoxAlergija.Text = PacijentiStorage.Instance.selektovanPacijent.zdravstveniKarton.Alergije;

        }
        private void izmenaPacijentaBtn_Click(object sender, RoutedEventArgs e)
        {
            // Termin selected = (Termin)ListaTermina.Instance.dataGridTermini.SelectedItem;
            //txtBox1.Text = selected.VremeTermina.ToString();

            Pacijent selected = PacijentiStorage.Instance.selektovanPacijent;
            Pacijent tempPacijent = new Pacijent();
            Korisnik tempKorisnik = new Korisnik(txtBox4.Text, txtBox5.Text, txtBox1.Text, txtBox2.Text, "Pacijent", selected.korisnik.Jmbg, new DateTime(2008, 04, 14), "afwfaw", "0983833", "vukureiu");
            ZdravstveniKarton tempKarton = new ZdravstveniKarton(txtBox3.Text, selected.zdravstveniKarton.BrojKartona, "1243", "M","", textBoxAlergija.Text);
            tempPacijent.korisnik = tempKorisnik;
            tempPacijent.zdravstveniKarton = tempKarton;
            // ListaPacijenata.Instance.izmeniPacijenta(tempPacijent);
            PacijentController.Instance.izmeniPacijenta(tempPacijent, selected);
            //KorisnikController.Instance.izmeniKorisnika(tempKorisnik);
            SekretarView.Instance.dataGridPacijenti.Items.Refresh();
            this.Close();

        }
        private void odustaniBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
