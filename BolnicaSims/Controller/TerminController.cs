using BolnicaSims.Service;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BolnicaSims.Controller
{
    class TerminController
    {
        private static TerminController instance = null;
        public static TerminController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TerminController();
                }
                return instance;
            }
        }
        public void izmeniTermin(Termin termin)
        {
            TerminService.Instance.izmeniTermin(termin);
        }
    }
}
