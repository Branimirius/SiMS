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

        public void dodajLecenje(Pacijent pacijent, Prostorija prostorija, DateTime pocetak, DateTime kraj)
        {
            foreach (Lecenje l in LecenjaStorage.Instance.Read())
            {
                if (l.Pacijent.korisnik.Jmbg == pacijent.korisnik.Jmbg)
                {
                    MessageBox.Show("Izabrani pacijent je vec na bolnickom lecenju");
                }
                else
                {
                    LecenjaStorage.Instance.lecenja.Add(new Lecenje(pacijent, pocetak, kraj, prostorija));
                    LecenjaStorage.Instance.Save();
                    break;
                }
            }
        }

        public void izmeniLecenje(Pacijent pacijent, LecenjeDTO lecenje)
        {
            foreach (Lecenje l in LecenjaStorage.Instance.Read())
            {
                if (l.Pacijent.korisnik.Jmbg == pacijent.korisnik.Jmbg)
                {
                    l.Prostorija = lecenje.prostorija;
                    l.Pocetak = lecenje.pocetak;
                    l.Kraj = lecenje.kraj;
                    
                }
            }
            LecenjaStorage.Instance.Save();
        }
    }
}
