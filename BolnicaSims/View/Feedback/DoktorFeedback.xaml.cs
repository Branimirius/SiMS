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
    /// Interaction logic for DoktorFeedback.xaml
    /// </summary>
    public partial class DoktorFeedback : Window
    {
        public List<string> ocene = new List<string>{ "5", "6", "7", "8", "9", "10" };
        public DoktorFeedback()
        { 
            InitializeComponent();
            comboBox.ItemsSource = ocene;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            FeedbackController.Instance.dodajFeedback(textBoxPrimedbe.Text, textBoxBug.Text, (string)comboBox.SelectedItem);
            MessageBox.Show("Uspesno poslat feedback");
            this.Close();
        }

        private void buttonOdustani_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
