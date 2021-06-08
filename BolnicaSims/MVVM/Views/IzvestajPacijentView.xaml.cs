using BolnicaSims.MVVM.Models;
using BolnicaSims.MVVM.ViewModel;
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

namespace BolnicaSims.MVVM.Views
{
    /// <summary>
    /// Interaction logic for IzvestajPacijentView.xaml
    /// </summary>
    public partial class IzvestajPacijentView : Window
    {
        public IzvestajPacijentView()
        {
            InitializeComponent();
            Termini.ItemsSource = new IzvestajPacijentViewModel().Termini;
        }

        private void stampajBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.IsEnabled = false;
                PrintDialog printDialog = new PrintDialog();
                if (printDialog.ShowDialog() == true)
                {
                    printDialog.PrintVisual(print, "Invoice");
                }
            }
            finally
            {
                this.IsEnabled = true;
            }
        }

        private void nazadBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void datumOd_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (datumDo.SelectedDate == null)
            {
                Termini.ItemsSource = getTerminiOd((DateTime)datumOd.SelectedDate);
            }
            else
            {
                if (!dateValid())
                {
                    return;
                }
                Termini.ItemsSource = getTermini((DateTime)datumOd.SelectedDate, (DateTime)datumDo.SelectedDate);
            }
        }

        private void datumDo_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (datumOd.SelectedDate == null)
            {
                Termini.ItemsSource = getTerminiDo((DateTime)datumDo.SelectedDate);
            }
            else
            {
                if (!dateValid())
                {
                    return;
                }
                Termini.ItemsSource = getTermini((DateTime)datumOd.SelectedDate, (DateTime)datumDo.SelectedDate);
            }
        }
        public ObservableCollection<TerminModel> getTermini(DateTime datumOd, DateTime datumDo)
        {
            ObservableCollection<TerminModel> retTermini = new ObservableCollection<TerminModel>();
            foreach (TerminModel tm in new IzvestajPacijentViewModel().Termini)
            {
                if (tm.VremeTermina >= datumOd && tm.VremeTermina <= datumDo)
                {
                    retTermini.Add(tm);
                }
            }
            return retTermini;


        }
        public ObservableCollection<TerminModel> getTerminiOd(DateTime datumOd)
        {
            ObservableCollection<TerminModel> retTermini = new ObservableCollection<TerminModel>();
            foreach (TerminModel tm in new IzvestajPacijentViewModel().Termini)
            {
                if (tm.VremeTermina >= datumOd)
                {
                    retTermini.Add(tm);
                }
            }
            return retTermini;


        }
        public ObservableCollection<TerminModel> getTerminiDo(DateTime datumDo)
        {
            ObservableCollection<TerminModel> retTermini = new ObservableCollection<TerminModel>();
            foreach (TerminModel tm in new IzvestajPacijentViewModel().Termini)
            {
                if (tm.VremeTermina <= datumDo)
                {
                    retTermini.Add(tm);
                }
            }
            return retTermini;


        }
        public bool dateValid()
        {
            if(datumOd.SelectedDate == null || datumDo.SelectedDate == null)
            {
                MessageBox.Show("Nije izabran datum.");
                return false;
            }
            if((DateTime)datumOd.SelectedDate >= (DateTime)datumDo.SelectedDate)
            {
                MessageBox.Show("Datum od mora biti manji od datuma do");
                stampajBtn.IsEnabled = false;
                return false;

            }
            stampajBtn.IsEnabled = true;
            return true;
        }
    }
}
