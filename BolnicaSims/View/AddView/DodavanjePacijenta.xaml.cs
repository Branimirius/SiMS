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
    /// Interaction logic for DodavanjePacijenta.xaml
    /// </summary>
    public partial class DodavanjePacijenta : Window
    {
        public DodavanjePacijenta()
        {
            InitializeComponent();
        }

        public void dodavanjePacijentaBtn_Click(object sender, RoutedEventArgs e)
        {
            Pacijent tempPacijent = new Pacijent();
            Korisnik tempKorisnik = new Korisnik(txtBox4.Text, txtBox5.Text, txtBox1.Text, txtBox2.Text, "Pacijent", "343434", new DateTime(2008, 04, 14), "afwfaw", "0983833", "vukureiu");
            ZdravstveniKarton tempKarton = new ZdravstveniKarton(txtBox3.Text, PacijentService.Instance.GenID(), "1243", "M", "",textBoxAlergija.Text);
            tempPacijent.korisnik = tempKorisnik;
            tempPacijent.zdravstveniKarton = tempKarton;
            PacijentController.Instance.dodajPacijenta(tempPacijent);
            KorisnikController.Instance.registrujKorisnika(tempKorisnik);
            this.Close();
        }

        public void odustaniBtn_Click(object sender, RoutedEventArgs e)
        {
           
            this.Close();
        }
    }
}
