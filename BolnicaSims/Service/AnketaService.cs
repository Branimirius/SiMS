using BolnicaSims.Model;
using BolnicaSims.Storage;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BolnicaSims.Service
{
    class AnketaService
    {
        private static AnketaService instance = null;
        public static AnketaService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AnketaService();
                }
                return instance;
            }
        }


        public void dodajAnketu(String doktor, String ocena, String komentar, String pacijent)
        {
            Anketa tempAnketa = new Anketa(doktor,ocena,komentar, PacijentService.Instance.getUlogovaniPacijent(KorisniciStorage.Instance.ulogovaniKorisnik));


            AnketeStorage.Instance.Read().Add(tempAnketa);
            AnketeStorage.Instance.Save();
        }
    }
}
