using System;
using System.Collections.Generic;
using System.Text;

namespace BolnicaSims.DTO
{
    public class DoktorDTO
    {
        public KorisnikDTO korisnik { get; set; }       
        public String Specijalizacija { get; set; }

        public DoktorDTO(KorisnikDTO korisnik, string specijalizacija)
        {
            this.korisnik = korisnik;
            Specijalizacija = specijalizacija;
        }
    }
}
