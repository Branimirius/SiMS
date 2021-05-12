using BolnicaSims.Controller;
using BolnicaSims.DTO;
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
       
          
            
            KorisnikDTO tempKorisnik = new KorisnikDTO(txtBox4.Text, txtBox5.Text, txtBox1.Text, txtBox2.Text, "343434", new DateTime(2008, 04, 14), "afwfaw", "0983833", "vukureiu", "Pacijent");           
            PacijentController.Instance.dodajPacijenta(new PacijentDTO(tempKorisnik, txtBox3.Text, "1243", textBoxAlergija.Text, "", TipPola.M));
            KorisnikController.Instance.registrujKorisnika(new KorisnikDTO(txtBox4.Text, txtBox5.Text, txtBox1.Text, txtBox2.Text, "343434", new DateTime(2008, 04, 14), "afwfaw", "0983833", "vukureiu", "Pacijent"));
            this.Close();
        }

        public void odustaniBtn_Click(object sender, RoutedEventArgs e)
        {
           
            this.Close();
        }
    }
}
