using BolnicaSims.Model;
using BolnicaSims.Storage;
using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

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
                    TerminStorage.Instance.termini[i].prostorija = termin.prostorija;
                    TerminStorage.Instance.termini[i].pacijent = termin.pacijent;
                    TerminStorage.Instance.termini[i].doktor = termin.doktor;
                    TerminStorage.Instance.termini[i].TipTermina = termin.TipTermina;
                
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

            
            TerminStorage.Instance.Save();
            SekretarView.Instance.refreshTermini();
            //Notifikacija n1 = new Notifikacija("Pomeren termin", termin.ImePrezimePacijenta, "Pomeren je termin kod doktora:  " + termin.ImePrezimeDoktora);
            if (KorisniciStorage.Instance.ulogovaniKorisnik.Zvanje == "Pacijent")
            {
                Notifikacija n1 = new Notifikacija("Pomeren termin", termin.ImePrezimePacijenta, "Pomeren je termin kod doktora:  " + termin.ImePrezimeDoktora);

                foreach (Korisnik k in KorisniciStorage.Instance.korisnici)
                {
                    if (k.Zvanje == "Sekretar")
                    {
                        k.Notifikacije.Add(n1);
                    }
                }
            }
            else if(KorisniciStorage.Instance.ulogovaniKorisnik.Zvanje == "Sekretar")
            {
                Notifikacija n1 = new Notifikacija("Pomeren termin", "Sekretar", "Pomeren je termin kod doktora:  " + termin.ImePrezimeDoktora);

                termin.pacijent.korisnik.Notifikacije.Add(n1);
            }
            else
            {
                Notifikacija n1 = new Notifikacija("Pomeren termin", termin.ImePrezimeDoktora, "Pomeren je termin kod doktora:  " + termin.ImePrezimeDoktora);

                termin.pacijent.korisnik.Notifikacije.Add(n1);
                foreach (Korisnik k in KorisniciStorage.Instance.korisnici)
                {
                    if (k.Zvanje == "Sekretar")
                    {
                        k.Notifikacije.Add(n1);
                    }
                }
            }
            DoktoriStorage.Instance.Save();
            PacijentiStorage.Instance.Save();
            KorisniciStorage.Instance.Save();
        }

        public void dodajTermin(String vreme, String doktor, String pacijent)
        {
            if (slobodanTermin(vreme, doktor) == true)
            {              
                Termin tempTermin = new Termin();
                tempTermin.IdTermina = GenID();
                tempTermin.VremeTermina = DateTime.Parse(vreme);
                tempTermin.KrajTermina = tempTermin.VremeTermina.AddHours(1);

                foreach (Doktor d in DoktoriStorage.Instance.doktori)
                {
                    
                    if ((d.korisnik.Ime + " " + d.korisnik.Prezime) == (doktor))
                    {
                       
                        d.termini.Add(tempTermin);
                        tempTermin.doktor = d;
                        tempTermin.doktori.Add(d);
                        tempTermin.ImePrezimeDoktora = d.korisnik.Ime + " " + d.korisnik.Prezime;
                    }
                }
                foreach (Pacijent p in PacijentiStorage.Instance.pacijenti)
                {
                   
                    if ((p.korisnik.Ime + " " + p.korisnik.Prezime) == (pacijent))
                    {
                        
                        p.termini.Add(tempTermin);
                        tempTermin.pacijent = p;
                        tempTermin.ImePrezimePacijenta = p.korisnik.Ime + " " + p.korisnik.Prezime;
                    }
                }

                if (KorisniciStorage.Instance.ulogovaniKorisnik.Zvanje == "Pacijent")
                {
                    Notifikacija n1 = new Notifikacija("Zakazan termin", pacijent, "Zakazan je termin kod doktora:  " + doktor);

                    foreach (Korisnik k in KorisniciStorage.Instance.korisnici)
                    {
                        if (k.Zvanje == "Sekretar")
                        {
                            k.Notifikacije.Add(n1);
                        }
                    }
                }
                else if (KorisniciStorage.Instance.ulogovaniKorisnik.Zvanje == "Sekretar")
                {
                    Notifikacija n1 = new Notifikacija("Zakazan termin", "Sekretar", "Zakazan je termin kod doktora:  " + doktor);

                    foreach (Korisnik k in KorisniciStorage.Instance.korisnici)
                    {
                        if ((k.Ime + " " + k.Prezime) == pacijent)
                        {
                            k.Notifikacije.Add(n1);
                        }
                        if ((k.Ime + " " + k.Prezime) == doktor)
                        {
                            k.Notifikacije.Add(n1);
                        }
                    }
                    
                }
                else
                {
                    Notifikacija n1 = new Notifikacija("Zakazan termin", "Sekretar", "Zakazan je termin kod doktora:  " + doktor);

                    foreach (Korisnik k in KorisniciStorage.Instance.korisnici)
                    {
                        if ((k.Ime + " " + k.Prezime) == pacijent)
                        {
                            k.Notifikacije.Add(n1);
                        }
                        if (k.Zvanje == "Sekretar")
                        {
                            k.Notifikacije.Add(n1);
                        }
                    }
                    
                }                
                TerminStorage.Instance.Read().Add(tempTermin);
                TerminStorage.Instance.Save();
                DoktoriStorage.Instance.Save();
                PacijentiStorage.Instance.Save();
            }
            else MessageBox.Show("Termin je vec zauzet");

        }

        public void ukloniTermin(Termin t)
        {
            TerminStorage.Instance.termini.Remove(t);
            t.doktor.termini.Remove(t);
            t.pacijent.termini.Remove(t);
            TerminStorage.Instance.Save();
            DoktoriStorage.Instance.Save();
            PacijentiStorage.Instance.Save();
            if (KorisniciStorage.Instance.ulogovaniKorisnik.Zvanje == "Pacijent")
            {
                Notifikacija n1 = new Notifikacija("Otkazan termin", t.ImePrezimePacijenta, "Otkazan je termin kod doktora:  " + t.ImePrezimeDoktora);

                foreach (Korisnik k in KorisniciStorage.Instance.korisnici)
                {
                    if (k.Zvanje == "Sekretar")
                    {
                        k.Notifikacije.Add(n1);
                    }
                    if ((k.Ime + " " + k.Prezime) == t.ImePrezimeDoktora)
                    {
                        k.Notifikacije.Add(n1);
                    }
                }
            }
            else if (KorisniciStorage.Instance.ulogovaniKorisnik.Zvanje == "Sekretar")
            {
                Notifikacija n1 = new Notifikacija("Otkazan termin", "Sekretar", "Otkazan je termin kod pacijenta:  " + t.ImePrezimePacijenta);
                Notifikacija n2 = new Notifikacija("Otkazan termin", "Sekretar", "Otkazan je termin kod doktora:  " + t.ImePrezimeDoktora);

                foreach (Korisnik k in KorisniciStorage.Instance.korisnici)
                {
                    if ((k.Ime + " " + k.Prezime) == t.ImePrezimePacijenta)
                    {
                        k.Notifikacije.Add(n2);
                    }
                    if ((k.Ime + " " + k.Prezime) == t.ImePrezimeDoktora)
                    {
                        k.Notifikacije.Add(n1);
                    }
                }

            }
            else
            {
                Notifikacija n1 = new Notifikacija("Otkazan termin", t.ImePrezimeDoktora, "Otkazan je termin kod pacijenta:  " + t.ImePrezimePacijenta);

                foreach (Korisnik k in KorisniciStorage.Instance.korisnici)
                {
                    if ((k.Ime + " " + k.Prezime) == t.ImePrezimePacijenta)
                    {
                        k.Notifikacije.Add(n1);
                    }
                    if (k.Zvanje == "Sekretar")
                    {
                        k.Notifikacije.Add(n1);
                    }
                }

            }
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
    }
}
