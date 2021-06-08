using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using BolnicaSims.DTO;
using BolnicaSims.Model;
using BolnicaSims.Storage;
using Model;

namespace BolnicaSims.Service
{
    class KorisnikService
    {
        private static KorisnikService instance = null;
        public static KorisnikService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new KorisnikService();
                }
                return instance;
            }
        }
        public List<String> pacijentiLogInfo = PacijentiStorage.Instance.findLogInfo();

        public int Login(string username, string password)
        {
            switch (username, password)
            {
                case ("Gorana88", "12345"):
                    return 1;
                default:
                    break;
            }
            if (pacijentiLogInfo.Contains(username + password)) {
                return 2;
            }
            else
            {
                return 3;
            }
        }

        public Korisnik Login2(string username, string password)
        {
            Korisnik tempKorisnik = new Korisnik();
            foreach (Korisnik k in KorisniciStorage.Instance.korisnici)
            {
                if (k.Username == username && k.Password == password) {
                    tempKorisnik = k;
                }
            }

            if (tempKorisnik.Ime == "") { MessageBox.Show("Pogresna sifra/korisnicko ime"); }
            KorisniciStorage.Instance.ulogovaniKorisnik = tempKorisnik;
            return tempKorisnik;
        }
        public void registrujKorisnika(Korisnik korisnik)
        {


            KorisniciStorage.Instance.Read().Add(korisnik);
            KorisniciStorage.Instance.Save();
        }
        public void registrujKorisnika(KorisnikDTO korisnik)
        {

            KorisniciStorage.Instance.Read().Add(new Korisnik(korisnik));
            KorisniciStorage.Instance.Save();
        }
        public void ukloniZaposlenog(Korisnik selektovani)
        {
            KorisniciStorage.Instance.korisnici.Remove(selektovani);
            KorisniciStorage.Instance.zaposleni.Remove(selektovani);
            DoktorService.Instance.ukloniDoktora(selektovani);
            KorisniciStorage.Instance.Save();
    
        }
        public ObservableCollection<Korisnik> getKorisnici()
        {
            return KorisniciStorage.Instance.korisnici;
        }
        public ObservableCollection<Korisnik> getZaposleni()
        {
            return KorisniciStorage.Instance.zaposleni;
        }
        public ObservableCollection<Recept> getRecepti()
        {
            return KorisniciStorage.Instance.recepti;
        }
        public Korisnik getUlogovaniKorisnik()
        {
            return KorisniciStorage.Instance.ulogovaniKorisnik;
        }
        public Korisnik getSelektovaniKorisnik()
        {
            return KorisniciStorage.Instance.selektovaniKorisnik;
        }
        public void setSelektovaniKorisnik(Korisnik korisnik)
        {
            KorisniciStorage.Instance.selektovaniKorisnik = korisnik;
        }


    }
}
