using BolnicaSims.DTO;
using BolnicaSims.Service;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BolnicaSims.Controller
{
    class DoktorController
    {
        private static DoktorController instance = null;
        public static DoktorController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DoktorController();
                }
                return instance;
            }
        }

        public void dodajDoktora(String username, String password, String ime, String prezime, String jmbg, String adresa, String telefon, Boolean specijalista, Boolean hirurg, DateTime datumRodjenja, String email, String specijalizacija)
        {
            DoktorService.Instance.dodajDoktora(username, password, ime, prezime, jmbg, adresa, telefon, specijalista, hirurg, datumRodjenja, email, specijalizacija);
        }
        public void izmeniDoktora(DoktorDTO doktor)
        {
            DoktorService.Instance.izmeniDoktora(doktor);
        }
        public Doktor GetDoktor(Korisnik korisnik)
        {
            return DoktorService.Instance.getKorisnikDoktor(korisnik);
        }
    }
}
