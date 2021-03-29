/***********************************************************************
 * Module:  StoragePacijenti.cs
 * Author:  brani
 * Purpose: Definition of the Class StoragePacijenti
 ***********************************************************************/

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Model
{
   public class PacijentiStorage
   {
      public bool Save()
      {
         // TODO: implement
         return false;
      }
      
      public bool Delete(Pacijent pacijent)
      {
         // TODO: implement
         return false;
      }
      
      public bool Update(String BrojKartona, Pacijent pacijent)
      {
         // TODO: implement
         return false;
      }
      
      public Pacijent Create(Pacijent noviPacijent)
      {
         // TODO: implement
         return null;
      }
      
      public void Load()
      {
         // TODO: implement
      }
      
      public Pacijent Find(String BrojKartona)
      {
         // TODO: implement
         return null;
      }
   
      private String FilePath = $"";
      private System.Collections.Generic.List<Pacijent> pacijenti = new List<Pacijent>();

    }
}