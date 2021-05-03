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
    class AnketeStorage
    {
        private static AnketeStorage instance = null;
        public static AnketeStorage Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AnketeStorage();
                }
                return instance;
            }
        }

        public ObservableCollection<Anketa> ankete = new ObservableCollection<Anketa>();
     

        private String fileLocation = "anketeStorage.txt";

        public AnketeStorage()
        {
         //   this.Save();
            ankete = this.Load();


        }




        public void Save()
        {
            // TODO: implement
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(fileLocation, FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, ankete);
            stream.Close();


        }

        public ObservableCollection<Anketa> Read()
        {
            return ankete;
        }



 


        public ObservableCollection<Anketa> Load()
        {
            // TODO: implement
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(fileLocation, FileMode.Open, FileAccess.Read);
           ankete = (ObservableCollection<Anketa>)formatter.Deserialize(stream);
            stream.Close();
            return ankete;

        }

  

    }
}

