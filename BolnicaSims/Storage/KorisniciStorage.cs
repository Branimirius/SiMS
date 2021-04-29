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
    public class KorisniciStorage
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
        public ObservableCollection<Korisnik> zaposleni = new ObservableCollection<Korisnik>();
        public ObservableCollection<Recept> recepti = new ObservableCollection<Recept>();
        public Korisnik ulogovaniKorisnik = new Korisnik();
        public Korisnik selektovaniKorisnik = new Korisnik();
        public KorisniciStorage()
        {
            korisnici = this.Load();

            

            /*
            DateTime date1 = new DateTime(1985, 12, 25);
            DateTime date2 = new DateTime(1974, 11, 25);
            Korisnik k1 = new Korisnik("nikola123", "petrovic123", "Nikola", "Petrovic", "Doktor", "1231237771231", date1, "Kosovska 5", "06352221", "nikola.petrovic@gmail.com");
            korisnici.Add(k1);
            Korisnik k2 = new Korisnik("marko123", "markovic123", "Marko", "Markovic", "Doktor", "1231245631232", date2, "Resavska 5", "06432221", "marko.markovic@gmail.com");
            korisnici.Add(k2);
           
            Korisnik k3 = new Korisnik("bogdan123", "mahua123", "Bogdan", "Mahua", "Pacijent", "123144441231", date1, "Kosovska 5", "06354421", "nikola.petrovic@gmail.com");
            korisnici.Add(k3);
            Korisnik k4 = new Korisnik("zeljko123", "mahua123", "Zeljko", "Mahua", "Pacijent", "123155661232", date2, "Resavska 5", "06435521", "marko.markovic@gmail.com");
            korisnici.Add(k4);

            Korisnik k5 = new Korisnik("ivan123", "ivanovic123", "Ivan", "Ivanovic", "Upravnik", "1231341231231", date1, "Kosovska 5", "06352221", "nikola.petrovic@gmail.com");
            korisnici.Add(k5);
            Korisnik k6 = new Korisnik("gorana123", "ivanovic123", "Gorana", "Ivanovic", "Sekretar", "1231991231232", date2, "Resavska 5", "06432221", "marko.markovic@gmail.com");
            korisnici.Add(k6);
            */
            Notifikacija n1 = new Notifikacija("Dobrodosli", "Dev Team 28", "Zelimo vam dobrodoslicu u sistem");
            foreach (Korisnik k in korisnici)
            {
                k.Notifikacije = new ObservableCollection<Notifikacija>();
                k.Notifikacije.Add(n1);
                if (k.Zvanje != "Pacijent")
                {
                    zaposleni.Add(k);
                }
            }

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
            stream.Close();
            return korisnici;

        }
       /* public void ubaciNotifikacije()
        {
            Notifikacija n1 = new Notifikacija("Dobrodosli", "Dev Team 28", "Zelimo vam dobrodoslicu u sistem");
            foreach (Korisnik k in korisnici)
            {
                k.Notifikacije = new ObservableCollection<Notifikacija>();
                k.Notifikacije.Add(n1);
            }
            
        }*/
    }
}
