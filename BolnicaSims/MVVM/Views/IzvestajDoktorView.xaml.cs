using BolnicaSims.MVVM.ViewModel;
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

namespace BolnicaSims.MVVM.Views
{
    /// <summary>
    /// Interaction logic for IzvestajDoktorView.xaml
    /// </summary>
    public partial class IzvestajDoktorView : Window
    {
        public IzvestajDoktorView()
        {
            InitializeComponent();
            dataGridRecepti.ItemsSource = new IzvestajDoktorViewModel().Recepti;
            textBlockAnamneza.Text = new IzvestajDoktorViewModel().Anamneza;
            textBlockImeLek.Text = KorisniciStorage.Instance.ulogovaniKorisnik.Ime;
            textBlockPreLek.Text = KorisniciStorage.Instance.ulogovaniKorisnik.Prezime;
            textBlockImePac.Text = PacijentiStorage.Instance.selektovanPacijent.korisnik.Ime;
            textBlockPrePac.Text = PacijentiStorage.Instance.selektovanPacijent.korisnik.Prezime;
        }
        

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.IsEnabled = false;
                PrintDialog printDialog = new PrintDialog();
                if (printDialog.ShowDialog() == true)
                {
                    printDialog.PrintVisual(print, "Invoice");
                }
            }
            finally
            {
                this.IsEnabled = true;
            }
        }
    }
}
