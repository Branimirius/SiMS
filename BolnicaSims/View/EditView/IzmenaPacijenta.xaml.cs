using BolnicaSims.Controller;
using BolnicaSims.DTO;
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
            labelGod.Content = (DateTime.Today.Year - PacijentController.Instance.getSelektovanPacijent().korisnik.DatumRodjenja.Year).ToString();
            labelPol.Content = PacijentController.Instance.getSelektovanPacijent().zdravstveniKarton.getPol();
            txtBox1.Text = PacijentController.Instance.getSelektovanPacijent().korisnik.Ime;
            txtBox2.Text = PacijentController.Instance.getSelektovanPacijent().korisnik.Prezime;
            textBoxAlergija.Text = PacijentController.Instance.getSelektovanPacijent().zdravstveniKarton.Alergije;

        }
        private void izmenaPacijentaBtn_Click(object sender, RoutedEventArgs e)
        {
            KorisnikDTO dtoKorisnik = new KorisnikDTO(txtBox4.Text, txtBox5.Text, txtBox1.Text, txtBox2.Text, PacijentController.Instance.getSelektovanPacijent().korisnik.Jmbg, new DateTime(2008, 04, 14), "afwfaw", "0983833", "vukureiu", "Pacijent");
            PacijentDTO dtoPacijent = new PacijentDTO(dtoKorisnik, txtBox3.Text, PacijentController.Instance.getSelektovanPacijent().zdravstveniKarton.BrojZdravstveneKnjizice, PacijentController.Instance.getSelektovanPacijent().zdravstveniKarton.Anamneza, textBoxAlergija.Text, PacijentController.Instance.getSelektovanPacijent().zdravstveniKarton.Pol);           
            Pacijent tempPacijent = new Pacijent();
            Korisnik tempKorisnik = new Korisnik(txtBox4.Text, txtBox5.Text, txtBox1.Text, txtBox2.Text, "Pacijent", PacijentController.Instance.getSelektovanPacijent().korisnik.Jmbg, new DateTime(2008, 04, 14), "afwfaw", "0983833", "vukureiu");
            ZdravstveniKarton tempKarton = new ZdravstveniKarton(txtBox3.Text, PacijentController.Instance.getSelektovanPacijent().zdravstveniKarton.BrojKartona, "1243", "M","", textBoxAlergija.Text);
            tempPacijent.korisnik = tempKorisnik;
            tempPacijent.zdravstveniKarton = tempKarton;
            
            PacijentController.Instance.izmeniPacijenta(dtoPacijent, PacijentController.Instance.getSelektovanPacijent());
            
            CollectionViewSource.GetDefaultView(SekretarView.Instance.dataGridPacijenti.ItemsSource).Refresh();
            
            this.Close();

        }
        private void odustaniBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
