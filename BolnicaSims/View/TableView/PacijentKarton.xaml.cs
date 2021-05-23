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

namespace BolnicaSims.View.TableView
{
    /// <summary>
    /// Interaction logic for PacijentKarton.xaml
    /// </summary>
    public partial class PacijentKarton : Window
    {
        public PacijentKarton()
        {
            InitializeComponent();
            labelIme.Content = PacijentService.Instance.getUlogovaniPacijent(KorisniciStorage.Instance.ulogovaniKorisnik).korisnik.Ime;
            labelPrezime.Content = PacijentService.Instance.getUlogovaniPacijent(KorisniciStorage.Instance.ulogovaniKorisnik).korisnik.Prezime;
            labelGod.Content = (DateTime.Today.Year - PacijentService.Instance.getUlogovaniPacijent(KorisniciStorage.Instance.ulogovaniKorisnik).korisnik.DatumRodjenja.Year).ToString();
            labelPol.Content = PacijentService.Instance.getUlogovaniPacijent(KorisniciStorage.Instance.ulogovaniKorisnik).zdravstveniKarton.getPol();
            labelAlergija.Content = PacijentService.Instance.getUlogovaniPacijent(KorisniciStorage.Instance.ulogovaniKorisnik).zdravstveniKarton.Alergije;
            labelAnamneza.Content = PacijentService.Instance.getUlogovaniPacijent(KorisniciStorage.Instance.ulogovaniKorisnik).zdravstveniKarton.Anamneza;
        

        }
    }
}
