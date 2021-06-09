using BolnicaSims.DTO;
using BolnicaSims.Model;
using BolnicaSims.Storage;
using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace BolnicaSims.Service
{
    class LecenjeService
    {
        private static LecenjeService instance = null;
        public static LecenjeService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LecenjeService();
                }
                return instance;
            }
        }

        public string dodajLecenje(Pacijent pacijent, Prostorija prostorija, DateTime pocetak, DateTime kraj)
        {
            int brKreveta = 0;
            int brLecenja = 0;
            string poruka = "";
            foreach (Lecenje l in LecenjaStorage.Instance.Read())
            {
                if (l.Pacijent.korisnik.ImePrezime == pacijent.korisnik.ImePrezime)
                {
                    poruka = "Izabrani pacijent je vec na bolnickom lecenju";
                }
                else
                {
                    foreach(Inventar i in prostorija.inventar)
                    {
                        if (i.Naziv == "Krevet")
                        {
                            brKreveta = i.Kolicina;
                        }
                    }

                    foreach (Lecenje le in LecenjaStorage.Instance.Read())
                    {
                        if (le.Prostorija.IdProstorije == prostorija.IdProstorije)
                        {
                            brLecenja++;
                        }
                    }

                    if (brKreveta > brLecenja)
                    {
                        LecenjaStorage.Instance.lecenja.Add(new Lecenje(pacijent, pocetak, kraj, prostorija));
                        LecenjaStorage.Instance.Save();
                        poruka = "Uspesno dodato lecenje";
                        break;
                    }
                    else
                    {
                        poruka = "Nema dovoljno kreveta u izabranoj prostoriji";
                    }
                }
            }
            return poruka; 
        }

        public void izmeniLecenje(Pacijent pacijent, LecenjeDTO lecenje)
        {
            foreach (Lecenje l in LecenjaStorage.Instance.Read())
            {
                if (l.Pacijent.korisnik.ImePrezime == lecenje.pacijent.korisnik.ImePrezime)
                {
                    l.Prostorija = lecenje.prostorija;
                    l.Pocetak = lecenje.pocetak;
                    l.Kraj = lecenje.kraj;
                    LecenjaStorage.Instance.Save();

                }
            }
            
        }
    }
}
