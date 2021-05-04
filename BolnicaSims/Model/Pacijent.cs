/***********************************************************************
 * Module:  Pacijent.cs
 * Author:  piwneuh
 * Purpose: Definition of the Class Model.Pacijent
 ***********************************************************************/

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
    }
}