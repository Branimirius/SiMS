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
        public void izmeniTermin(Termin termin, String vreme)
        {
            TerminService.Instance.izmeniTermin(termin, vreme);
        }
        public void dodajTermin(String vreme, String doktor, String pacijent)
        {
            TerminService.Instance.dodajTermin(vreme, doktor, pacijent);
        }
    }
}
