using BolnicaSims.Controller;
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
    }
}
