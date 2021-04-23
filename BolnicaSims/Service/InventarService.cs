using BolnicaSims.Storage;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BolnicaSims.Service
{
    class InventarService
    {
        private static InventarService instance = null;
        public static InventarService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new InventarService();
                }
                return instance;
            }
        }

        public void dodajInventar(String naziv, String proizvodjac, String kolicina)
        {

            Inventar tempInv = new Inventar(GenID(), naziv, proizvodjac, kolicina);
            InventarStorage.Instance.inventar.Add(tempInv);
            InventarStorage.Instance.Save();
        }
        public String GenID()
        {
            int a = int.Parse(InventarStorage.Instance.inventar[InventarStorage.Instance.inventar.Count - 1].IdInventara) + 1;
            return a.ToString();
        }
    }
}
