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
    class DoktoriStorage
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

        public DoktoriStorage()
        {
            doktori = this.Load();
            DateTime date1 = new DateTime(1985, 12, 25);
            Korisnik k1 = new Korisnik("nikola123", "petrovic123", "Nikola", "Petrovic", "1231231231231", date1, "Kosovska 5", "06352221", "nikola.petrovic@gmail.com");
            Doktor d1 = new Doktor(k1);
            doktori.Add(d1);
            doktoriImena.Add(k1.Ime + " " + k1.Prezime);
            //this.Save();
           
        }
        public ObservableCollection<Doktor> Read()
        {
            return doktori;
        }

        public void Save()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(FilePath, FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, doktori);
            stream.Close();
        }

        public ObservableCollection<Doktor> Load()
        {
            // TODO: implement
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
            doktori = (ObservableCollection<Doktor>)formatter.Deserialize(stream);
            return doktori;

        }
    }
}
