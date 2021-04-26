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
                if (d.korisnik == ulogovaniKorisnik)
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
                if(d == doktor)
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

    }
}
