/***********************************************************************
 * Module:  StoragePacijenti.cs
 * Author:  brani
 * Purpose: Definition of the Class StoragePacijenti
 ***********************************************************************/

using BolnicaSims.Model;
using BolnicaSims.Storage;
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
        public ObservableCollection<String> pacijentiImena = new ObservableCollection<String>();
        public Pacijent selektovanPacijent = new Pacijent();
        public ObservableCollection<Recept> recepti = new ObservableCollection<Recept>();


        public PacijentiStorage()
        {

            pacijenti = this.Load();
            /*
            ZdravstveniKarton zk1 = new ZdravstveniKarton("Djani", "03020", "3023", "M", "", "");
            ZdravstveniKarton zk2 = new ZdravstveniKarton("Zeki", "03021", "3024", "M", "", "");
            Pacijent p1 = new Pacijent();
            p1.zdravstveniKarton = zk1;
            p1.korisnik = KorisniciStorage.Instance.korisnici[2];
            Pacijent p2 = new Pacijent();
            p2.zdravstveniKarton = zk2;
            p2.korisnik = KorisniciStorage.Instance.korisnici[3];
            pacijenti.Add(p1);
            pacijenti.Add(p2);
            */
            Notifikacija n1 = new Notifikacija("Dobrodosli", "Dev Team 28", "Zelimo vam dobrodoslicu u sistem");
            foreach (Pacijent p in pacijenti)
            {
                pacijentiImena.Add(p.korisnik.Ime + " " + p.korisnik.Prezime);
                p.korisnik.Notifikacije = new ObservableCollection<Notifikacija>();
                p.korisnik.Notifikacije.Add(n1);
            }
            //this.Save();
                      

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
        stream.Close();
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