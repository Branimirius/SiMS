using BolnicaSims.Model;
using BolnicaSims.Service;
using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BolnicaSims.Controller
{
    class LekoviController
    {
        private static LekoviController instance = null;
        public static LekoviController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LekoviController();
                }
                return instance;
            }
        }

        public void dodajLek(String naziv, String proizvodjac, String doza, String alergen, String kolicina, ObservableCollection<Doktor> izabraniDoktori)
        {
            LekoviService.Instance.dodajLek(naziv, proizvodjac, doza, alergen, kolicina, izabraniDoktori);
        }
        public void validacijaLeka(Lek lek)
        {
            LekoviService.Instance.validacijaLeka(lek);
        }
        public void odbijanjeLeka(Lek lek, String komentar)
        {
            LekoviService.Instance.odbijanjeLeka(lek, komentar);
        }
        public string getAlternative(Lek lek)
        {
            return LekoviService.Instance.getAlternative(lek);
        }

        public void izmeniLek(Lek lek)
        {
            LekoviService.Instance.izmeniLek(lek);
        }
        public void ukloniLek(Lek lek)
        {
            LekoviService.Instance.ukloniLek(lek);
        }
        public void dodajAlternativu(String alternativa)
        {
            LekoviService.Instance.dodajAlternativu(alternativa);
        }
        public void ukloniAlternativu(Lek alternativa)
        {
            LekoviService.Instance.ukloniAlternativu(alternativa);
        }
        public ObservableCollection<Lek> getLekovi()
        {
            return LekoviService.Instance.getLekovi();
        }
        public ObservableCollection<String> getLekoviImena()
        {
            return LekoviService.Instance.getLekoviImena();
        }
        public ObservableCollection<Lek> getNeverifikovaniLekovi()
        {
            return LekoviService.Instance.getNeverifikovaniLekovi();
        }
        public Lek getSelektovanLek()
        {
            return LekoviService.Instance.getSelektovanLek();
        }
    }
}
