using BolnicaSims.Model;
using BolnicaSims.Storage;
using System;
using System.Collections.Generic;
using System.Text;

namespace BolnicaSims.Service
{
    class FeedbackService
    {
        private static FeedbackService instance = null;
        public static FeedbackService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FeedbackService();
                }
                return instance;
            }
        }
        public void dodajFeedback(String primedbe, String bagovi, String ocena)
        {
            FeedbackStorage.Instance.feedbacks.Add(new Feedback(primedbe, bagovi, int.Parse(ocena)));
            FeedbackStorage.Instance.Save();
        }
    }
}
