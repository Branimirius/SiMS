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
            Notifikacija n1 = new Notifikacija("Dobrodosli", "Dev Team 28", "Zelimo vam dobrodoslicu u sistem");
            foreach (Doktor d in doktori)
            {
                doktoriImena.Add(d.korisnik.Ime + " " + d.korisnik.Prezime);
                d.korisnik.Notifikacije = new ObservableCollection<Notifikacija>();
                d.korisnik.Notifikacije.Add(n1);
            }

            Console.Write(doktori[0].korisnik.Ime);
            /*DateTime date1 = new DateTime(1985, 12, 25);
            DateTime date2 = new DateTime(1974, 11, 25);
            Korisnik k1 = new Korisnik("nikola123", "petrovic123", "Nikola", "Petrovic", "Doktor", "1231231231231", date1, "Kosovska 5", "06352221", "nikola.petrovic@gmail.com");
            Doktor d1 = new Doktor(k1);
            doktori.Add(d1);
            doktoriImena.Add(k1.Ime + " " + k1.Prezime);

            Korisnik k2 = new Korisnik("marko123", "markovic123", "Marko", "Markovic", "Doktor", "1231231231232", date2, "Resavska 5", "06432221", "marko.markovic@gmail.com");
            Doktor d2 = new Doktor(k2);
            doktori.Add(d2);
            doktoriImena.Add(k2.Ime + " " + k2.Prezime);
            this.Save();*/

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
