/***********************************************************************
 * Module:  Pacijent.cs
 * Author:  piwneuh
 * Purpose: Definition of the Class Model.Pacijent
 ***********************************************************************/

using System;

namespace Model
{
    [Serializable]
    public class Pacijent
   {
      public Korisnik korisnik;
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
            this.termin.Add(newTermin);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveTermin(Termin oldTermin)
      {
         if (oldTermin == null)
            return;
         if (this.termin != null)
            if (this.termin.Contains(oldTermin))
               this.termin.Remove(oldTermin);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllTermin()
      {
         if (termin != null)
            termin.Clear();
      }
      public ZdravstveniKarton zdravstveniKarton;
   
   }
}