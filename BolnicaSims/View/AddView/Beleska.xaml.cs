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
          
            if(selectedDate < 0)
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
    }
}
