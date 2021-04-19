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
        public Korisnik ulogovaniKorisnik = new Korisnik();

        public KorisniciStorage()
        {
            korisnici = this.Load();
            //DateTime date1 = new DateTime(1985, 12, 25);
            //DateTime date2 = new DateTime(1974, 11, 25);
            //Korisnik k1 = new Korisnik("nikola123", "petrovic123", "Nikola", "Petrovic", "Doktor", "1231231231231", date1, "Kosovska 5", "06352221", "nikola.petrovic@gmail.com");
            //korisnici.Add(k1);
            //Korisnik k2 = new Korisnik("marko123", "markovic123", "Marko", "Markovic", "Doktor", "1231231231232", date2, "Resavska 5", "06432221", "marko.markovic@gmail.com");
            //korisnici.Add(k2);
            //this.Save();
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
