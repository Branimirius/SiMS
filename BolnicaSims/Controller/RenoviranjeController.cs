using BolnicaSims.Service;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BolnicaSims.Controller
{
    class RenoviranjeController
    {
        private static RenoviranjeController instance = null;
        public static RenoviranjeController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RenoviranjeController();
                }
                return instance;
            }
        }
        public void zakaziRenoviranje(DateTime pocetak, int trajanjeDani, Prostorija prostorija)
        {
            RenoviranjeService.Instance.zakaziRenoviranje(pocetak, trajanjeDani, prostorija);
        }

    }
}
