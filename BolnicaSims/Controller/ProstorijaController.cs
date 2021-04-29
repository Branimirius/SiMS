using BolnicaSims.Service;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BolnicaSims.Controller
{
    class ProstorijaController
    {
        private static ProstorijaController instance = null;
        public static ProstorijaController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ProstorijaController();
                }
                return instance;
            }
        }
        public void dodajProstoriju(TipProstorije tip, String sprat, String broj)
        {
            ProstorijaService.Instance.dodajProstoriju(tip, sprat, broj);
        }
        public void ukloniProstoriju(Prostorija p)
        {
            ProstorijaService.Instance.ukloniProstoriju(p);
        }
        public void izmeniProstoriju(TipProstorije tip, String sprat, String broj)
        {
            ProstorijaService.Instance.izmeniProstoriju(tip, sprat, broj);
        }
        public Prostorija getProstorija(int sprat, int broj)
        {
            return ProstorijaService.Instance.getProstorija(sprat, broj);
        }
        public Boolean prostorijaRadovi(DateTime pocetak, DateTime kraj, Prostorija prostorija)
        {
            return ProstorijaService.Instance.prostorijaRadovi(pocetak, kraj, prostorija);
        }
    }
}
