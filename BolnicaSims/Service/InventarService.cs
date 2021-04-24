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
            tempInv.prostorija = ProstorijaService.Instance.getProstorija(1, 1);
            InventarStorage.Instance.inventar.Add(tempInv);
            ProstorijaService.Instance.getMagacin().inventar.Add(tempInv);
            /*
            foreach (Inventar i in InventarStorage.Instance.inventar)
            {
                i.prostorija = ProstorijaService.Instance.getMagacin();
                ProstorijaService.Instance.getMagacin().inventar.Add(i);

            }
            */
            InventarStorage.Instance.Save();
            ProstorijeStorage.Instance.Save();
        }
        public void transferujInventar(int kolicina, Prostorija odrediste)
        {
            if(kolicina == InventarStorage.Instance.selektovaniInventar.Kolicina)
            {
                ProstorijaService.Instance.getProstorija(InventarStorage.Instance.selektovaniInventar.prostorija).inventar.Remove(InventarStorage.Instance.selektovaniInventar);
                InventarStorage.Instance.selektovaniInventar.prostorija = odrediste;
                ProstorijaService.Instance.getProstorija(odrediste).inventar.Add(InventarStorage.Instance.selektovaniInventar);

            }
            else
            {
                InventarStorage.Instance.selektovaniInventar.Kolicina = InventarStorage.Instance.selektovaniInventar.Kolicina - kolicina;
                Inventar tempInventar = new Inventar(InventarStorage.Instance.selektovaniInventar);
                tempInventar.Kolicina = kolicina;
                tempInventar.prostorija = odrediste;
                ProstorijaService.Instance.dodajInventar(odrediste, tempInventar);
                
            }
        }
        public Inventar GetInventar(String id)
        {
            foreach(Inventar i in InventarStorage.Instance.inventar)
            {
                if(i.IdInventara == id)
                {
                    return i;                    
                }

            }
            return null;
        }
        public String GenID()
        {
            int a = int.Parse(InventarStorage.Instance.inventar[InventarStorage.Instance.inventar.Count - 1].IdInventara) + 1;
            return a.ToString();
        }
    }
}
