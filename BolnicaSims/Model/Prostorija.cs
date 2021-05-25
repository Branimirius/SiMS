/***********************************************************************
 * Module:  Prostorija.cs
 * Author:  piwneuh
 * Purpose: Definition of the Class Prostorija
 ***********************************************************************/

using BolnicaSims.Model;
using System;
using System.Collections.ObjectModel;

namespace Model
{
    [Serializable]
    public class Prostorija
    {

        public Prostorija(TipProstorije tip, String sprat, String brojProstorije)
        {
            
            TipProstorije = tip;

            if (sprat != "")
            {
                Sprat = int.Parse(sprat);
            }
            else
            {
                Sprat = 0;
            }

            if (brojProstorije != "")
            {
                BrojProstorije = int.Parse(brojProstorije);
            }
            else
            {
                BrojProstorije = 0;
            }          
            Stanje = "Slobodna";          
            inventar = new ObservableCollection<Inventar>();
            termini = new ObservableCollection<Termin>();
            renoviranja = new ObservableCollection<Renoviranje>();
            susedneProstorije = new ObservableCollection<String>();
        }

        public Prostorija() { }
        public void rezervisiProstoriju(Prostorija p)
        {
            // TODO: implement
        }

        public void OslobodiProsotriju(Prostorija p)
        {
            // TODO: implement
        }
       
        public ObservableCollection<Inventar> inventar { get; set; }
        public ObservableCollection<Termin> termini { get; set; }
        public ObservableCollection<Renoviranje> renoviranja { get; set; }
        public ObservableCollection<String> susedneProstorije { get; set; }
        public int Sprat
        {
         get
         ;
         set
         ;
        }

        public int BrojProstorije
        {
         get
         ;
         set
         ;
        }       
      
      public TipProstorije TipProstorije
      {
         get
         ;
         set
         ;
      }
      public String Stanje
      {
          get
          ;
          set
          ;
      }
      public String IdProstorije { get; set; }
      public String Naziv { get; set; }

        public override string ToString()
        {
            return Naziv ;
        }


    }
}