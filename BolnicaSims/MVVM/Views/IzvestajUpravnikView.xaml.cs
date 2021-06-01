using BolnicaSims.MVVM.HelpView;
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
    /// Interaction logic for IzvestajUpravnikView.xaml
    /// </summary>
    public partial class IzvestajUpravnikView : Window
    {
        public IzvestajUpravnikView()
        {
            InitializeComponent();
            Lekovi.ItemsSource = new IzvestajUpravnikViewModel().Lekovi;
            this.DataContext = new IzvestajUpravnikViewModel();
            txtDatumVreme.Text = DateTime.Now.ToString();
        }

        private void stampajBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.IsEnabled = false;
                PrintDialog printDialog = new PrintDialog();
                if(printDialog.ShowDialog() == true)
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
        private void helpBtn_Click(object sender, RoutedEventArgs e)
        {
            //ContentArea.Content = new PomocMainView();
            var s = new PomocMainViewWin();
            s.ShowDialog();
        }
    }
}
