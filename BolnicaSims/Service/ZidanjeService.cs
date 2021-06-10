using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;
using System.Windows.Data;

namespace BolnicaSims.Service
{
    class ZidanjeService
    {
        private static Prostorija selektovanaProstorija;
        private static Prostorija spojProstorija;
        static Timer timer;

        public void zakaziSpajanje(DateTime pocetak, int trajanjeDani, String prostorijaSpoj, Prostorija prostorija)
        {
            selektovanaProstorija = prostorija;
            spojProstorija = ProstorijaService.Instance.getProstorijaByNaziv(prostorijaSpoj);
            DateTime kraj = pocetak.AddDays(trajanjeDani);
            schedule_TimerSpajanje(kraj);

        }
        public void zakaziDeljenje(DateTime pocetak, int trajanjeDani, Prostorija prostorija)
        {
            selektovanaProstorija = prostorija;
            DateTime kraj = pocetak.AddDays(trajanjeDani);
            schedule_TimerDeljenje(kraj);
        }
        static void spajanjeProstorija()
        {
            ProstorijaService.Instance.prebaciInventar(spojProstorija, selektovanaProstorija);
            ProstorijaService.Instance.prebaciTermine(spojProstorija, selektovanaProstorija);
            ProstorijaService.Instance.handleSusedneSpajanje(selektovanaProstorija, spojProstorija);
            selektovanaProstorija.BrojProstorije = Math.Min(selektovanaProstorija.BrojProstorije, spojProstorija.BrojProstorije);
            ProstorijaService.Instance.ukloniProstoriju(spojProstorija);
            ProstorijaService.Instance.izmeniProstoriju(selektovanaProstorija.TipProstorije, selektovanaProstorija.Sprat.ToString(), selektovanaProstorija.BrojProstorije.ToString());
            CollectionViewSource.GetDefaultView(UpravnikView.Instance.dataGridProstorije.ItemsSource).Refresh();
        }
        static void deljenjeProstorija()
        {
            String brojNove = ProstorijaService.Instance.genBrojProstorijeDeljenje(selektovanaProstorija);
            ProstorijaService.Instance.dodajProstoriju(selektovanaProstorija.TipProstorije, selektovanaProstorija.Sprat.ToString(), brojNove);
            ProstorijaService.Instance.handleSusedneDeljenje(brojNove, selektovanaProstorija.Sprat.ToString());
            CollectionViewSource.GetDefaultView(UpravnikView.Instance.dataGridProstorije.ItemsSource).Refresh();
        }

        static void schedule_TimerSpajanje(DateTime scheduledTime)
        {
            double tickTime = (double)(scheduledTime - DateTime.Now).TotalMilliseconds;
            timer = new Timer(tickTime);
            timer.Elapsed += new ElapsedEventHandler(timer_ElapsedSpajanje);
            timer.Start();
        }
        static void schedule_TimerDeljenje(DateTime scheduledTime)
        {
            double tickTime = (double)(scheduledTime - DateTime.Now).TotalMilliseconds;
            timer = new Timer(tickTime);
            timer.Elapsed += new ElapsedEventHandler(timer_ElapsedDeljenje);
            timer.Start();
        }
        static void timer_ElapsedSpajanje(object sender, ElapsedEventArgs e)
        {
            timer.Stop();
            App.Current.Dispatcher.Invoke((Action)delegate // <--- HERE
            {
                spajanjeProstorija();
            });

        }
        static void timer_ElapsedDeljenje(object sender, ElapsedEventArgs e)
        {
            timer.Stop();
            App.Current.Dispatcher.Invoke((Action)delegate // <--- HERE
            {
                deljenjeProstorija();
            });

        }

    }
}
