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

namespace BolnicaSims.View.AddView
{
    /// <summary>
    /// Interaction logic for DodavanjeBolnickogLecenja.xaml
    /// </summary>
    public partial class DodavanjeBolnickogLecenja : Window
    {
        public DodavanjeBolnickogLecenja()
        {
            InitializeComponent();
            comboBoxPacijenti.ItemsSource = PacijentiStorage.Instance.Read();
            comboBoxSobe.ItemsSource = ProstorijeStorage.Instance.ordinacije;
        }

        private void button_odustani_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button_dodaj_Click(object sender, RoutedEventArgs e)
        {
            LecenjeController.Instance.dodajLecenje((Pacijent)comboBoxPacijenti.SelectedItem, (Prostorija)comboBoxSobe.SelectedItem, (DateTime)datePocetak.SelectedDate, (DateTime)dateKraj.SelectedDate);
            this.Close();
        }
    }
}
