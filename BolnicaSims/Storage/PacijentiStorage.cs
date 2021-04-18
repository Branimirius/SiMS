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

    public List<String> findLogInfo()
    {
        List<String> ret = new List<String>();
        foreach (Pacijent p in this.pacijenti){
            ret.Add(p.korisnik.Username + p.korisnik.Password);
        }
        return ret;
    } 
}
}