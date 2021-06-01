using BolnicaSims.MVVM.ViewModel;
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
    /// Interaction logic for IzvestajPacijentView.xaml
    /// </summary>
    public partial class IzvestajPacijentView : Window
    {
        public IzvestajPacijentView()
        {
            InitializeComponent();
            Termini.ItemsSource = new IzvestajPacijentViewModel().Termini;
        }

        private void stampajBtn_Click(object sender, RoutedEventArgs e)
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

        private void nazadBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
