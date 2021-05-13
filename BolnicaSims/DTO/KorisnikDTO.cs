using System;
using System.Collections.Generic;
using System.Text;

namespace BolnicaSims.DTO
{
    public class KorisnikDTO
    {
        public String Username { get; set; }

        public String Password { get; set; }

        public String Ime { get; set; }

        public String Prezime { get; set; }

        public String Jmbg { get; set; }

        public DateTime DatumRodjenja { get; set; }

        public String Adresa { get; set; }

        public String KontaktTelefon { get; set; }

        public String Email { get; set; }

        public String Zvanje { get; set; }

        public KorisnikDTO(string username, string password, string ime, string prezime, string jmbg, DateTime datumRodjenja, string adresa, string kontaktTelefon, string email, string zvanje)
        {
            Username = username;
            Password = password;
            Ime = ime;
            Prezime = prezime;
            Jmbg = jmbg;
            DatumRodjenja = datumRodjenja;
            Adresa = adresa;
            KontaktTelefon = kontaktTelefon;
            Email = email;
            Zvanje = zvanje;
        }

        public KorisnikDTO(string username, string password, string ime, string prezime, string jmbg, string adresa, string kontaktTelefon, string email)
        {
            Username = username;
            Password = password;
            Ime = ime;
            Prezime = prezime;
            Jmbg = jmbg;
            Adresa = adresa;
            KontaktTelefon = kontaktTelefon;
            Email = email;
        }
    }
}
