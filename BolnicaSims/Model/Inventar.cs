/***********************************************************************
 * Module:  Inventar.cs
 * Author:  piwneuh
 * Purpose: Definition of the Class Inventar
 ***********************************************************************/

using BolnicaSims.Controller;
using System;

namespace Model
{
    [Serializable]
    public class Inventar
   {
         public Inventar(String id, String naziv, String proizvodjac, String kolicina, Boolean staticki)
         {
               IdInventara = id;
               Naziv = naziv;
               Proizvodjac = proizvodjac;
               if((kolicina == "0") || (kolicina == ""))
               {
                   Kolicina = 0;
               }
               else
               {
                   Kolicina = int.Parse(kolicina);
               }
               prostorija = ProstorijaController.Instance.getProstorija(1, 1);
               Staticki = staticki;
         }
        public Inventar() { }

        public Inventar(Inventar i)
        {
            IdInventara = i.IdInventara;
            Naziv = i.Naziv;
            Proizvodjac = i.Proizvodjac;
            Kolicina = i.Kolicina;
            prostorija = i.prostorija;
            Staticki = i.Staticki;
        }
          public String IdInventara
          {
             get
             ;
             set
             ;
          }

        public String Naziv
        {
            get
            ;
            set
            ;
         }

        public String Proizvodjac
        {
           get
           ;
           set
           ;
        }

        public int Kolicina
        {
           get
           ;
           set
           ;
        }
        public Prostorija prostorija { get; set; }
        public Boolean Staticki { get; set; }
   
   }
}