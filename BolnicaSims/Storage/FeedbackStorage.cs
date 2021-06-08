﻿using BolnicaSims.Model;
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
    class FeedbackStorage
    {
        private static FeedbackStorage instance = null;
        public static FeedbackStorage Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FeedbackStorage();
                }
                return instance;
            }
        }
        private String FilePath = "feedbackStorage.txt";

        public ObservableCollection<Feedback> feedbacks = new ObservableCollection<Feedback>();

        public FeedbackStorage()
        {
            feedbacks = this.Load();
            //Feedback f1 = new Feedback("null", "null");
            //feedbacks.Add(f1);
            //this.Save();
        }
        public ObservableCollection<Feedback> Read()
        {
            return feedbacks;
        }

        public void Save()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(FilePath, FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, feedbacks);
            stream.Close();
        }

        public ObservableCollection<Feedback> Load()
        {
            // TODO: implement
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
            feedbacks = (ObservableCollection<Feedback>)formatter.Deserialize(stream);
            stream.Close();
            return feedbacks;


        }
    }
}
