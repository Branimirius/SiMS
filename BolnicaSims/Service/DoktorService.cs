using BolnicaSims.Storage;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BolnicaSims.Service
{
    class DoktorService
    {
        private static DoktorService instance = null;
        public static DoktorService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DoktorService();
                }
                return instance;
            }
        }

        public Doktor getUlogovaniDoktor(Korisnik ulogovaniKorisnik)
        {
            foreach (Doktor d in DoktoriStorage.Instance.doktori)
            {
                if (d.korisnik.Username+d.korisnik.Password == ulogovaniKorisnik.Username+ulogovaniKorisnik.Password)
                {
                    return d;
                }
            }
            return null;

        }
        public Doktor getDoktor(Doktor doktor)
        {
            foreach(Doktor d in DoktoriStorage.Instance.doktori)
            {
                if(d.korisnik.Jmbg == doktor.korisnik.Jmbg)
                {
                    return d;
                }
            }
            return null;
        }
        public Doktor getDoktor(String doktor)
        {
            foreach (Doktor d in DoktoriStorage.Instance.doktori)
            {
                if ((d.korisnik.Ime + " " + d.korisnik.Prezime) == doktor)
                {
                    return d;
                }
            }
            return null;
        }
        public void dodajDoktora(String username, String password, String ime, String prezime, String jmbg, String adresa, String telefon, Boolean specijalista, Boolean hirurg, DateTime datumRodjenja, String email)
        {
            Korisnik k = new Korisnik(username, password, ime, prezime, "Doktor", jmbg, datumRodjenja, adresa, telefon, email);
            Doktor tempDoktor = new Doktor(k, specijalista, hirurg);
            DoktoriStorage.Instance.Read().Add(tempDoktor);
            DoktoriStorage.Instance.doktoriImena.Add(ime + " " + prezime);
            KorisniciStorage.Instance.Read().Add(k);
            KorisniciStorage.Instance.zaposleni.Add(k);
            
            KorisniciStorage.Instance.Save();
            DoktoriStorage.Instance.Save();
        }
        public void ukloniDoktora(Korisnik selektovani)
        {
            foreach(Doktor d in DoktoriStorage.Instance.doktori)
            {
                if(selektovani == d.korisnik)
                {
                    DoktoriStorage.Instance.doktori.Remove(d);
                    DoktoriStorage.Instance.doktoriImena.Remove(d.korisnik.Ime + " " + d.korisnik.Prezime);
                    DoktoriStorage.Instance.Save();
                }
            }
        }
        public void ukloniDoktora(Doktor selektovani)
        {
            DoktoriStorage.Instance.doktori.Remove(selektovani);
            DoktoriStorage.Instance.Save();
        }

    }
}
