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
    /// Interaction logic for UpravnikFeedback.xaml
    /// </summary>
    public partial class UpravnikFeedback : Window
    {
        public UpravnikFeedback()
        {
            InitializeComponent();
        }

        private void btnPosalji_Click(object sender, RoutedEventArgs e)
        {
            FeedbackController.Instance.dodajFeedback(txtPrimedbe.Text, txtBagovi.Text);
            this.Close();
        }

        private void btnNazad_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
