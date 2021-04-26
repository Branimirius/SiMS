/***********************************************************************
 * Module:  Doktor.cs
 * Author:  piwneuh
 * Purpose: Definition of the Class Model.Doktor
 ***********************************************************************/

using System;
using System.Collections.ObjectModel;

namespace Model
{
    [Serializable]
    public class Doktor
   {
      public Korisnik korisnik { get; set; }
      public ObservableCollection<Termin> termini { get; set; }

      public Doktor(Korisnik korisnik)
        {
            this.korisnik = korisnik;
            this.termini = new ObservableCollection<Termin>();
        }
      public Doktor(Korisnik k, Boolean specijalista, Boolean hirurg) 
        {
            korisnik = k;
            Specijalista = specijalista;
            Hirurg = hirurg;
            termini = new ObservableCollection<Termin>();
        }
        
   
      public Boolean Specijalista { get; set; }
      public Boolean Hirurg { get; set; }
      
        
      



      
    }
}