using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BolnicaSims.Service
{
    class ProstorijaService
    {
        private static ProstorijaService instance = null;
        public static ProstorijaService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ProstorijaService();
                }
                return instance;
            }
        }
        public void dodajProstoriju(TipProstorije tip, String sprat, String broj)
        {
            Prostorija tempProstorija = new Prostorija(tip, sprat, broj);
            ProstorijeStorage.Instance.prostorije.Add(tempProstorija);
            ProstorijeStorage.Instance.Save();
        }
        public void ukloniProstoriju(Prostorija p)
        {
            ProstorijeStorage.Instance.prostorije.Remove(p);
            ProstorijeStorage.Instance.Save();
        }
        public Prostorija getProstorija(int sprat, int broj)
        {
            foreach(Prostorija p in ProstorijeStorage.Instance.prostorije)
            {
                if(p.BrojProstorije == broj && p.Sprat == sprat)
                {
                    return p;
                }
                else
                {
                    return null;
                }
            }
            return null;
        }
    }
}
