using BolnicaSims.Interface;
using BolnicaSims.Model;
using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace BolnicaSims.Storage
{
    [Serializable]
    class DoktoriStorage : IStorage
    {
        private static DoktoriStorage instance = null;
        public static DoktoriStorage Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DoktoriStorage();
                }
                return instance;
            }
        }

        private String FilePath = "doktorStorage.txt";

        public ObservableCollection<Doktor> doktori = new ObservableCollection<Doktor>();
        public ObservableCollection<String> doktoriImena = new ObservableCollection<String>();
        public ObservableCollection<String> doktoriAnketa = new ObservableCollection<String>();
        public ObservableCollection<Doktor> specijalisti = new ObservableCollection<Doktor>();
        public Doktor selektovaniDoktor = new Doktor();

        public DoktoriStorage()
        {
            this.Load();

            foreach (Doktor d in doktori)
            {
                doktoriImena.Add(d.korisnik.Ime + " " + d.korisnik.Prezime);
            }

            foreach(Doktor d in doktori)
            {
                if (d.Specijalista)
                {
                    specijalisti.Add(d);
                }
            }

        }

        public void Load()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
            doktori = (ObservableCollection<Doktor>)formatter.Deserialize(stream);
            stream.Close();
        }

        public void Save()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(FilePath, FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, doktori);
            stream.Close();
        }
    }
}
