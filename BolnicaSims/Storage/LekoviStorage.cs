using BolnicaSims.Model;
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
    class LekoviStorage
    {
        private static LekoviStorage instance = null;
        public static LekoviStorage Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LekoviStorage();
                }
                return instance;
            }
        }

        private String FilePath = "lekoviStorage.txt";
        public ObservableCollection<Lek> lekovi = new ObservableCollection<Lek>();
        public ObservableCollection<String> lekoviImena = new ObservableCollection<String>();
        public ObservableCollection<Lek> neverifikovaniLekovi = new ObservableCollection<Lek>();
        public ObservableCollection<String> lekoviAlergeni = new ObservableCollection<String>();
        public Lek selektovanLek;

        public LekoviStorage()
        {
            this.Load();
            lekoviAlergeni = lekoviImena;
            foreach(Lek l in lekovi)
            {
                lekoviImena.Add(l.ImeLeka + " " + l.Doza);
                if (!l.Verifikovan)
                {
                    neverifikovaniLekovi.Add(l);
                }                
            }
        }

        public ObservableCollection<Lek> Read()
        {
            return lekovi;
        }
        public void Save()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(FilePath, FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, lekovi);
            stream.Close();
        }

        public ObservableCollection<Lek> Load()
        {
            // TODO: implement
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
            lekovi = (ObservableCollection<Lek>)formatter.Deserialize(stream);
            stream.Close();
            return lekovi;

        }
    }
}
