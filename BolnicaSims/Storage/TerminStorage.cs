/***********************************************************************
 * Module:  PregledStorage.cs
 * Author:  temerin
 * Purpose: Definition of the Class PregledStorage
 ***********************************************************************/

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Model
{
   public class TerminStorage
   {
        public List<Termin> termini;

      public bool Save()
      {
            // TODO: implement
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(FilePath, FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, termini);
            stream.Close();
            return true;

      }
      
      public bool Delete(Termin termin)
      {
         // TODO: implement
         return false;
      }
      
      public bool Update(String idTermina, Termin termin)
      {
         // TODO: implement
         return false;
      }
      
      public Termin Create(Termin noviTermin)
      {
         // TODO: implement
         return null;
      }
      
      public List<Termin> Load()
      {
            // TODO: implement
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
            termini = (List<Termin>)formatter.Deserialize(stream);
            return termini;

      }
      
      public Termin Find(String idTermina)
      {
         // TODO: implement
         return null;
      }
   
      private String FilePath;
   

    }
}