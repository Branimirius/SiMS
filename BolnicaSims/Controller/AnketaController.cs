using BolnicaSims.Service;
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
        public void dodajAnketu(String doktor, String ocena, String komentar, String pacijent)
        {
            AnketaService.Instance.dodajAnketu(doktor, ocena, komentar, pacijent);
        }
    }
}
