using BolnicaSims.Controller;
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

namespace BolnicaSims.View.NotificationsView
{
    /// <summary>
    /// Interaction logic for OdbijanjeLekaKomentar.xaml
    /// </summary>
    public partial class OdbijanjeLekaKomentar : Window
    {
        public OdbijanjeLekaKomentar()
        {
            InitializeComponent();
        }

        private void okBtn_Click(object sender, RoutedEventArgs e)
        {
            
            LekoviController.Instance.odbijanjeLeka(LekoviStorage.Instance.selektovanLek, txtKomentar.Text);
            this.Close();
        }

        private void nazadBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
