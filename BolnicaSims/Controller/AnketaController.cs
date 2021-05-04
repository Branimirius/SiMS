using BolnicaSims.Service;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BolnicaSims.Controller
{
    class AnketaController
    {
        private static AnketaController instance = null;
        public static AnketaController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AnketaController();
                }
                return instance;
            }
        }
        public void dodajAnketuDoktor(String doktor, String ocena, String komentar, String pacijent)
        {
            AnketaService.Instance.dodajAnketuDoktor(doktor, ocena, komentar, pacijent);
        }
        public void dodajAnketuBolnica(String ocena,String komentar,String pacijent)
        {
            AnketaService.Instance.dodajAnketuBolnica(ocena, komentar, pacijent);
        }
    }
}
