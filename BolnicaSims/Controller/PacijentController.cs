using System;
using System.Collections.Generic;
using System.Text;
using BolnicaSims.DTO;
using BolnicaSims.Service;
using BolnicaSims.Storage;
using Model;

namespace BolnicaSims.Controller
{
    class PacijentController
    {
        private static PacijentController instance = null;
        public static PacijentController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PacijentController();
                }
                return instance;
            }
        }
        public void izmeniPacijenta(Pacijent pacijent, Pacijent selected)
        {
            PacijentService.Instance.izmeniPacijenta(pacijent, selected);
        }
        public void dodajPacijenta(Pacijent pacijent)
        {
            PacijentService.Instance.dodajPacijenta(pacijent);
        }
        public void dodajPacijenta(PacijentDTO pacijent)
        {
            PacijentService.Instance.dodajPacijenta(pacijent);
        }
        public void banujPacijenta(DateTime vreme, Pacijent pacijent)
        {
            PacijentService.Instance.banujPacijenta(vreme, pacijent);
        }
        public Boolean proveriBan(DateTime trenutnoVreme, Pacijent pacijent)
        {
            return PacijentService.Instance.proveriBan(trenutnoVreme, pacijent);
        }

        public Pacijent getUlogovaniPacijent()
        {
            return PacijentService.Instance.getUlogovaniPacijent(KorisniciStorage.Instance.ulogovaniKorisnik);
        }
           
    }
}
