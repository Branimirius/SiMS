﻿using BolnicaSims.Controller;
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

namespace BolnicaSims.View.DeleteView
{
    /// <summary>
    /// Interaction logic for BrisanjeLeka.xaml
    /// </summary>
    public partial class BrisanjeLeka : Window
    {
        public BrisanjeLeka()
        {
            InitializeComponent();
        }

        private void btnPotvrdi_Click(object sender, RoutedEventArgs e)
        {
            LekoviController.Instance.ukloniLek(LekoviStorage.Instance.selektovanLek);
        }

        private void btnOdustani_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }
    }
}
