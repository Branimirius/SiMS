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
        public Prostorija getProstorija(int sprat, int broj)
        {
            return ProstorijaService.Instance.getProstorija(sprat, broj);
        }
    }
}
