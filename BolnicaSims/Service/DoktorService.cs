using BolnicaSims.DTO;
using BolnicaSims.Model;
using BolnicaSims.Storage;
using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        public Doktor getKorisnikDoktor(Korisnik korisnik)
        {
            foreach (Doktor d in DoktoriStorage.Instance.doktori)
            {
                if (d.korisnik.Jmbg == korisnik.Jmbg)
                {
                    return d;
                }
            }
            return null;

        }
        public Doktor getDoktorJmbg(String jmbg)
        {
            foreach (Doktor d in DoktoriStorage.Instance.doktori)
            {
                if (d.korisnik.Jmbg == jmbg)
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
        public void dodajDoktora(String username, String password, String ime, String prezime, String jmbg, String adresa, String telefon, Boolean specijalista, Boolean hirurg, DateTime datumRodjenja, String email, String specijalizacija)
        {
            Korisnik k = new Korisnik(username, password, ime, prezime, "Doktor", jmbg, datumRodjenja, adresa, telefon, email);
            Doktor tempDoktor = new Doktor(k, specijalista, hirurg, specijalizacija);
            DoktoriStorage.Instance.Read().Add(tempDoktor);
            DoktoriStorage.Instance.doktoriImena.Add(ime + " " + prezime);
            KorisniciStorage.Instance.Read().Add(k);
            KorisniciStorage.Instance.zaposleni.Add(k);
            
            KorisniciStorage.Instance.Save();
            DoktoriStorage.Instance.Save();
        }
        public void izmeniDoktora(DoktorDTO doktor)
        {
            for(int i = 0; i < DoktoriStorage.Instance.doktori.Count; i++)            
            {
                if(DoktoriStorage.Instance.doktori[i].korisnik.Jmbg == doktor.korisnik.Jmbg)
                {
                    DoktoriStorage.Instance.doktori[i].korisnik.Ime = doktor.korisnik.Ime;
                    DoktoriStorage.Instance.doktori[i].korisnik.Prezime = doktor.korisnik.Prezime;                    
                    DoktoriStorage.Instance.doktori[i].korisnik.Adresa = doktor.korisnik.Adresa;
                    DoktoriStorage.Instance.doktori[i].korisnik.KontaktTelefon = doktor.korisnik.KontaktTelefon;
                    DoktoriStorage.Instance.doktori[i].korisnik.Email = doktor.korisnik.Email;
                    DoktoriStorage.Instance.doktori[i].korisnik.Username = doktor.korisnik.Username;
                    DoktoriStorage.Instance.doktori[i].korisnik.Password = doktor.korisnik.Password;
                    DoktoriStorage.Instance.doktori[i].Specijalizacija = doktor.Specijalizacija;
                }
            }
            DoktoriStorage.Instance.Save();
        }
        public void ukloniDoktora(Korisnik selektovani)
        {
            DoktoriStorage.Instance.doktori.Remove(getKorisnikDoktor(selektovani));
            DoktoriStorage.Instance.doktoriImena.Remove(selektovani.Ime + " " + selektovani.Prezime);
            DoktoriStorage.Instance.Save();
            
        }
        public void dodajNevalidanLek(Lek lek, ObservableCollection<Doktor> doktori)
        {
            foreach(Doktor d in doktori)
            {
                getDoktorJmbg(d.korisnik.Jmbg).lekoviValidacija.Add(lek);
            }
            DoktoriStorage.Instance.Save();
        }
        public void ukloniNevalidanLek(Lek lek)
        {
            foreach (Doktor d in DoktoriStorage.Instance.doktori)
            {
                if (d.lekoviValidacija.Contains(lek))
                {
                    getDoktorJmbg(d.korisnik.Jmbg).lekoviValidacija.Remove(lek);
                }
                
            }
            DoktoriStorage.Instance.Save();
        }
        public ObservableCollection<Doktor> getDoktori()
        {
            return DoktoriStorage.Instance.doktori;
        }
        public ObservableCollection<String> getDoktoriImena()
        {
            return DoktoriStorage.Instance.doktoriImena;
        }
        public ObservableCollection<String> getDoktoriAnketa()
        {
            return DoktoriStorage.Instance.doktoriAnketa;
        }
        public ObservableCollection<Doktor> getSpecijalisti()
        {
            return DoktoriStorage.Instance.specijalisti;
        }
        public Doktor getSelektovaniDoktor()
        {
            return DoktoriStorage.Instance.selektovaniDoktor;
        }
        public void setSelektovaniDoktor(Doktor doktor)
        {
            DoktoriStorage.Instance.selektovaniDoktor = doktor;
        }

    }
}
