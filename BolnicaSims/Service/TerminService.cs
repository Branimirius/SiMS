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

                termin.doktor.korisnik.Notifikacije.Add(n1);
            }
        }

        public void dodajTermin(String vreme, String doktor, String pacijent)
        {
            if (slobodanTermin(vreme, doktor) == true)
            {              
                Termin tempTermin = new Termin();
                tempTermin.IdTermina = GenID();
                tempTermin.VremeTermina = DateTime.Parse(vreme);

                foreach (Doktor d in DoktoriStorage.Instance.doktori)
                {
                    if ((d.korisnik.Ime + " " + d.korisnik.Prezime) == (doktor))
                    {
                        
                        tempTermin.doktori.Add(d);
                        tempTermin.ImePrezimeDoktora = d.korisnik.Ime + " " + d.korisnik.Prezime;
                    }
                }
                foreach (Pacijent p in PacijentiStorage.Instance.pacijenti)
                {
                    if ((p.korisnik.Ime + " " + p.korisnik.Prezime) == (pacijent))
                    {

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
                    Notifikacija n1 = new Notifikacija("Zakazan termin", "Sekretar", "Pomeren je termin kod doktora:  " + doktor);

                    foreach (Korisnik k in KorisniciStorage.Instance.korisnici)
                    {
                        if ((k.Ime + " " + k.Prezime) == pacijent)
                        {
                            k.Notifikacije.Add(n1);
                        }
                    }
                }
                else
                {
                    Notifikacija n1 = new Notifikacija("Zakazan termin", "Sekretar", "Pomeren je termin kod doktora:  " + doktor);

                    foreach (Korisnik k in KorisniciStorage.Instance.korisnici)
                    {
                        if ((k.Ime + " " + k.Prezime) == doktor)
                        {
                            k.Notifikacije.Add(n1);
                        }
                    }
                }
                TerminStorage.Instance.Read().Add(tempTermin);
                TerminStorage.Instance.Save();
            }
            else MessageBox.Show("Termin je vec zauzet");

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
            int a = int.Parse(TerminStorage.Instance.termini[TerminStorage.Instance.termini.Count - 1].IdTermina) + 1;
            return a.ToString();
        }
    }
}
