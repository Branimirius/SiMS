using BolnicaSims.Service;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BolnicaSims.Controller
{
    class InventarController
    {
        private static InventarController instance = null;
        public static InventarController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new InventarController();
                }
                return instance;
            }
        }


        public void dodajInventar(String naziv, String proizvodjac, String kolicina, Boolean staticki)
        {
            InventarService.Instance.dodajInventar(naziv, proizvodjac, kolicina, staticki);
        }
        public void transferujInventar(int kolicina, Prostorija odrediste)
        {
            InventarService.Instance.transferujInventar(kolicina, odrediste);
        }
    }
}
