﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading;
using System.Timers;
using BolnicaSims.Controller;
using BolnicaSims.DTO;
using BolnicaSims.Model;
using BolnicaSims.Storage;
using Model;

namespace BolnicaSims.Service
{
    class PacijentService
    {
        private static PacijentService instance = null;
        public static PacijentService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PacijentService();
                }
                return instance;
            }
        }

        private static String beleska;
        private static Korisnik korisnik; 
        static System.Timers.Timer timer;
       

        public void izmeniPacijenta(Pacijent pacijent, Pacijent selected)
        {
            for (int i = 0; i < PacijentiStorage.Instance.pacijenti.Count; i++)
            {

                if (pacijent.zdravstveniKarton.BrojKartona == PacijentiStorage.Instance.pacijenti[i].zdravstveniKarton.BrojKartona)

                {
                    if (pacijent.korisnik.Ime != "")
                    {
                        PacijentiStorage.Instance.pacijenti[i].korisnik.Ime = pacijent.korisnik.Ime;
                    }
                    if (pacijent.korisnik.Prezime != "")
                    {
                        PacijentiStorage.Instance.pacijenti[i].korisnik.Prezime = pacijent.korisnik.Prezime;
                    }
                    if (pacijent.zdravstveniKarton.ImeRoditelja != "")
                    {
                        PacijentiStorage.Instance.pacijenti[i].zdravstveniKarton.ImeRoditelja = pacijent.zdravstveniKarton.ImeRoditelja;
                    }
                    if (pacijent.zdravstveniKarton.BrojKartona != "")
                    {
                        PacijentiStorage.Instance.pacijenti[i].zdravstveniKarton.BrojKartona = pacijent.zdravstveniKarton.BrojKartona;
                    }
                    if (pacijent.korisnik.Username != "")
                    {
                        PacijentiStorage.Instance.pacijenti[i].korisnik.Username = pacijent.korisnik.Username;
                    }
                    if (pacijent.korisnik.Password != "")
                    {
                        PacijentiStorage.Instance.pacijenti[i].korisnik.Password = pacijent.korisnik.Password;
                    }
                    if (pacijent.zdravstveniKarton.Anamneza != "")
                    {
                        PacijentiStorage.Instance.pacijenti[i].zdravstveniKarton.Anamneza = pacijent.zdravstveniKarton.Anamneza;
                    }
                    if (pacijent.zdravstveniKarton.Alergije != "")
                    {
                        PacijentiStorage.Instance.pacijenti[i].zdravstveniKarton.Alergije = pacijent.zdravstveniKarton.Alergije;
                    }
                }

            }

            for (int i = 0; i < KorisniciStorage.Instance.korisnici.Count; i++)
            {
                if ((selected.korisnik.Jmbg) == (KorisniciStorage.Instance.korisnici[i].Jmbg))
                {
                    if (selected.korisnik.Ime != "")
                    {
                        KorisniciStorage.Instance.korisnici[i].Ime = selected.korisnik.Ime;
                    }
                    if (selected.korisnik.Prezime != "")
                    {
                        KorisniciStorage.Instance.korisnici[i].Prezime = selected.korisnik.Prezime;
                    }
                    if (selected.korisnik.Username != "")
                    {
                        KorisniciStorage.Instance.korisnici[i].Username = selected.korisnik.Username;
                    }
                    if (selected.korisnik.Password != "")
                    {
                        KorisniciStorage.Instance.korisnici[i].Password = selected.korisnik.Password;
                    }
                }

            }
            //KorisniciStorage.Instance.Save();       

            PacijentiStorage.Instance.Save();

            SekretarView.Instance.refreshPacijenti();            
        }
        public void izmeniAnamnezu(String anamneza, String alergija)
        {
            foreach (Pacijent p in PacijentiStorage.Instance.Read())
            {
                if (p.zdravstveniKarton.BrojKartona == PacijentiStorage.Instance.selektovanPacijent.zdravstveniKarton.BrojKartona)
                {
                    p.zdravstveniKarton.Anamneza = anamneza;
                    p.zdravstveniKarton.Alergije = alergija;
                }
            }
            PacijentiStorage.Instance.Save();
        }
        public void dodajPacijenta(Pacijent pacijent)
        {
            PacijentiStorage.Instance.Read().Add(pacijent);
            PacijentiStorage.Instance.pacijentiImena.Add(pacijent.korisnik.Ime + " " + pacijent.korisnik.Prezime);
            PacijentiStorage.Instance.Save();
        }
        public void dodajPacijenta(PacijentDTO pacijent)
        {
            pacijent.BrojKartona = GenID();
            PacijentiStorage.Instance.Read().Add(new Pacijent(pacijent));
            PacijentiStorage.Instance.pacijentiImena.Add(pacijent.korisnik.Ime + " " + pacijent.korisnik.Prezime);
            PacijentiStorage.Instance.Save();
        }

        public void banujPacijenta(DateTime vreme, Pacijent pacijent)
        {
            pacijent.isBanned = true;
            pacijent.vremeBanovanja = vreme;
            PacijentiStorage.Instance.Save();

        }
        public Boolean proveriBan(DateTime trenutnoVreme, Pacijent pacijent)
        {
            if(pacijent.vremeBanovanja == null)
            {
                return false;
            }
            if(trenutnoVreme > pacijent.vremeBanovanja.AddDays(1))
            {
                return false;
            }
            return true;
        }


        public Pacijent getUlogovaniPacijent(Korisnik ulogovaniKorisnik)
        {
            foreach(Pacijent p in PacijentiStorage.Instance.pacijenti)
            {
                if(p.korisnik.Username+p.korisnik.Password == ulogovaniKorisnik.Username+ulogovaniKorisnik.Password)
                {
                    return p;
                }
            }
            return null;

        }
        
        public Pacijent getPacijent(Pacijent pacijent)
        {
            foreach (Pacijent p in PacijentiStorage.Instance.pacijenti)
            {
                if (p.zdravstveniKarton.BrojKartona == pacijent.zdravstveniKarton.BrojKartona)
                {
                    return p;
                }
            }
            return null;
        }
        public Pacijent getPacijent(String pacijent)
        {
            foreach (Pacijent p in PacijentiStorage.Instance.pacijenti)
            {
                if (p.korisnik.Ime + " " + p.korisnik.Prezime == pacijent)
                {
                    return p;
                }
            }
            return null;
        }

        public void setSelectovaniPacijent(Lecenje lecenje)
        {
            PacijentiStorage.Instance.selektovanPacijent = lecenje.Pacijent;
        }

        public String GenID()
        {
            int a = 0;
            if (PacijentiStorage.Instance.pacijenti.Count == 0)
            {
                a = 1;
            }
            else
            {
                a = int.Parse(PacijentiStorage.Instance.pacijenti[PacijentiStorage.Instance.pacijenti.Count - 1].zdravstveniKarton.BrojKartona) + 1;

            }
            return a.ToString();
        }

        public void zabeleziOdradjenePreglede()
        {

            PacijentService.Instance.getUlogovaniPacijent(KorisniciStorage.Instance.ulogovaniKorisnik).brojOdradjenihPregleda = 0;
            
            foreach (Termin t in PacijentService.Instance.getUlogovaniPacijent(KorisniciStorage.Instance.ulogovaniKorisnik).termini)
            {
                if (TerminService.Instance.terminOdradjen(t))
                {
                        PacijentService.Instance.getUlogovaniPacijent(KorisniciStorage.Instance.ulogovaniKorisnik).brojOdradjenihPregleda++;
                }
            }
            
            
        }


        public void sacuvajBelesku(DateTime vreme,String b)
        {
            korisnik = KorisniciStorage.Instance.ulogovaniKorisnik;
            beleska = b;
            schedule_TimerBeleska(vreme);

        }

        static void schedule_TimerBeleska(DateTime scheduledTime)
        {


            double tickTime = (double)(scheduledTime - DateTime.Now).TotalMilliseconds;
            timer = new System.Timers.Timer(tickTime);
            timer.Elapsed += new ElapsedEventHandler(timer_ElapsedBeleska);
            timer.Start();
        }

        static void timer_ElapsedBeleska(object sender, ElapsedEventArgs e)
        {
            timer.Stop();
            App.Current.Dispatcher.Invoke((Action)delegate // <--- HERE
            {
                posaljiBelesku();
            });

        }

        static void posaljiBelesku()
        {
            NotificationService.Instance.beleskaNotification(korisnik,beleska);
		}

        public ObservableCollection<Pacijent> getPacijenti()
        {
            return PacijentiStorage.Instance.pacijenti;
        }
        public ObservableCollection<String> getPacijentiImena()
        {
            return PacijentiStorage.Instance.pacijentiImena;
        }
        public Pacijent getSelektovanPacijent()
        {
            return PacijentiStorage.Instance.selektovanPacijent;
        }
        public ObservableCollection<Recept> getRecepti()
        {
            return PacijentiStorage.Instance.recepti;

        }

    }
}
