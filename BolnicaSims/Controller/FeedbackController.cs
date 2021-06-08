using BolnicaSims.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace BolnicaSims.Controller
{
    class FeedbackController
    {
        private static FeedbackController instance = null;
        public static FeedbackController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FeedbackController();
                }
                return instance;
            }
        }
        public void dodajFeedback(String primedbe, String bagovi)
        {
            FeedbackService.Instance.dodajFeedback(primedbe, bagovi);
        }
    }
}
