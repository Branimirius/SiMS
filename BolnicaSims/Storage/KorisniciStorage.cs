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
    class KorisniciStorage
    {
        private static KorisniciStorage instance = null;
        public static KorisniciStorage Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new KorisniciStorage();
                }
                return instance;
            }
        }

        private String FilePath = "korisniciStorage.txt";
        public ObservableCollection<Korisnik> korisnici = new ObservableCollection<Korisnik>();

        public KorisniciStorage()
        {
            korisnici = this.Load();
        }
        public ObservableCollection<Korisnik> Read()
        {
            return korisnici;
        }
        public void Save()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(FilePath, FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, korisnici);
            stream.Close();
        }

        public ObservableCollection<Korisnik> Load()
        {
            // TODO: implement
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
            korisnici = (ObservableCollection<Korisnik>)formatter.Deserialize(stream);
            return korisnici;

        }
    }
}
