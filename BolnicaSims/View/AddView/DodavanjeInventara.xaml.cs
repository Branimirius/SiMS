using BolnicaSims.Controller;
using BolnicaSims.MVVM.HelpView;
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
    /// Interaction logic for DodavanjeInventara.xaml
    /// </summary>
    public partial class DodavanjeInventara : Window
    {
        public DodavanjeInventara()
        {
            InitializeComponent();
        }

        private void btnPotvrdi_Click(object sender, RoutedEventArgs e)
        {
            if (!valid())
            {
                return;
            }
            InventarController.Instance.dodajInventar(txtBox1.Text, txtBox2.Text, txtBox3.Text, (Boolean)checkStaticki.IsChecked);
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
            if (!regex.IsMatch(txtBox1.Text))
            {
                MessageBox.Show("U polju za naziv su dozvoljena samo slova");
                return false;
            }
            
            int parsedValue;
            if (!int.TryParse(txtBox3.Text, out parsedValue))
            {
                MessageBox.Show("U polju za kolicinu su dozvoljene samo cifre");
                return false;
            }

            return true;
        }
    }
}
