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

namespace BolnicaSims
{
    /// <summary>
    /// Interaction logic for DodavanjeProstorije.xaml
    /// </summary>
    public partial class DodavanjeProstorije : Window
    {
        public DodavanjeProstorije()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Prostorija tempProstorija = new Prostorija();
            tempProstorija.IdProstorije = ProstorijeStorage.Instance.GenID();
            tempProstorija.Sprat = int.Parse(txtBox2.Text);
            tempProstorija.BrojProstorije = int.Parse(txtBox3.Text);
            tempProstorija.RezervisanaOd = DateTime.Parse(txtBox4.Text);
            tempProstorija.RezervisanaDo = DateTime.Parse(txtBox5.Text);
            ProstorijeStorage.Instance.Read().Add(tempProstorija);
            ProstorijeStorage.Instance.Save();

            ListaProstorija.Instance.refreshListaProstorija();

            this.Close();
        }
    }
}
