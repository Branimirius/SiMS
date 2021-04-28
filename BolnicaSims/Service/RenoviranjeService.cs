using BolnicaSims.Model;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BolnicaSims.Service
{
    class RenoviranjeService
    {
        private static RenoviranjeService instance = null;
        public static RenoviranjeService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RenoviranjeService();
                }
                return instance;
            }
        }

        public void zakaziRenoviranje(DateTime pocetak, int trajanjeDani, Prostorija prostorija)
        {           
            prostorija.renoviranja.Add(new Renoviranje(pocetak, pocetak.AddDays(trajanjeDani), prostorija));
            ProstorijeStorage.Instance.Save();
        }
    }
}
