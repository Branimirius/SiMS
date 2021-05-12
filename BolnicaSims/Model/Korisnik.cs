/***********************************************************************
 * Module:  Class6.cs
 * Author:  piwneuh
 * Purpose: Definition of the Class Class6
 ***********************************************************************/

using BolnicaSims.DTO;
using BolnicaSims.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Model
{
    [Serializable]
    public class Korisnik
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

        public String ImePrezime { get; set; }


        public ObservableCollection<Notifikacija> Notifikacije { get; set; }
        
        

        public Korisnik(String username, String password, String ime, String prezime, String zvanje, String jmbg, DateTime datumRodnjenja, String adresa, String kontaktTelefon, String email)

        {
            Username = username;
            Password = password;
            Ime = ime;
            Prezime = prezime;
            Zvanje = zvanje;
            Jmbg = jmbg;
            DatumRodjenja = datumRodnjenja;
            Adresa = adresa;
            Email = email;
            ImePrezime = ime + " " + prezime;
            Notifikacije = new ObservableCollection<Notifikacija>();
        }

        public Korisnik()
        {
        }
        public Korisnik(KorisnikDTO korisnik)
        {
            Username = korisnik.Username;
            Password = korisnik.Password;
            Ime = korisnik.Ime;
            Prezime = korisnik.Prezime;
            Zvanje = korisnik.Zvanje;
            Jmbg = korisnik.Jmbg;
            DatumRodjenja = korisnik.DatumRodjenja;
            Adresa = korisnik.Adresa;
            Email = korisnik.Email;
            ImePrezime = korisnik.Ime + " " + korisnik.Prezime;
            Notifikacije = new ObservableCollection<Notifikacija>();
        }
    }

}