using BolnicaSims.Controller;
using BolnicaSims.DTO;
using BolnicaSims.Model;
using BolnicaSims.View.TableView;
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

namespace BolnicaSims.View.EditView
{
    /// <summary>
    /// Interaction logic for IzmenaBolnickogLecenja.xaml
    /// </summary>
    public partial class IzmenaBolnickogLecenja : Window
    {
        public IzmenaBolnickogLecenja()
        {
            InitializeComponent();
            textBlock.Text = PacijentiStorage.Instance.selektovanPacijent.korisnik.ImePrezime;
            comboBoxSobe.ItemsSource = ProstorijeStorage.Instance.ordinacije;
            comboBoxSobe.SelectedItem = LecenjeController.Instance.selektovanoLecenje.Prostorija;
            datePocetak.SelectedDate = LecenjeController.Instance.selektovanoLecenje.Pocetak;
            dateKraj.SelectedDate = LecenjeController.Instance.selektovanoLecenje.Kraj;
        }

        private void button_odustani_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button_izmeni_Click(object sender, RoutedEventArgs e)
        {
            Lecenje l = new Lecenje(PacijentiStorage.Instance.selektovanPacijent, (DateTime)datePocetak.SelectedDate, (DateTime)dateKraj.SelectedDate, (Prostorija)comboBoxSobe.SelectedItem);
            LecenjeController.Instance.izmeniLecenje(PacijentiStorage.Instance.selektovanPacijent, l);
            CollectionViewSource.GetDefaultView(ListaBolnickihLecenja.Instance.dataGridLecenja.ItemsSource).Refresh();
            this.Close();
        }
    }
}
