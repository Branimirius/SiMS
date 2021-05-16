using BolnicaSims.Model;
using BolnicaSims.Storage;
using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            tempProstorija.Naziv = GenNaziv(tip, broj, sprat);
            tempProstorija.susedneProstorije = getSusedneProstorijeNazivi(tempProstorija);
            ProstorijeStorage.Instance.prostorije.Add(tempProstorija);
            /*
            foreach(Prostorija p in ProstorijeStorage.Instance.prostorije)
            {

                p.renoviranja = new ObservableCollection<Renoviranje>();
            }
            */
            
            InventarStorage.Instance.Save();
            ProstorijeStorage.Instance.Save();
        }
        public void ukloniProstoriju(Prostorija p)
        {
            ProstorijeStorage.Instance.prostorije.Remove(p);
            ProstorijeStorage.Instance.nazivi.Remove(p.Naziv);
            foreach(Prostorija prostorija in ProstorijeStorage.Instance.prostorije)
            {
                if (prostorija.susedneProstorije.Contains(p.Naziv))
                {
                    prostorija.susedneProstorije.Remove(p.Naziv);
                }
            }
            ProstorijeStorage.Instance.Save();
        }
        public void izmeniProstoriju(TipProstorije tip, String sprat, String broj)
        {

            foreach (Prostorija p in ProstorijeStorage.Instance.prostorije)
            {

                if (ProstorijeStorage.Instance.selektovanaProstorija.IdProstorije == p.IdProstorije)
                {
                    if (p.TipProstorije == TipProstorije.MAGACIN && tip == TipProstorije.MAGACIN)
                    {
                        MessageBox.Show("Magacin se ne moze menjati");
                        break;
                    }
                    if (sprat != "" && sprat != "sprat")
                    {
                        p.Sprat = int.Parse(sprat);
                    }
                    if (broj != "" && broj != "broj")
                    {
                        p.BrojProstorije = int.Parse(broj);
                    }
                    if (p.TipProstorije != tip)
                    {
                        p.TipProstorije = tip;
                    }
                    p.Naziv = GenNaziv(tip, broj, sprat);

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
        public Boolean prostorijaRadovi(DateTime pocetak, DateTime kraj, Prostorija prostorija)
        {
            foreach (Renoviranje r in getProstorija(prostorija).renoviranja)
            {
                if ((pocetak >= r.Pocetak && kraj <= r.Kraj) || (pocetak <= r.Pocetak && kraj >= r.Pocetak) || (pocetak <= r.Kraj && kraj >= r.Kraj) || (pocetak <= r.Pocetak && kraj >= r.Kraj))
                {
                    return true;
                }

            }
            return false;
        }
        public Prostorija getProstorija(int sprat, int broj)
        {
            foreach (Prostorija p in ProstorijeStorage.Instance.prostorije)
            {
                if (p.BrojProstorije == broj && p.Sprat == sprat)
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
        public Prostorija getProstorijaByNaziv(String prostorija)
        {
            foreach (Prostorija p in ProstorijeStorage.Instance.prostorije)
            {
                if (p.Naziv == prostorija)
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
            foreach (Inventar i in p.inventar)
            {
                if (i.IdInventara == idInventara)
                {
                    return i;
                }
            }
            return null;
        }
        public ObservableCollection<Prostorija> getSusedneProstorije(Prostorija prostorija)
        {
            ObservableCollection<Prostorija> ret = new ObservableCollection<Prostorija>();
            foreach (Prostorija p in ProstorijeStorage.Instance.prostorije)
            {
                if ((p.Sprat == prostorija.Sprat) && (Math.Abs(p.BrojProstorije - prostorija.BrojProstorije) == 1))
                {
                    ret.Add(p);
                }
            }

            return ret;
        }
        public ObservableCollection<String> getSusedneProstorijeNazivi(Prostorija prostorija)
        {
            ObservableCollection<String> ret = new ObservableCollection<String>();
            foreach (Prostorija p in ProstorijeStorage.Instance.prostorije)
            {
                if ((p.Sprat == prostorija.Sprat) && (Math.Abs(p.BrojProstorije - prostorija.BrojProstorije) == 1))
                {
                    ret.Add(p.Naziv);
                }
            }

            return ret;
        }
        public void prebaciInventar(Prostorija spojProstorija, Prostorija prostorija)
        {
            foreach(Inventar i in getProstorija(spojProstorija).inventar)
            {
                
                getProstorija(prostorija).inventar.Add(i);
            }
            foreach(Inventar i in InventarStorage.Instance.inventar)
            {
                if(i.prostorija.Naziv == spojProstorija.Naziv)
                {
                    getProstorija(spojProstorija).inventar.Remove(i);
                    i.prostorija = getProstorija(prostorija);
                }
            }
        }
        public void prebaciTermine(Prostorija spojProstorija, Prostorija prostorija)
        {
            foreach (Termin t in getProstorija(spojProstorija).termini)
            {
                getProstorija(prostorija).termini.Add(t);
            }
            foreach (Termin t in TerminStorage.Instance.termini)
            {
                if (t.prostorija.Naziv == spojProstorija.Naziv)
                {
                    t.prostorija = getProstorija(prostorija);
                }
            }
        }

        public String genBrojProstorijeDeljenje(Prostorija deljenaProstorija)
        {
            int broj = deljenaProstorija.BrojProstorije;
           
            if (getProstorija(deljenaProstorija.Sprat, broj + 1) == null)
            {
                return (broj + 1).ToString();
            }
            if ((getProstorija(deljenaProstorija.Sprat, broj - 1) == null) && ((broj - 1) > 0))
            {
                return (broj - 1).ToString();
            }
            return (broj.ToString() + '1');
            
                       
            
        }
        public String GenID()
        {
            int a = 0;
            if (ProstorijeStorage.Instance.prostorije.Count == 0)
            {
                a = 1;
            }
            else
            {
                a = int.Parse(ProstorijeStorage.Instance.prostorije[ProstorijeStorage.Instance.prostorije.Count - 1].IdProstorije) + 1;
               
            }
            return a.ToString();
        }
    }
}
