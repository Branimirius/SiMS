using BolnicaSims.Service;
using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public Prostorija getSelektovanaProstorija()
        {
            return ProstorijaService.Instance.getSelektovanaProstorija();
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
        public ObservableCollection<Prostorija> getSusedneProstorije(Prostorija prostorija)
        {
            return ProstorijaService.Instance.getSusedneProstorije(prostorija);
        }
        public ObservableCollection<String> getSusedneProstorijeNazivi(Prostorija prostorija)
        {
            return ProstorijaService.Instance.getSusedneProstorijeNazivi(prostorija);
        }
        public Prostorija getProstorijaByNaziv(String naziv)
        {
            return ProstorijaService.Instance.getProstorijaByNaziv(naziv);
        }
        public ObservableCollection<Prostorija> getProstorije()
        {
            return ProstorijaService.Instance.getProstorije();
        }
        public ObservableCollection<Prostorija> getSale()
        {
            return ProstorijaService.Instance.getSale();
        }
        public ObservableCollection<Prostorija> getOrdinacije()
        {
            return ProstorijaService.Instance.getOrdinacije();
        }
        public ObservableCollection<String> getNazivi()
        {
            return ProstorijaService.Instance.getNazivi();
        }
    }
}
