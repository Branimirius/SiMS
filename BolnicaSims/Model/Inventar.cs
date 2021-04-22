/***********************************************************************
 * Module:  Inventar.cs
 * Author:  piwneuh
 * Purpose: Definition of the Class Inventar
 ***********************************************************************/

using System;

namespace Model
{
    [Serializable]
    public class Inventar
   {
         public Inventar(String id, String naziv, String proizvodjac, String kolicina)
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
   
   }
}