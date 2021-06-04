using BolnicaSims.Controller;
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
    /// Interaction logic for Beleska.xaml
    /// </summary>
    public partial class Beleska : Window
    {
        public Beleska()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!valid())
            {
                return;
            }
            if (!valid2())
            {
                return;
            }
            isDateInThePast();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void isDateInThePast()
        {
            int selectedDate = DateTime.Compare((DateTime)datum.SelectedDate, DateTime.UtcNow.Date);

            if (selectedDate < 0)
            {
                MessageBox.Show("Ne moze se izabrati datum u proslosti!");
            }   
            else if(int.Parse(txtSati.Text) < DateTime.Now.Hour && (DateTime)datum.SelectedDate == DateTime.UtcNow.Date)
            {
                MessageBox.Show("Ne moze se izabrati datum u proslosti!");
            }
            else if (int.Parse(txtMinuti.Text) < DateTime.Now.Minute && (DateTime)datum.SelectedDate == DateTime.UtcNow.Date)
            {
                MessageBox.Show("Ne moze se izabrati datum u proslosti!");
            }
             else if (txtBeleska.Text == "")
            {
                MessageBox.Show("Beleska je prazna");
            }
            else
            {
                TimeSpan ts = new TimeSpan(int.Parse(txtSati.Text), int.Parse(txtMinuti.Text), 0);
                DateTime vreme = (DateTime)datum.SelectedDate;
                vreme = vreme.Add(ts);
                PacijentController.Instance.sacuvajBelesku(vreme, txtBeleska.Text);
            }
         
        }

        private bool valid()
        {
       
            int parsedValue;
  
            if (!int.TryParse(txtSati.Text, out parsedValue))
            {
                MessageBox.Show("U polju za unos ocene su dozvoljene samo cifre od 1 do 24");
                return false;
            }
            else if (int.Parse(txtSati.Text) > 24 || int.Parse(txtSati.Text) == 0)
            {
                MessageBox.Show("Mogu se uneti cifre samo od 1 do 24 za sate");
                return false;
            }
            else if(datum.SelectedDate == null)
            {
                MessageBox.Show("Nije izabran datum");
                return false;
            }
            return true;
        }
        private bool valid2()
        {

            int parsedValue;

            if (!int.TryParse(txtMinuti.Text, out parsedValue))
            {
                MessageBox.Show("U polju za unos ocene su dozvoljene samo cifre od 1 do 60");
                return false;
            }
            else if (int.Parse(txtSati.Text) > 60 || int.Parse(txtSati.Text) == 0)
            {
                MessageBox.Show("Mogu se uneti cifre samo od 1 do 60 za minute");
                return false;
            }
            return true;
        }
    }
}
