using BolnicaSims.Controller;
using BolnicaSims.Model;
using BolnicaSims.Service;
using BolnicaSims.Storage;
using BolnicaSims.View.AddView;
using BolnicaSims.View.MainView;
using BolnicaSims.View.NotificationsView;
using BolnicaSims.View.TableView;
using Haley.Models;
using Haley.Utils;
using Haley.MVVM;
using Haley.Abstractions;
using Haley.Enums;
using Haley.Utils;
using Model;
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
using BolnicaSims.MVVM.Views;
using BolnicaSims.Model.ButtonFactories;
using BolnicaSims.View.Feedback;

namespace BolnicaSims
{
    /// <summary>
    /// Interaction logic for PacijentView.xaml
    /// </summary>
    public partial class PacijentView : Window
    { 
        private static PacijentView instance = null;
        
        public static PacijentView Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PacijentView();
                }
                return instance;
            }
        }

        public ObservableCollection<Termin> termini = TerminStorage.Instance.Read();
        public ObservableCollection<Termin> pacTermini = new ObservableCollection<Termin>();
        public ObservableCollection<Recept> recepti = ReceptiStorage.Instance.Read();
        public ObservableCollection<Recept> pacRecepti = new ObservableCollection<Recept>();
        private string currentLanguage;
        public ButtonFactory btnFactory;

        public PacijentView()
        {
            InitializeComponent();

            this.CurrentLanguage = "sr-LATN";
            this.btnFactory = new LightButtonFactory();
            createAButton();

            if (PacijentController.Instance.proveriBan(DateTime.Now,PacijentController.Instance.getUlogovaniPacijent()))
            {
                zakazi.IsEnabled = false;
                izmeni.IsEnabled = false;
            }
            dataGridTermini.ItemsSource = PacijentController.Instance.getUlogovaniPacijent().termini;
            dataGridRecepti.ItemsSource = PacijentController.Instance.getUlogovaniPacijent().recepti;           
            
            PacijentController.Instance.zabeleziOdradjenePreglede();

            if ((PacijentController.Instance.getUlogovaniPacijent().brojOdradjenihPregleda)  % 3 == 0)
            {
                btnAnketaBolnica.IsEnabled = true;
            }
            else
            {
                btnAnketaBolnica.IsEnabled = false;
            }

            PacijentController.Instance.getUlogovaniPacijent().brojZakazivanja = 0;

        }

    
    
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var s = new NotifikacijePacijent();
            s.Show();
        }

        private void ButtonZakazi_Click(object sender, RoutedEventArgs e)
        {            
            var s = new DodavanjePregleda();
            s.Show();
        }

        private void ButtonIzmeniTermin_Click(object sender, RoutedEventArgs e)
        {
            if (dataGridTermini.SelectedItem is Termin)
            {
                Termin selektovan = (Termin)dataGridTermini.SelectedItem;
                TerminStorage.Instance.selektovanTermin = selektovan;

                var s = new IzmenaPregleda();
                s.Show();

            }
            else
            {
                MessageBox.Show("Nije izabran termin za izmenu");
                return;
            }

        }

        private void ButtonOtkazi_Click(object sender, RoutedEventArgs e)
        {
            //wipe
            //PacijentService.Instance.getUlogovaniPacijent(KorisniciStorage.Instance.ulogovaniKorisnik).recepti.Clear();

            if (dataGridTermini.SelectedItem is Termin)
            {
                
                TerminController.Instance.ukloniTermin((Termin)dataGridTermini.SelectedItem);

            }
            else
            {
                MessageBox.Show("Nije izabran termin za izmenu");
                return;
            }

            
        }

        private void ButtonObavestenja_Click(object sender, RoutedEventArgs e)
        {
         
            foreach(Recept r in PacijentController.Instance.getUlogovaniPacijent().recepti)
            {
                ReceptController.Instance.notifikacijaLek(r);
            }
            var s = new NotifikacijePacijent();
            s.Show();
        }

        private void Button_Click_AnketaDoktor(object sender, RoutedEventArgs e)
        {
            var s = new AnketaDoktor();
            s.Show();
        
        }

        private void Button_Click_AnketaBolnica(object sender, RoutedEventArgs e)
        {
            var s = new AnketaBolnica();
            s.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var s = new MainWindow();
            s.Show();
            Close();
        }

        private void karton_Click(object sender, RoutedEventArgs e)
        {
            var s = new PacijentKarton();
            s.Show();
        }

        private void DarkMode_Checked(object sender, RoutedEventArgs e)
        {
            this.btnFactory = new DarkButtonFactory();
            createAButton();
            Properties.Settings.Default.ColorMode = "Dark";
            Properties.Settings.Default.Save();
        }

        private void LightMode_Checked(object sender, RoutedEventArgs e)
        {
            this.btnFactory = new LightButtonFactory();
            createAButton();
            Properties.Settings.Default.ColorMode = "Light";
            Properties.Settings.Default.Save();
        }

        public string CurrentLanguage
        {
            get { return currentLanguage; }
            set
            {
                currentLanguage = value;
            }
        }

        private void Execute_SwitchLanguageCommand()
        {
            var app = (App)Application.Current;
            if (CurrentLanguage.Equals("en-US"))
            {
                CurrentLanguage = "sr-LATN";
            }
            else
            {
                CurrentLanguage = "en-US";
            }
            app.ChangeLanguage(CurrentLanguage);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Execute_SwitchLanguageCommand();
        }

        private void izvestaj_Click(object sender, RoutedEventArgs e)
        {
            var s = new IzvestajPacijentView();
            s.Show();
        }
        private void createAButton()
        {
            Button btn = this.btnFactory.createButton();
            btn.Click += this.ButtonObavestenja_Click;
            btn.Height = 28;
            btn.Width = 60;
            Thickness margin = btn.Margin;
            margin.Left = 180;
            margin.Top = -360;
            btn.Margin = margin;
            Daddy.Children.Add(btn);
        }

        private void btnFeedback_Click(object sender, RoutedEventArgs e)
        {
            var s = new PacijentFeedback();
            s.ShowDialog();
        }
    }
}
