/***********************************************************************
 * Module:  Prostorija.cs
 * Author:  piwneuh
 * Purpose: Definition of the Class Prostorija
 ***********************************************************************/

using System;
using System.Collections.ObjectModel;

namespace Model
{
    [Serializable]
    public class Prostorija
   {

        public Prostorija(String tip, String sprat, String brojProstorije)
        {
            switch (tip)
            {
                case "Soba":
                    TipProstorije = TipProstorije.SOBA;
                    break;
                case "Ordinacija":
                    TipProstorije = TipProstorije.ORDINACIJA;
                    break;
                case "Operaciona sala":
                    TipProstorije = TipProstorije.OPERACIONA_SALA;
                    break;
                case "Magacin":
                    TipProstorije = TipProstorije.MAGACIN;
                    break;

                
            }
            

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
            if(IsReserved(this) == true)
            {
                Stanje = "Zauzeta";
            }
            else
            {
                Stanje = "Slobodna";
            }

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
      
      public Boolean IsReserved(Prostorija p)
      {
            return false;
      }
   
      public ObservableCollection<Inventar> inventar { get; set; }     
      public ObservableCollection<Inventar> termini { get; set; }
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
        



    }
}