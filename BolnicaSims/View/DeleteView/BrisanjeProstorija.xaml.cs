using BolnicaSims.Controller;
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

namespace BolnicaSims.View.DeleteView
{
    /// <summary>
    /// Interaction logic for BrisanjeProstorija.xaml
    /// </summary>
    public partial class BrisanjeProstorija : Window
    {
        public BrisanjeProstorija()
        {
            InitializeComponent();
            textBlock.Text = "Da li ste sigurni da zelite da uklonite\n prostoriju " + (ProstorijeStorage.Instance.selektovanaProstorija.BrojProstorije).ToString() + " iz evidencije?";
        }

        private void btnDa_Click(object sender, RoutedEventArgs e)
        {
            ProstorijaController.Instance.ukloniProstoriju(ProstorijeStorage.Instance.selektovanaProstorija);
            this.Close();
        }

        private void btnNe_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
