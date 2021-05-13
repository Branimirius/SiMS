using BolnicaSims.Model;
using BolnicaSims.Service;
using System;
using System.Collections.Generic;
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

        public void dodajLek(String naziv, String proizvodjac, String doza, String alergen, String kolicina)
        {
            LekoviService.Instance.dodajLek(naziv, proizvodjac, doza, alergen, kolicina);
        }
        public void validacijaLeka(Lek lek)
        {
            LekoviService.Instance.validacijaLeka(lek);
        }
        public void odbijanjeLeka(Lek lek, String komentar)
        {
            LekoviService.Instance.odbijanjeLeka(lek, komentar);
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
    }
}
