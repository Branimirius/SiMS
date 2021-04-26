/***********************************************************************
 * Module:  Pacijent.cs
 * Author:  piwneuh
 * Purpose: Definition of the Class Model.Pacijent
 ***********************************************************************/

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
       
      

      public Pacijent(Korisnik korisnik, ZdravstveniKarton zdravstveniKarton)
      {
            this.korisnik = korisnik;
            this.zdravstveniKarton = zdravstveniKarton;
            termini =new ObservableCollection<Termin>();
      }

      public Pacijent()
      {
            korisnik = null;
            zdravstveniKarton = null;
            termini = new ObservableCollection<Termin>();
      }
    }
}