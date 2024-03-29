/***********************************************************************
 * Module:  Pacijent.cs
 * Author:  piwneuh
 * Purpose: Definition of the Class Model.Pacijent
 ***********************************************************************/

using BolnicaSims.DTO;
using BolnicaSims.Model;
using System;
using System.Collections.ObjectModel;

namespace Model
{
    [Serializable]
    public class Pacijent
    {
      public Korisnik korisnik { get; set; }      
      public ZdravstveniKarton zdravstveniKarton { get; set; }
      public ObservableCollection<Termin> termini { get; set; }

        public ObservableCollection<Recept> recepti { get; set; }

        public int brojOdradjenihPregleda { get; set; }

        public bool isBanned { get; set; }

        public int brojZakazivanja { get; set; }
        public DateTime vremeBanovanja { get; set; }

        public Pacijent(Korisnik korisnik, ZdravstveniKarton zdravstveniKarton)
        {
            this.korisnik = korisnik;
            this.zdravstveniKarton = zdravstveniKarton;
            termini =new ObservableCollection<Termin>();
            recepti = new ObservableCollection<Recept>();
            brojOdradjenihPregleda = 0;
        }

      public Pacijent()
      {
            isBanned = false;
            brojOdradjenihPregleda = 0;
            korisnik = null;
            zdravstveniKarton = null;
            termini = new ObservableCollection<Termin>();
            recepti = new ObservableCollection<Recept>();
      }
        public Pacijent(PacijentDTO pacijent)
        {
            isBanned = false;
            brojOdradjenihPregleda = 0;
            termini = new ObservableCollection<Termin>();
            recepti = new ObservableCollection<Recept>();
            this.korisnik = new Korisnik(pacijent.korisnik);
            this.zdravstveniKarton = new ZdravstveniKarton(pacijent.ImeRoditelja, pacijent.BrojKartona, pacijent.BrojZdravstveneKnjizice, pacijent.PolString, pacijent.Anamneza, pacijent.Alergije);
        }

        public override string ToString()
        {
            return korisnik.Ime + " " + korisnik.Prezime;
        }

    }
}