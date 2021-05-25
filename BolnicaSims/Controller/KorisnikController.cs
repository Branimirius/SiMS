using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using BolnicaSims.DTO;
using BolnicaSims.Model;
using BolnicaSims.Service;
using BolnicaSims.Storage;
using Model;

namespace BolnicaSims.Controller
{
    class KorisnikController
    {
        private static KorisnikController instance = null;
        public static KorisnikController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new KorisnikController();
                }
                return instance;
            }
        }
         public int Login(string username, string password)
        {
            return KorisnikService.Instance.Login(username, password);
        }

        public Korisnik Login2(string username, string password)
        {
            return KorisnikService.Instance.Login2(username, password);
        }
        public void registrujKorisnika(Korisnik korisnik)
        {
            KorisnikService.Instance.registrujKorisnika(korisnik);
        }
        public void registrujKorisnika(KorisnikDTO korisnik)
        {
            KorisnikService.Instance.registrujKorisnika(korisnik);
        }
        public void ukloniZaposlenog(Korisnik selektovani)
        {
            KorisnikService.Instance.ukloniZaposlenog(selektovani);
        }
        
        public ObservableCollection<Korisnik> getKorisnici()
        {
            return KorisnikService.Instance.getKorisnici();
        }
        public ObservableCollection<Korisnik> getZaposleni()
        {
            return KorisnikService.Instance.getZaposleni();
        }
        public ObservableCollection<Recept> getRecepti()
        {
            return KorisnikService.Instance.getRecepti();
        }
        public Korisnik getUlogovaniKorisnik()
        {
            return KorisnikService.Instance.getUlogovaniKorisnik();
        }
        public Korisnik getSelektovaniKorisnik()
        {
            return KorisnikService.Instance.getSelektovaniKorisnik();
        }
        public void setSelektovaniKorisnik(Korisnik korisnik)
        {
            KorisnikService.Instance.setSelektovaniKorisnik(korisnik);
        }
    }
}
