﻿using BolnicaSims.Model;
using BolnicaSims.Storage;
using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Data;

namespace BolnicaSims.Service
{
    class TerminService
    {
        private static TerminService instance = null;
        public static TerminService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TerminService();
                }
                return instance;
            }
        }


        public void izmeniTermin(Termin termin)
        {
            for (int i = 0; i < TerminStorage.Instance.termini.Count; i++)
            {
                if (TerminStorage.Instance.termini[i].IdTermina == termin.IdTermina)
                {
                    if (termin.IdTermina != "" && termin.IdTermina != " ")
                    {
                        TerminStorage.Instance.termini[i].IdTermina = termin.IdTermina;                      
                    }
                    if (termin.VremeTermina.ToString() != "")
                    {
                        TerminStorage.Instance.termini[i].VremeTermina = termin.VremeTermina;
                    }
                    if (termin.ImePrezimeDoktora != "")
                    {
                        TerminStorage.Instance.termini[i].ImePrezimeDoktora = termin.ImePrezimeDoktora;
                    }
                    TerminStorage.Instance.termini[i].ImePrezimePacijenta = termin.ImePrezimePacijenta;
                    TerminStorage.Instance.termini[i].KrajTermina = termin.KrajTermina;
                    if(termin.prostorija != null)
                    {
                        TerminStorage.Instance.termini[i].prostorija = termin.prostorija;
                        TerminStorage.Instance.termini[i].TipTermina = termin.TipTermina;
                    }
                    
                    TerminStorage.Instance.termini[i].pacijent = termin.pacijent;
                    TerminStorage.Instance.termini[i].doktor = termin.doktor;
                    
                
                }
                
            }
            for (int i = 0; i < termin.doktor.termini.Count; i++)
            {
                if (DoktorService.Instance.getDoktor(termin.doktor).termini[i].IdTermina == termin.IdTermina)
                {
                    if (termin.IdTermina != "" && termin.IdTermina != " ")
                    {
                        DoktorService.Instance.getDoktor(termin.doktor).termini[i].IdTermina = termin.IdTermina;
                    }
                    if (termin.VremeTermina.ToString() != "")
                    {
                        DoktorService.Instance.getDoktor(termin.doktor).termini[i].VremeTermina = termin.VremeTermina;
                    }
                    if (termin.ImePrezimeDoktora != "")
                    {
                        DoktorService.Instance.getDoktor(termin.doktor).termini[i].ImePrezimeDoktora = termin.ImePrezimeDoktora;
                    }
                    DoktorService.Instance.getDoktor(termin.doktor).termini[i].ImePrezimePacijenta = termin.ImePrezimePacijenta;
                    DoktorService.Instance.getDoktor(termin.doktor).termini[i].KrajTermina = termin.KrajTermina;
                    DoktorService.Instance.getDoktor(termin.doktor).termini[i].prostorija = termin.prostorija;
                    DoktorService.Instance.getDoktor(termin.doktor).termini[i].pacijent = termin.pacijent;

                }
            }
            for (int i = 0; i < termin.pacijent.termini.Count; i++)
            {
                if (PacijentService.Instance.getPacijent(termin.pacijent).termini[i].IdTermina == termin.IdTermina)
                {
                    if (termin.IdTermina != "" && termin.IdTermina != " ")
                    {
                        PacijentService.Instance.getPacijent(termin.pacijent).termini[i].IdTermina = termin.IdTermina;
                    }
                    if (termin.VremeTermina.ToString() != "")
                    {
                        PacijentService.Instance.getPacijent(termin.pacijent).termini[i].VremeTermina = termin.VremeTermina;
                    }
                    if (termin.ImePrezimeDoktora != "")
                    {
                        PacijentService.Instance.getPacijent(termin.pacijent).termini[i].ImePrezimeDoktora = termin.ImePrezimeDoktora;
                    }
                    PacijentService.Instance.getPacijent(termin.pacijent).termini[i].ImePrezimePacijenta = termin.ImePrezimePacijenta;
                    PacijentService.Instance.getPacijent(termin.pacijent).termini[i].KrajTermina = termin.KrajTermina;
                    PacijentService.Instance.getPacijent(termin.pacijent).termini[i].prostorija = termin.prostorija;
                    PacijentService.Instance.getPacijent(termin.pacijent).termini[i].pacijent = termin.pacijent;

                }
            }

            if (termin.prostorija != null)
            {
                ProstorijaService.Instance.getProstorija(termin.prostorija).termini.Add(termin);
            }
            TerminStorage.Instance.Save();
            SekretarView.Instance.refreshTermini();
            NotificationService.Instance.handleNotificationsUpdateTermin(KorisniciStorage.Instance.ulogovaniKorisnik, termin);

            DoktoriStorage.Instance.Save();
            PacijentiStorage.Instance.Save();
            KorisniciStorage.Instance.Save();
            ProstorijeStorage.Instance.Save();
       
        }

        public void dodajTermin(String vreme, String doktor, String pacijent)
        {
            if (slobodanTermin(vreme, doktor))
            {              
                Termin tempTermin = new Termin(GenID(), DateTime.Parse(vreme), DateTime.Parse(vreme), DoktorService.Instance.getDoktor(doktor), PacijentService.Instance.getPacijent(pacijent), doktor, pacijent);
                
                DoktorService.Instance.getDoktor(doktor).termini.Add(tempTermin);                                            
                PacijentService.Instance.getPacijent(pacijent).termini.Add(tempTermin);
               

                NotificationService.Instance.handleNotificationsAddTermin(KorisniciStorage.Instance.ulogovaniKorisnik, tempTermin);               
               
                TerminStorage.Instance.Read().Add(tempTermin);
                TerminStorage.Instance.Save();
                DoktoriStorage.Instance.Save();
                PacijentiStorage.Instance.Save();
                KorisniciStorage.Instance.Save();
                PacijentService.Instance.zabeleziOdradjenePreglede();

            }
            else MessageBox.Show("Termin je vec zauzet");

        }

      


        public void dodajTerminAdvanced(DateTime vremeTermina, DateTime kraj, Doktor doktor, Pacijent pacijent, Prostorija prostorija, TipTermina tip)
        {
                      
            Termin temp = new Termin(GenID(), vremeTermina, kraj, doktor, pacijent, doktor.korisnik.ImePrezime, pacijent.korisnik.ImePrezime);
            temp.prostorija = prostorija;
            temp.TipTermina = tip;
            TerminStorage.Instance.termini.Add(temp);
            DoktorService.Instance.getDoktor(doktor).termini.Add(temp);
            PacijentService.Instance.getPacijent(pacijent).termini.Add(temp);
            ProstorijaService.Instance.getProstorija(prostorija).termini.Add(temp);
            NotificationService.Instance.handleNotificationsAddTermin(KorisniciStorage.Instance.ulogovaniKorisnik, temp);
            TerminStorage.Instance.Save();
            DoktoriStorage.Instance.Save();
            PacijentiStorage.Instance.Save();
            KorisniciStorage.Instance.Save();
            ProstorijeStorage.Instance.Save();
           
        }

        public void ukloniTermin(Termin t)
        {
            TerminStorage.Instance.termini.Remove(t);
            DoktorService.Instance.getDoktor(t.doktor).termini.Remove(t);
            PacijentService.Instance.getPacijent(t.pacijent).termini.Remove(t);
            if (t.prostorija != null)
            {
                ProstorijaService.Instance.getProstorija(t.prostorija).termini.Remove(t);
            }
            TerminStorage.Instance.Save();
            DoktoriStorage.Instance.Save();
            PacijentiStorage.Instance.Save();
            ProstorijeStorage.Instance.Save();
            NotificationService.Instance.handleNotificationsRemoveTermin(KorisniciStorage.Instance.ulogovaniKorisnik, t);
            KorisniciStorage.Instance.Save();
            
        }
        public Boolean slobodanTermin(String vreme,String doktor)
        {
            foreach(Termin t in TerminStorage.Instance.termini)
            {
                if (doktor == t.ImePrezimeDoktora)
         
                {
                    if (DateTime.Parse(vreme) == (t.VremeTermina))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public Boolean slobodanTerminAdvanced(DateTime pocetak, DateTime kraj,Pacijent pacijent, Doktor doktor, Prostorija prostorija)
        {
            foreach (Termin t in TerminStorage.Instance.termini)
            {
                if((doktor.korisnik.Jmbg == t.doktor.korisnik.Jmbg)||(pacijent.korisnik.Jmbg == t.pacijent.korisnik.Jmbg) || (prostorija.Naziv == t.prostorija.Naziv))
                {
                    if((pocetak >= t.VremeTermina && kraj <= t.KrajTermina) || (pocetak <= t.VremeTermina && kraj >= t.VremeTermina) || (pocetak <= t.KrajTermina && kraj >= t.KrajTermina) || (pocetak <= t.VremeTermina && kraj >= t.KrajTermina))
                    {
                        return false;
                    }
                }
               
            }
            
                
            return true;
        }
        public Boolean slobodanDoktor(DateTime pocetak, DateTime kraj, Doktor doktor)
        {
            foreach (Termin t in TerminStorage.Instance.termini)
            {
                if (doktor.korisnik.Jmbg == t.doktor.korisnik.Jmbg)
                {
                    if ((pocetak >= t.VremeTermina && kraj <= t.KrajTermina) || (pocetak <= t.VremeTermina && kraj >= t.VremeTermina) || (pocetak <= t.KrajTermina && kraj >= t.KrajTermina) || (pocetak <= t.VremeTermina && kraj >= t.KrajTermina))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public Boolean slobodanPacijent(DateTime pocetak, DateTime kraj, Pacijent pacijent)
        {
            foreach (Termin t in TerminStorage.Instance.termini)
            {
                if (pacijent.zdravstveniKarton.BrojKartona == t.pacijent.zdravstveniKarton.BrojKartona)
                {
                    if ((pocetak >= t.VremeTermina && kraj <= t.KrajTermina) || (pocetak <= t.VremeTermina && kraj >= t.VremeTermina) || (pocetak <= t.KrajTermina && kraj >= t.KrajTermina) || (pocetak <= t.VremeTermina && kraj >= t.KrajTermina))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public Boolean slobodnaProstorija(DateTime pocetak, DateTime kraj, Prostorija prostorija)
        {
            foreach (Termin t in TerminStorage.Instance.termini)
            {
                if(t.prostorija != null)
                {
                    if (prostorija.Naziv == t.prostorija.Naziv)
                    {
                        if ((pocetak >= t.VremeTermina && kraj <= t.KrajTermina) || (pocetak <= t.VremeTermina && kraj >= t.VremeTermina) || (pocetak <= t.KrajTermina && kraj >= t.KrajTermina) || (pocetak <= t.VremeTermina && kraj >= t.KrajTermina))
                        {
                            return false;
                        }
                    }
                }
                
            }
            return true;
        }

        public String GenID()
        {
            int a = 0;
            if (TerminStorage.Instance.termini.Count == 0)
            {
                a = 1;
            }
            else 
            { 
                a = int.Parse(TerminStorage.Instance.termini[TerminStorage.Instance.termini.Count - 1].IdTermina) + 1;
            }
            return a.ToString();
        }

        public Boolean terminOdradjen(Termin termin)
        {
            if(DateTime.Now > termin.KrajTermina)
            {
                return true;
            }
            return false;
        }

        public Boolean proveraPomeranje(Termin termin,String vreme)
        {
            DateTime stariTermin = termin.VremeTermina;
            DateTime noviTermin = DateTime.Parse(vreme);
            DateTime noviTermin2 = DateTime.Parse(vreme);
            DateTime noviTermin3 = stariTermin.AddDays(-1);
            if (DateTime.Now > noviTermin3)
            {
                MessageBox.Show("Termin ne moze da se pomera 24h pre termina");
                return false ;
            }

            noviTermin = noviTermin.AddDays(2);
            noviTermin2 = noviTermin2.AddDays(-2);

            if (stariTermin > noviTermin)
            {
                MessageBox.Show("Datum ne sme biti pomeren vise od 2 dana unazad");
                return false;
            }
            if (stariTermin < noviTermin2)
            {
                MessageBox.Show("Datum ne sme biti pomeren za vise od 2 dana");
                return false;
            }

            return true;
           
        }
    }
}
