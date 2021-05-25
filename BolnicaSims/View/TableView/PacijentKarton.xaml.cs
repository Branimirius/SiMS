using BolnicaSims.Controller;
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
            labelIme.Content = PacijentController.Instance.getUlogovaniPacijent().korisnik.Ime;
            labelPrezime.Content = PacijentController.Instance.getUlogovaniPacijent().korisnik.Prezime;
            labelGod.Content = (DateTime.Today.Year - PacijentController.Instance.getUlogovaniPacijent().korisnik.DatumRodjenja.Year).ToString();
            labelPol.Content = PacijentController.Instance.getUlogovaniPacijent().zdravstveniKarton.getPol();
            labelAlergija.Content = PacijentController.Instance.getUlogovaniPacijent().zdravstveniKarton.Alergije;
            labelAnamneza.Content = PacijentController.Instance.getUlogovaniPacijent().zdravstveniKarton.Anamneza;
        

        }
    }
}
