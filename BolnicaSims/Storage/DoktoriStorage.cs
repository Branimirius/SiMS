﻿using BolnicaSims.Model;
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

           /*
            Doktor d1 = new Doktor(KorisniciStorage.Instance.korisnici[0]);
            doktori.Add(d1);
            //doktoriImena.Add(k1.Ime + " " + k1.Prezime);

            Doktor d2 = new Doktor(KorisniciStorage.Instance.korisnici[1]);
            doktori.Add(d2);
           
            //doktoriImena.Add(k2.Ime + " " + k2.Prezime);
           */
            Notifikacija n1 = new Notifikacija("Dobrodosli", "Dev Team 28", "Zelimo vam dobrodoslicu u sistem");
            foreach (Doktor d in doktori)
            {
                doktoriImena.Add(d.korisnik.Ime + " " + d.korisnik.Prezime);
                d.korisnik.Notifikacije = new ObservableCollection<Notifikacija>();
                d.korisnik.Notifikacije.Add(n1);
            }

            
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
