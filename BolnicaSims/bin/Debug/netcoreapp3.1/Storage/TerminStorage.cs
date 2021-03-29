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
    [Serializable]
    public class TerminStorage
   {
           
        public List<Termin> termini;
        private String fileLocation = "terminStorage.txt";

        public TerminStorage()
        {

            termini = this.Load();
            /*termini.Add(new Termin() { IdTermina = "1", VremeTermina = new DateTime(2021, 3, 1, 7, 0, 0), ImePrezimeDoktora = "Petar Petrovic" });
            termini.Add(new Termin() { IdTermina = "5", VremeTermina = new DateTime(2021, 3, 25, 9, 0, 0), ImePrezimeDoktora = "Petar Petrovic" });
            termini.Add(new Termin() { IdTermina = "21", VremeTermina = new DateTime(2021, 4, 28, 11, 0, 0), ImePrezimeDoktora = "Nikola Nikolic" });

            this.Save();*/
        }

      public void Save()
      {
            // TODO: implement
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(fileLocation, FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, termini);
            stream.Close();
            

      }

        public List<Termin> Read()
        {
            return termini;
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
            Stream stream = new FileStream(fileLocation, FileMode.Open, FileAccess.Read);
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