using BolnicaSims.Storage;
using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace BolnicaSims.Service
{
    class ProstorijaService
    {
        private static ProstorijaService instance = null;
        public static ProstorijaService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ProstorijaService();
                }
                return instance;
            }
        }
        public void dodajProstoriju(TipProstorije tip, String sprat, String broj)
        {
            Prostorija tempProstorija = new Prostorija(tip, sprat, broj);
            //tempProstorija.IdProstorije = "1";
            tempProstorija.IdProstorije = GenID();
            tempProstorija.Naziv = GenNaziv(tip, sprat, broj);

            ProstorijeStorage.Instance.prostorije.Add(tempProstorija);
            /*
            foreach(Prostorija p in ProstorijeStorage.Instance.prostorije)
            {

                p.Naziv = GenNaziv(p.TipProstorije, p.BrojProstorije, p.Sprat);
            }
            */
            InventarStorage.Instance.Save();
            ProstorijeStorage.Instance.Save();
        }
        public void ukloniProstoriju(Prostorija p)
        {         
            ProstorijeStorage.Instance.prostorije.Remove(p);
            ProstorijeStorage.Instance.Save();
        }
        public void izmeniProstoriju(TipProstorije tip, String sprat, String broj)
        {
            
            foreach(Prostorija p in ProstorijeStorage.Instance.prostorije)
            {  
                
                if(ProstorijeStorage.Instance.selektovanaProstorija.IdProstorije == p.IdProstorije)
                {
                    if (p.TipProstorije == TipProstorije.MAGACIN && tip == TipProstorije.MAGACIN)
                    {
                        MessageBox.Show("Magacin se ne moze menjati");
                        break;
                    }
                    if(sprat != "" && sprat != "sprat")
                    {
                        p.Sprat = int.Parse(sprat);
                    }
                    if(broj != "" && broj != "broj")
                    {
                        p.BrojProstorije = int.Parse(broj);
                    }
                    if(p.TipProstorije != tip)
                    {
                        p.TipProstorije = tip;
                    }

                }
            }
            
            ProstorijeStorage.Instance.Save();
            
        }
        public Prostorija getMagacin()
        {
            foreach (Prostorija p in ProstorijeStorage.Instance.prostorije)
            {
                if (p.TipProstorije == TipProstorije.MAGACIN)
                {
                    return p;
                }
                else
                {
                    return null;
                }
            }
            return null;
        }
    
        public Prostorija getProstorija(int sprat, int broj)
        {
            foreach(Prostorija p in ProstorijeStorage.Instance.prostorije)
            {
                if(p.BrojProstorije == broj && p.Sprat == sprat)
                {
                    return p;
                }
                else
                {
                    return null;
                }
            }
            return null;
        }
        public Prostorija getProstorija(Prostorija prostorija)
        {
            foreach (Prostorija p in ProstorijeStorage.Instance.prostorije)
            {
                if (p.IdProstorije == prostorija.IdProstorije)
                {
                    return p;
                }
               
            }
            return null;
        }
        public String GenNaziv(TipProstorije tip, String broj, String sprat)
        {
            String naziv = "";
            switch (tip)
            {
                case TipProstorije.SOBA:
                    naziv = "Soba" + " " + broj + " " + sprat;
                    break;
                case TipProstorije.ORDINACIJA:
                    naziv = "Ordinacija" + " " + broj + " " + sprat;
                    break;
                case TipProstorije.OPERACIONA_SALA:
                    naziv = "Operaciona Sala" + " " + broj + " " + sprat;
                    break;
                case TipProstorije.MAGACIN:
                    naziv = "Magacin";
                    break;
            }
            return naziv;
        }

        
        public void dodajInventar(Prostorija p, Inventar inventar)
        {
            if (getProstorija(p).inventar.Count != 0)
            {
                foreach (Inventar i in getProstorija(p).inventar)
                {
                    if (i.IdInventara == inventar.IdInventara)
                    {
                        i.Kolicina += inventar.Kolicina;
                        return;
                    }
                }

                p.inventar.Add(inventar);
                InventarStorage.Instance.inventar.Add(inventar);
            }
            else
            {
                p.inventar.Add(inventar);
                InventarStorage.Instance.inventar.Add(inventar);
            }
            
        }
        public Inventar GetInventarKomad(Prostorija p, String idInventara)
        {
            foreach(Inventar i in p.inventar)
            {
                if(i.IdInventara == idInventara)
                {
                    return i;
                }
            }
            return null;
        }
        public String GenID()
        {
            int a = int.Parse(ProstorijeStorage.Instance.prostorije[ProstorijeStorage.Instance.prostorije.Count - 1].IdProstorije) + 1;
            return a.ToString();
        }
    }
}
