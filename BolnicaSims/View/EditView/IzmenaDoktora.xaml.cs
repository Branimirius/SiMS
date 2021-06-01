﻿using BolnicaSims.Controller;
using BolnicaSims.DTO;
using BolnicaSims.MVVM.HelpView;
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
            if(DoktoriStorage.Instance.selektovaniDoktor.korisnik.Adresa != null)
            {
                txtAdresa.Text = DoktorController.Instance.getSelektovaniDoktor().korisnik.Adresa;
            }
            
            txtEmail.Text = DoktorController.Instance.getSelektovaniDoktor().korisnik.Email;
            txtJmbg.Text = DoktorController.Instance.getSelektovaniDoktor().korisnik.Jmbg;
            txtName.Text = DoktorController.Instance.getSelektovaniDoktor().korisnik.Ime;
            txtPassword.Text = DoktorController.Instance.getSelektovaniDoktor().korisnik.Password;
            txtPrezime.Text = DoktorController.Instance.getSelektovaniDoktor().korisnik.Prezime;
            txtTelefon.Text = DoktorController.Instance.getSelektovaniDoktor().korisnik.KontaktTelefon;
            txtUsername.Text = DoktorController.Instance.getSelektovaniDoktor().korisnik.Username;
            textBoxSpec.Text = DoktorController.Instance.getSelektovaniDoktor().Specijalizacija;
            
        }

        private void btnPotvrdi_Click(object sender, RoutedEventArgs e)
        {
            
            KorisnikDTO tempKorisnik = new KorisnikDTO(txtUsername.Text, txtPassword.Text, txtName.Text, txtPrezime.Text, txtJmbg.Text, txtAdresa.Text, txtTelefon.Text, txtEmail.Text);
            DoktorController.Instance.izmeniDoktora(new DoktorDTO(tempKorisnik, textBoxSpec.Text));
            this.Close();
        }

        private void btnOdustani_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void helpBtn_Click(object sender, RoutedEventArgs e)
        {
            //ContentArea.Content = new PomocMainView();
            var s = new PomocMainViewWin();
            s.ShowDialog();
        }
    }
}
