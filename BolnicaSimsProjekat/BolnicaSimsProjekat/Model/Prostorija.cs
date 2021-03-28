/***********************************************************************
 * Module:  Prostorija.cs
 * Author:  piwneuh
 * Purpose: Definition of the Class Prostorija
 ***********************************************************************/

using System;

namespace Model
{
   public class Prostorija
   {
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
         // TODO: implement
         return false;
      }
   
      public System.Collections.ArrayList inventar;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetInventar()
      {
         if (inventar == null)
            inventar = new System.Collections.ArrayList();
         return inventar;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetInventar(System.Collections.ArrayList newInventar)
      {
         RemoveAllInventar();
         foreach (Inventar oInventar in newInventar)
            AddInventar(oInventar);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddInventar(Inventar newInventar)
      {
         if (newInventar == null)
            return;
         if (this.inventar == null)
            this.inventar = new System.Collections.ArrayList();
         if (!this.inventar.Contains(newInventar))
            this.inventar.Add(newInventar);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveInventar(Inventar oldInventar)
      {
         if (oldInventar == null)
            return;
         if (this.inventar != null)
            if (this.inventar.Contains(oldInventar))
               this.inventar.Remove(oldInventar);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllInventar()
      {
         if (inventar != null)
            inventar.Clear();
      }
      public System.Collections.ArrayList termin;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetTermin()
      {
         if (termin == null)
            termin = new System.Collections.ArrayList();
         return termin;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetTermin(System.Collections.ArrayList newTermin)
      {
         RemoveAllTermin();
         foreach (Termin oTermin in newTermin)
            AddTermin(oTermin);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddTermin(Termin newTermin)
      {
         if (newTermin == null)
            return;
         if (this.termin == null)
            this.termin = new System.Collections.ArrayList();
         if (!this.termin.Contains(newTermin))
         {
            this.termin.Add(newTermin);
            newTermin.SetProstorija(this);      
         }
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveTermin(Termin oldTermin)
      {
         if (oldTermin == null)
            return;
         if (this.termin != null)
            if (this.termin.Contains(oldTermin))
            {
               this.termin.Remove(oldTermin);
               oldTermin.SetProstorija((Prostorija)null);
            }
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllTermin()
      {
         if (termin != null)
         {
            System.Collections.ArrayList tmpTermin = new System.Collections.ArrayList();
            foreach (Termin oldTermin in termin)
               tmpTermin.Add(oldTermin);
            termin.Clear();
            foreach (Termin oldTermin in tmpTermin)
               oldTermin.SetProstorija((Prostorija)null);
            tmpTermin.Clear();
         }
      }
   
      private String IdProstorije
      {
         get
         ;
         set
         ;
      }
      
      private int Sprat
      {
         get
         ;
         set
         ;
      }
      
      private int BrojProstorije
      {
         get
         ;
         set
         ;
      }
      
      private DateTime RezervisanaOd
      {
         get
         ;
         set
         ;
      }
      
      private DateTime RezervisanaDo
      {
         get
         ;
         set
         ;
      }
      
      private TipProstorije TipProstorije
      {
         get
         ;
         set
         ;
      }
   
   }
}