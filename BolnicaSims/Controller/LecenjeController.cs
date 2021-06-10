using BolnicaSims.DTO;
using BolnicaSims.Model;
using BolnicaSims.Service;
using BolnicaSims.Storage;
using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BolnicaSims.Controller
{
    class LecenjeController
    {
        private static LecenjeController instance = null;
        public static LecenjeController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LecenjeController();
                }
                return instance;
            }
        }

        public Lecenje selektovanoLecenje;

        public void izmeniLecenje(Pacijent p, LecenjeDTO l)
        {
            LecenjeService.Instance.izmeniLecenje(p, l);
        }

        public string dodajLecenje(Pacijent p, Prostorija pr, DateTime pocetak, DateTime kraj)
        {
            return LecenjeService.Instance.dodajLecenje(p, pr, pocetak, kraj);
        }

        public ObservableCollection<Lecenje> getLecenja()
        {
            return LecenjaStorage.Instance.lecenja;
        }
    }
}
