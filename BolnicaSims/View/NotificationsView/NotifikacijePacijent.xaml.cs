﻿using BolnicaSims.Model;
using BolnicaSims.Storage;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for NotifikacijePacijent.xaml
    /// </summary>
    public partial class NotifikacijePacijent : Window
    {
        public ObservableCollection<Notifikacija> Notifikacije = KorisniciStorage.Instance.ulogovaniKorisnik.Notifikacije;
        public NotifikacijePacijent()
        {
            InitializeComponent();
            listBoxNotifikacije.ItemsSource = KorisniciStorage.Instance.ulogovaniKorisnik.Notifikacije;
        }

        private void listBoxNotifikacije_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
