using BolnicaSims.Service;
using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public void ukloniInventar(Inventar inventar)
        {
            InventarService.Instance.ukloniInventar(inventar);
        }
        public void transferujInventar(int kolicina, Prostorija odrediste)
        {
            InventarService.Instance.transferujInventar(kolicina, odrediste);
        }
        public ObservableCollection<Inventar> getInventar()
        {
            return InventarService.Instance.getInventar();
        }
        public ObservableCollection<String> getInventarImena()
        {
            return InventarService.Instance.getInventarImena();
        }
        public Inventar getSelektovaniInventar()
        {
            return InventarService.Instance.getSelektovaniInventar();
        }
        public void setSelektovaniInventar(Inventar inventar)
        {
            InventarService.Instance.setSelektovaniInventar(inventar);
        }
    }
}
