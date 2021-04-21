using BolnicaSims.View.MainView;
using BolnicaSims.View.NotificationsView;
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
    /// Interaction logic for PacijentView.xaml
    /// </summary>
    public partial class PacijentView : Window
    {
        public PacijentView()
        {
            InitializeComponent();
        }

        public void ObavestenjeRecept(String pacijent, String doktor, String lek, DateTime kreni, String naSati, String kolikoPut)
        {
            DateTime trenutnoSati = DateTime.Now;
            DateTime vremeZaPodsetnik = trenutnoSati.AddHours(-2);

            if (kreni == vremeZaPodsetnik)
            {
                MessageBox.Show("Za 2 sata treba da popijete lek");
            }
        }
        private void ManualColumns_Click(object sender, RoutedEventArgs e)
        {
            
            var s = new ListaTermina();
            

            s.Show();
        }

        private void ManualColumns_Click2(object sender, RoutedEventArgs e)
        {
            var s = new ListaRecepata();
            s.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var s = new NotifikacijePacijent();
            s.Show();
        }
    }
}
