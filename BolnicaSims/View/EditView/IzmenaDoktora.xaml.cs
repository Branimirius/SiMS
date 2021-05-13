using BolnicaSims.Controller;
using BolnicaSims.Storage;
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

namespace BolnicaSims.View.EditView
{
    /// <summary>
    /// Interaction logic for IzmenaDoktora.xaml
    /// </summary>
    public partial class IzmenaDoktora : Window
    {
        public IzmenaDoktora()
        {
            InitializeComponent();
            txtAdresa.Text = DoktoriStorage.Instance.selektovaniDoktor.korisnik.Adresa;
            txtEmail.Text = DoktoriStorage.Instance.selektovaniDoktor.korisnik.Email;
            txtJmbg.Text = DoktoriStorage.Instance.selektovaniDoktor.korisnik.Jmbg;
            txtName.Text = DoktoriStorage.Instance.selektovaniDoktor.korisnik.Ime;
            txtPassword.Text = DoktoriStorage.Instance.selektovaniDoktor.korisnik.Password;
            txtPrezime.Text = DoktoriStorage.Instance.selektovaniDoktor.korisnik.Prezime;
            txtTelefon.Text = DoktoriStorage.Instance.selektovaniDoktor.korisnik.KontaktTelefon;
            txtUsername.Text = DoktoriStorage.Instance.selektovaniDoktor.korisnik.Username;
            textBoxSpec.Text = DoktoriStorage.Instance.selektovaniDoktor.Specijalizacija;
            
        }

        private void btnPotvrdi_Click(object sender, RoutedEventArgs e)
        {
            //TODO
           // DoktorController.Instance.izmeniDoktora
            this.Close();
        }

        private void btnOdustani_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
