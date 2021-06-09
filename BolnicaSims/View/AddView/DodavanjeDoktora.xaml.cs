using BolnicaSims.Controller;
using BolnicaSims.MVVM.HelpView;
using BolnicaSims.Storage;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BolnicaSims.View.AddView
{
    /// <summary>
    /// Interaction logic for DodavanjeDoktora.xaml
    /// </summary>
    public partial class DodavanjeDoktora : Window
    {
        public DodavanjeDoktora()
        {
            InitializeComponent();
        }

        private void checkSpec_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void checkSpec_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void btnPotvrdi_Click(object sender, RoutedEventArgs e)
        {
            if (dateDoktor.SelectedDate == null)
            {
                MessageBox.Show("Nije izabran datum.");
                return;
            }
            if (!valid())
            {
                return;
            }          
            DoktorController.Instance.dodajDoktora(txtUsername.Text, txtPassword.Text, txtName.Text, txtPrezime.Text, txtJmbg.Text, txtAdresa.Text, txtTelefon.Text, (Boolean)checkSpec.IsChecked, (Boolean)checkHirurg.IsChecked, (DateTime)dateDoktor.SelectedDate, txtEmail.Text, textBoxSpec.Text);
            CollectionViewSource.GetDefaultView(UpravnikView.Instance.dataGridOsoblje.ItemsSource).Refresh();
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
        private bool valid()
        {
            Regex regex = new Regex("^[a-zA-Z]+$");
            Regex regexEmpty = new Regex("^[a-zA-Z]*$");
            Regex regexNum = new Regex("^[0-9]+$");
            if (txtUsername.Text.Equals(String.Empty))
            {
                MessageBox.Show("Popunite polje za username.");
                return false;
            }
            if (!regex.IsMatch(txtPrezime.Text))
            {
                MessageBox.Show("U polju za prezime su dozvoljena samo slova");
                return false;
            }
            if (!regex.IsMatch(txtName.Text))
            {
                MessageBox.Show("U polju za ime su dozvoljena samo slova");
                return false;
            }
            
            if (!regexNum.IsMatch(txtJmbg.Text))
            {
                MessageBox.Show("U polju za jmbg su dozvoljeni samo brojevi");
                return false;
            }
            if (!regexEmpty.IsMatch(textBoxSpec.Text))
            {
                MessageBox.Show("U polju za specijalizaciju su dozvoljena samo slova.");
                return false;
            }


            int parsedValue;
            
            
            if (!int.TryParse(txtTelefon.Text, out parsedValue))
            {
                MessageBox.Show("U polju za telefon su dozvoljeni samo brojevi");
                return false;
            }
            DateTime datum = (DateTime)dateDoktor.SelectedDate;
            if(datum.Year > 2004)
            {
                MessageBox.Show("Doktor mora biti punoletan");
                return false;
            }
            if(datum.Year < 1955)
            {
                MessageBox.Show("Doktor mora biti mladji da bi se zaposlio");
                return false;
            }
            if(txtJmbg.Text.Length < 13)
            {
                MessageBox.Show("Jmbg mora imati najmanje 13 cifara.");
                return false;
            }
            return true;
        }
    }
}
