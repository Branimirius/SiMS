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
    class InventarStorage
    {
        private static InventarStorage instance = null;
        public static InventarStorage Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new InventarStorage();
                }
                return instance;
            }
        }

        private String FilePath = "inventarStorage.txt";
        public ObservableCollection<Inventar> inventar = new ObservableCollection<Inventar>();
        public ObservableCollection<String> inventarImena = new ObservableCollection<String>();
        public Inventar selektovaniInventar = new Inventar();
        public InventarStorage()
        {
            Inventar l1 = new Inventar("20","Respirator","Tehnion","5");
            /* l2 = new Inventar("21", "EKG aparat", "Jakobs", "3");
            Inventar l3 = new Inventar("22", "Dekontaminator", "Colt", "6");
            inventar.Add(l1);
            inventar.Add(l2);
            inventar.Add(l3);
            this.Save();*/
            this.Load();
            foreach (Inventar l in inventar)
            {
                inventarImena.Add(l.Naziv);
            }
        }
        public ObservableCollection<Inventar> Read()
        {
            return inventar;
        }

        public void Save()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(FilePath, FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, inventar);
            stream.Close();
        }

        public ObservableCollection<Inventar> Load()
        {
            // TODO: implement
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
            inventar = (ObservableCollection<Inventar>)formatter.Deserialize(stream);
            return inventar;

        }
    }
}
