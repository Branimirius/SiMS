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

            /*DateTime date1 = new DateTime(1988, 12, 25);
            DateTime date2 = new DateTime(1974, 11, 25);
            Korisnik k1 = new Korisnik("gorana123", "ivanovic123", "Gorana", "Ivanovic", "Sekretar", "1231245631231", date1, "Kupusinca 5", "06325221", "goranaivanovic@gmail.com");
            korisnici.Add(k1);
            Korisnik k2 = new Korisnik("ivan123", "ivanovic123", "Ivan", "Ivanovic", "Upravnik", "1231456789232", date2, "Resavska 15", "06434441", "ivanivanovic@gmail.com");
            korisnici.Add(k2);*/
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
