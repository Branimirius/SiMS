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
    class LecenjaStorage
    {
        private static LecenjaStorage instance = null;
        public static LecenjaStorage Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LecenjaStorage();
                }
                return instance;
            }
        }

        public ObservableCollection<Lecenje> lecenja = new ObservableCollection<Lecenje>();
        public Lecenje selektovanoLecenje;

        private String fileLocation = "lecenjaStorage.txt";

        public LecenjaStorage()
        {
            lecenja = this.Load();
            
        }

        public void Save()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(fileLocation, FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, lecenja);
            stream.Close();
        }

        public ObservableCollection<Lecenje> Load()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(fileLocation, FileMode.Open, FileAccess.Read);
            lecenja = (ObservableCollection<Lecenje>)formatter.Deserialize(stream);
            stream.Close();
            return lecenja;

        }

        public ObservableCollection<Lecenje> Read()
        {
            return lecenja;
        }
    }
}
