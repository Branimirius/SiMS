using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using BolnicaSims.DTO;
using BolnicaSims.Model;
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
        public void izmeniPacijenta(PacijentDTO pacijent, Pacijent selected)
        {
            Pacijent temp = new Pacijent(pacijent);           
            PacijentService.Instance.izmeniPacijenta(temp, selected);
        }
        public void izmeniAnamnezu(String anamneza, String alergija)
        {
            PacijentService.Instance.izmeniAnamnezu(anamneza, alergija);
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

        public void setSelectovaniPacijent(Lecenje lecenje)
        {
            PacijentService.Instance.setSelectovaniPacijent(lecenje);
        }
        public Pacijent getPacijent(Pacijent pacijent)
        {
            return PacijentService.Instance.getPacijent(pacijent);
        }


        public void sacuvajBelesku(DateTime vreme,String beleska)
        {
            PacijentService.Instance.sacuvajBelesku(vreme, beleska);
        }
           

        public ObservableCollection<Pacijent> getPacijenti()
        {
            return PacijentService.Instance.getPacijenti();
        }
        public ObservableCollection<String> getPacijentiImena()
        {
            return PacijentService.Instance.getPacijentiImena();
        }
        public Pacijent getSelektovanPacijent()
        {
            return PacijentService.Instance.getSelektovanPacijent();
        }
        public ObservableCollection<Recept> getRecepti()
        {
            return PacijentService.Instance.getRecepti();
        }

        public void zabeleziOdradjenePreglede()
        {
            PacijentService.Instance.zabeleziOdradjenePreglede();
        }

     

    }
}
