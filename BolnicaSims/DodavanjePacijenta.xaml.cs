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
            Korisnik tempKorisnik = new Korisnik(null, null, txtBox1.Text, txtBox2.Text, "343434", new DateTime(2008, 04, 14), "afwfaw", "0983833", "vukureiu");
            ZdravstveniKarton tempKarton = new ZdravstveniKarton(txtBox3.Text, txtBox4.Text, "1243", "M");
            tempPacijent.korisnik = tempKorisnik;
            tempPacijent.zdravstveniKarton = tempKarton;


            // TerminStorage storage = new TerminStorage();
            PacijentiStorage.Instance.Read().Add(tempPacijent);
            PacijentiStorage.Instance.Save();

           // ListaPacijenata.Instance.refreshListaPacijenata();


            this.Close();
        }
    }
}
