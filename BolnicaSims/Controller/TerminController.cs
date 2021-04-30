using BolnicaSims.Service;
using BolnicaSims.Storage;
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
        public void dodajTermin(String vreme, String doktor, String pacijent)
        {           
            TerminService.Instance.dodajTermin(vreme, doktor, pacijent);               
        }
        public void ukloniTermin(Termin t)
        {
            TerminService.Instance.ukloniTermin(t);
        }
        public void dodajTerminAdvanced(DateTime vremeTermina, String trajanje, Doktor doktor, Pacijent pacijent, Prostorija prostorija, TipTermina tip)
        {
            TerminService.Instance.dodajTerminAdvanced(vremeTermina, trajanje, doktor, pacijent, prostorija, tip);
        }
    }
}
