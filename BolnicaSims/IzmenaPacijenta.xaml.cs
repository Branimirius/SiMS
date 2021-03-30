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
        }
        private void izmenaPacijentaBtn_Click(object sender, RoutedEventArgs e)
        {
            // Termin selected = (Termin)ListaTermina.Instance.dataGridTermini.SelectedItem;
            //txtBox1.Text = selected.VremeTermina.ToString();

            Pacijent tempPacijent = new Pacijent();
            Korisnik tempKorisnik = new Korisnik(null, null, txtBox1.Text, txtBox2.Text, "343434", new DateTime(2008, 04, 14), "afwfaw", "0983833", "vukureiu");
            ZdravstveniKarton tempKarton = new ZdravstveniKarton(txtBox3.Text, txtBox4.Text, "1243", "M");
            tempPacijent.korisnik = tempKorisnik;
            tempPacijent.zdravstveniKarton = tempKarton;
            ListaPacijenata.Instance.izmeniPacijenta(tempPacijent);

            this.Close();

        }
    }
}
