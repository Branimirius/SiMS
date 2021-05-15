using BolnicaSims.Model;
using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;
using System.Windows.Data;

namespace BolnicaSims.Service
{
    class RenoviranjeService
    {
        private static RenoviranjeService instance = null;
        public static RenoviranjeService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RenoviranjeService();
                }
                return instance;
            }
        }
        private static Prostorija selektovanaProstorija;
        private static Prostorija spojProstorija;
        static Timer timer;
        public void zakaziRenoviranje(DateTime pocetak, int trajanjeDani, Prostorija prostorija)
        {           
            prostorija.renoviranja.Add(new Renoviranje(pocetak, pocetak.AddDays(trajanjeDani), prostorija));
            ProstorijeStorage.Instance.Save();
        }
        public void zakaziSpajanje(DateTime pocetak, int trajanjeDani,String prostorijaSpoj, Prostorija prostorija)
        {
            selektovanaProstorija = prostorija;
            spojProstorija = ProstorijaService.Instance.getProstorijaByNaziv(prostorijaSpoj);
            DateTime kraj = pocetak.AddDays(trajanjeDani);
            schedule_Timer(kraj);

        }
        static void spajanjeProstorija()
        {
            ProstorijaService.Instance.prebaciInventar(spojProstorija, selektovanaProstorija);
            ProstorijaService.Instance.prebaciTermine(spojProstorija, selektovanaProstorija);
            selektovanaProstorija.BrojProstorije = Math.Min(selektovanaProstorija.BrojProstorije, spojProstorija.BrojProstorije);
            ProstorijaService.Instance.ukloniProstoriju(spojProstorija);
            ProstorijaService.Instance.izmeniProstoriju(selektovanaProstorija.TipProstorije, selektovanaProstorija.Sprat.ToString(), selektovanaProstorija.BrojProstorije.ToString());
            CollectionViewSource.GetDefaultView(UpravnikView.Instance.dataGridProstorije.ItemsSource).Refresh();
        }

        
        static void schedule_Timer(DateTime scheduledTime)
        {
            
            //Console.WriteLine("### Timer Started ###");

            //DateTime nowTime = DateTime.Now;
            //DateTime scheduledTime = new DateTime(nowTime.Year, nowTime.Month, nowTime.Day, 8, 42, 0, 0); //Specify your scheduled time HH,MM,SS [8am and 42 minutes]
            /*if (nowTime > scheduledTime)
            {
                scheduledTime = scheduledTime.AddDays(1);
            }*/

            double tickTime = (double)(scheduledTime - DateTime.Now).TotalMilliseconds;
            timer = new Timer(tickTime);
            timer.Elapsed += new ElapsedEventHandler(timer_Elapsed);
            timer.Start();
        }
        static void timer_Elapsed(object sender, ElapsedEventArgs e)
        {          
            timer.Stop();
            App.Current.Dispatcher.Invoke((Action)delegate // <--- HERE
            {
                spajanjeProstorija();
            });
            
        }
    }
}
