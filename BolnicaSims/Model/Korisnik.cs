/***********************************************************************
 * Module:  Class6.cs
 * Author:  piwneuh
 * Purpose: Definition of the Class Class6
 ***********************************************************************/

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


        public ObservableCollection<Notifikacija> Notifikacije;
        
        

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
        }

        public Korisnik()
        {
        }

    }

}