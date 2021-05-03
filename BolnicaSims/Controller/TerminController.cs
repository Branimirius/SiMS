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
        public void dodajTerminAdvanced(DateTime vremeTermina, DateTime kraj, Doktor doktor, Pacijent pacijent, Prostorija prostorija, TipTermina tip)
        {
            TerminService.Instance.dodajTerminAdvanced(vremeTermina, kraj, doktor, pacijent, prostorija, tip);
        }
        public Boolean slobodanDoktor(DateTime pocetak, DateTime kraj, Doktor doktor)
        {
           return TerminService.Instance.slobodanDoktor(pocetak, kraj, doktor);
        }
        public Boolean slobodanPacijent(DateTime pocetak, DateTime kraj, Pacijent pacijent)
        {
            return TerminService.Instance.slobodanPacijent(pocetak, kraj, pacijent);
        }
        public Boolean slobodnaProstorija(DateTime pocetak, DateTime kraj, Prostorija prostorija)
        {
            return TerminService.Instance.slobodnaProstorija(pocetak, kraj, prostorija);
        }
        public Boolean slobodanTerminAdvanced(DateTime pocetak, DateTime kraj, Pacijent pacijent, Doktor doktor, Prostorija prostorija)
        {
           return TerminService.Instance.slobodanTerminAdvanced(pocetak, kraj, pacijent, doktor, prostorija);
        }
    }
}
