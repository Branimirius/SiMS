using System;
using System.Collections.Generic;
using System.Text;
using BolnicaSims.Service;
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
        public void ukloniZaposlenog(Korisnik selektovani)
        {
            KorisnikService.Instance.ukloniZaposlenog(selektovani);
        }
        /*public void izmeniKorisnika(Korisnik korisnik)
        {
            KorisnikService.Instance.izmeniKorisnika(korisnik);
        }*/
    }
}
