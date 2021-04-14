using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace BolnicaSims.Service
{
    class PacijentService
    {
        private static PacijentService instance = null;
        public static PacijentService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PacijentService();
                }
                return instance;
            }
        }
        public void izmeniPacijenta(Pacijent pacijent)
        {
            for (int i = 0; i < PacijentiStorage.Instance.pacijenti.Count; i++)
            {

                if (pacijent.zdravstveniKarton.BrojKartona == PacijentiStorage.Instance.pacijenti[i].zdravstveniKarton.BrojKartona)

                {
                    if (pacijent.korisnik.Ime != "")
                    {
                        PacijentiStorage.Instance.pacijenti[i].korisnik.Ime = pacijent.korisnik.Ime;
                    }
                    if (pacijent.korisnik.Prezime != "")
                    {
                        PacijentiStorage.Instance.pacijenti[i].korisnik.Prezime = pacijent.korisnik.Prezime;
                    }
                    if (pacijent.zdravstveniKarton.ImeRoditelja != "")
                    {
                        PacijentiStorage.Instance.pacijenti[i].zdravstveniKarton.ImeRoditelja = pacijent.zdravstveniKarton.ImeRoditelja;
                    }
                    if (pacijent.zdravstveniKarton.BrojKartona != "")
                    {
                        PacijentiStorage.Instance.pacijenti[i].zdravstveniKarton.BrojKartona = pacijent.zdravstveniKarton.BrojKartona;
                    }
                }

            }
            PacijentiStorage.Instance.Save();
            SekretarView.Instance.refreshPacijenti();
           
        }
    }
}
