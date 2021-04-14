/***********************************************************************
 * Module:  StoragePacijenti.cs
 * Author:  brani
 * Purpose: Definition of the Class StoragePacijenti
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
    public class PacijentiStorage
   {

        private static PacijentiStorage instance = null;
        public static PacijentiStorage Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PacijentiStorage();
                }
                return instance;
            }
        }

        private String FilePath = "pacijentStorage.txt";
        public ObservableCollection<Pacijent> pacijenti = new ObservableCollection<Pacijent>();
        
        
        public PacijentiStorage()
        {

           pacijenti = this.Load();
           
             /*Korisnik k1 = new Korisnik("baki99", "asdfghj", "Bogdan", "Mahua", "343434", new DateTime(2008, 04, 14), "afwfaw", "0983833", "vukureiu");

             ZdravstveniKarton zk1 = new ZdravstveniKarton("Cale", "234", "1234", "M");
             Pacijent p1 = new Pacijent(k1, zk1);

             Korisnik k2 = new Korisnik("zeks", "asdfghj", "Zeljkon", "Mahua", "343434", new DateTime(2008, 04, 14), "afwfaw", "0983833", "vukureiu");

             ZdravstveniKarton zk2 = new ZdravstveniKarton("Rale", "254", "1243", "M");
             Pacijent p2 = new Pacijent(k2, zk2);

             Pacijent p3 = new Pacijent();
             p3.korisnik = k1;
             p3.zdravstveniKarton = zk1;


             pacijenti.Add(p1);
             pacijenti.Add(p2);
             pacijenti.Add(p3);

             this.Save();*/
        }
        public void Save()
      {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(FilePath, FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, pacijenti);
            stream.Close();
        }

        public ObservableCollection<Pacijent> Read()
        {
            return pacijenti;
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

        public ObservableCollection<Pacijent> Load()
      {
            // TODO: implement
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
            pacijenti = (ObservableCollection<Pacijent>)formatter.Deserialize(stream);
            return pacijenti;

        }

        public Pacijent Find(String BrojKartona)
      {
         // TODO: implement
         return null;
      }
   
     

     
    }
}