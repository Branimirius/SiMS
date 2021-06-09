using BolnicaSims.Interface;
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
    public class ReceptiStorage: IReadable, IStorage
    {
        private static ReceptiStorage instance = null;
        public static ReceptiStorage Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ReceptiStorage();
                }
                return instance;
            }
        }

        private String FilePath = "receptiStorage.txt";
        public ObservableCollection<Recept> recepti = new ObservableCollection<Recept>();

        public ReceptiStorage()
        {
            Load();
        }

        public ObservableCollection<object> Read()
        {
            return new ObservableCollection<object> {recepti};
        }

        public void Load()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
            recepti = (ObservableCollection<Recept>)formatter.Deserialize(stream);
            stream.Close();
        }

        public void Save()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(FilePath, FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, recepti);
            stream.Close();
        }
    }
}
