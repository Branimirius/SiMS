using BolnicaSims.Service;
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

        public void dodajDoktora(String username, String password, String ime, String prezime, String jmbg, String adresa, String telefon, Boolean specijalista, Boolean hirurg, DateTime datumRodjenja, String email)
        {
            DoktorService.Instance.dodajDoktora(username, password, ime, prezime, jmbg, adresa, telefon, specijalista, hirurg, datumRodjenja, email);
        }
    }
}
