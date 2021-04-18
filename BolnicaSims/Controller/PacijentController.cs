using System;
using System.Collections.Generic;
using System.Text;
using BolnicaSims.Service;
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
        public void izmeniPacijenta(Pacijent pacijent)
        {
            PacijentService.Instance.izmeniPacijenta(pacijent);
        }
        public void dodajPacijenta(Pacijent pacijent)
        {
            PacijentService.Instance.dodajPacijenta(pacijent);
        }
           
    }
}
