using BolnicaSims.Controller;
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

namespace BolnicaSims.View.Feedback
{
    /// <summary>
    /// Interaction logic for PacijentFeedback.xaml
    /// </summary>
    public partial class PacijentFeedback : Window
    {
        public PacijentFeedback()
        {
            InitializeComponent();
        }

        private void btnPosalji_Click(object sender, RoutedEventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(txtOcena.Text, out parsedValue))
            {
                MessageBox.Show("U polju za ocene su dozvoljene samo cifre");
                return;
            }
            FeedbackController.Instance.dodajFeedback(txtPrimedbe.Text, txtBagovi.Text, txtOcena.Text);
            this.Close();
        }

        private void btnNazad_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
