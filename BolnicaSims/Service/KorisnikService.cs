using System;
using System.Collections.Generic;
using System.Text;
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
            switch(username, password)
            {
                case ("Gorana88", "12345"):
                    return 1;
                default:
                    break;
            }
            if(pacijentiLogInfo.Contains(username + password)){
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
                if(k.Username == username && k.Password == password){
                    tempKorisnik = k;
                }
            }

            KorisniciStorage.Instance.ulogovaniKorisnik = tempKorisnik;
            return tempKorisnik;
        }
    }
}
