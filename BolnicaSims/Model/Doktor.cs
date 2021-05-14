/***********************************************************************
 * Module:  Doktor.cs
 * Author:  piwneuh
 * Purpose: Definition of the Class Model.Doktor
 ***********************************************************************/

using BolnicaSims.Model;
using System;
using System.Collections.ObjectModel;

namespace Model
{
    [Serializable]
    public class Doktor
   {
      public Korisnik korisnik { get; set; }
      public ObservableCollection<Termin> termini { get; set; }
        public ObservableCollection<Lek> lekoviValidacija { get; set; }

        public Doktor(Korisnik korisnik)
        {
            this.korisnik = korisnik;
            this.termini = new ObservableCollection<Termin>();
        }
        public Doktor(Korisnik k, Boolean specijalista, Boolean hirurg, String specijalizacija) 
        {
            korisnik = k;
            Specijalista = specijalista;
            Hirurg = hirurg;
            termini = new ObservableCollection<Termin>();
            Specijalizacija = specijalizacija;
            lekoviValidacija = new ObservableCollection<Lek>();
        }
      public Doktor() { }
   
      public Boolean Specijalista { get; set; }
      public Boolean Hirurg { get; set; }
      public String Specijalizacija { get; set; }
        
      
        
      



      
    }
}