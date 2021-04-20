using System;
using System.Collections.Generic;
using System.Text;
using BolnicaSims.Storage;
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
                    if (pacijent.korisnik.Username != "")
                    {
                        PacijentiStorage.Instance.pacijenti[i].korisnik.Username = pacijent.korisnik.Username;
                    }
                    if (pacijent.korisnik.Password != "")
                    {
                        PacijentiStorage.Instance.pacijenti[i].korisnik.Password = pacijent.korisnik.Password;
                    }
                }

            }
            PacijentiStorage.Instance.Save();
            SekretarView.Instance.refreshPacijenti();

            for (int i = 0; i < KorisniciStorage.Instance.korisnici.Count; i++)
            {
                if ((pacijent.korisnik.Ime + " " + pacijent.korisnik.Prezime) == (PacijentiStorage.Instance.pacijenti[i].korisnik.Ime + " " + PacijentiStorage.Instance.pacijenti[i].korisnik.Prezime))
                {
                    KorisniciStorage.Instance.korisnici[i] = pacijent.korisnik;
                }

            }
        }
        public void dodajPacijenta(Pacijent pacijent)
        {
            PacijentiStorage.Instance.Read().Add(pacijent);
            PacijentiStorage.Instance.Save();
        }

        public String GenID()
        {
            int a = int.Parse(PacijentiStorage.Instance.pacijenti[PacijentiStorage.Instance.pacijenti.Count - 1].zdravstveniKarton.BrojKartona) + 1;
            return a.ToString();
        }
    }
}
