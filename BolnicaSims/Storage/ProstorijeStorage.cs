/***********************************************************************
 * Module:  StorageProstorije.cs
 * Author:  piwneuh
 * Purpose: Definition of the Class StorageProstorije
 ***********************************************************************/

using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq;

namespace Model
{
   public class ProstorijeStorage
   {

        private static ProstorijeStorage instance = null; 
        public static ProstorijeStorage Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ProstorijeStorage();
                }
                return instance;
            }
        }

        public ObservableCollection<Prostorija> prostorije = new ObservableCollection<Prostorija>();
        private String fileLocation = "prostorijeStorage.txt";

        public ProstorijeStorage()
        {
            prostorije = this.Load();
            /*Prostorija p1 = new Prostorija() { IdProstorije = "33C", Sprat = 3, BrojProstorije = 15 };
            prostorije.Add(p1);
            this.Save();*/
        }

        public void Save()
      {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(fileLocation, FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, prostorije);
            stream.Close();
        }

        public ObservableCollection<Prostorija> Read()
        {
            return prostorije;
        }
        public bool Delete(Prostorija prostorija)
      {
         // TODO: implement
         return false;
      }
      
      public bool Update(String idProstorije, Prostorija prostorija)
      {
         // TODO: implement
         return false;
      }
      
      public Prostorija Create(Prostorija novaProstorija)
      {
         // TODO: implement
         return null;
      }
      
      public ObservableCollection<Prostorija> Load()
      {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(fileLocation, FileMode.Open, FileAccess.Read);
            prostorije = (ObservableCollection<Prostorija>)formatter.Deserialize(stream);
            return prostorije;

        }

      public String GenID()
        {
            int a = int.Parse(prostorije[prostorije.Count - 1].IdProstorije) + 1;
            return a.ToString();
        }

        public Prostorija Find(String IdProstorije)
      {
         // TODO: implement
         return null;
      }
   
   }
}