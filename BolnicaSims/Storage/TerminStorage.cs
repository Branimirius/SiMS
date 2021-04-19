/***********************************************************************
 * Module:  PregledStorage.cs
 * Author:  temerin
 * Purpose: Definition of the Class PregledStorage
 ***********************************************************************/

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Model
{
    [Serializable]
    public class TerminStorage
   {
        private static TerminStorage instance = null;
        public static TerminStorage Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TerminStorage();
                }
                return instance;
            }
        }

        public ObservableCollection<Termin> termini = new ObservableCollection<Termin>();
        public Termin selektovanTermin;

        private String fileLocation = "terminStorage.txt";

        public TerminStorage()
        {

             termini = this.Load();


        }


       

        public void Save()
      {
            // TODO: implement
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(fileLocation, FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, termini);
            stream.Close();
            

      }

        public ObservableCollection<Termin> Read()
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

        public ObservableCollection<Termin> Load()
      {
            // TODO: implement
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(fileLocation, FileMode.Open, FileAccess.Read);
            termini = (ObservableCollection<Termin>)formatter.Deserialize(stream);
            return termini;

      }
      
      public Termin Find(String idTermina)
      {
         // TODO: implement
         return null;
      }
   
    }
}