using BolnicaSims.Model;
using BolnicaSims.Storage;
using System;
using System.Collections.Generic;
using System.Text;

namespace BolnicaSims.Service
{
    class LekoviService
    {
        private static LekoviService instance = null;
        public static LekoviService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LekoviService();
                }
                return instance;
            }
        }

        public void dodajLek(String naziv, String proizvodjac, String doza, String alergen, String kolicina)
        {
            
            Lek tempLek = new Lek(naziv, proizvodjac, doza, alergen, kolicina, GenID(), false);
            LekoviStorage.Instance.lekovi.Add(tempLek);
            LekoviStorage.Instance.lekoviImena.Add(naziv + doza);
            LekoviStorage.Instance.neverifikovaniLekovi.Add(tempLek);
            LekoviStorage.Instance.Save();
        }
        public void validacijaLeka(Lek lek)
        {
            GetLek(lek).Verifikovan = true;
            LekoviStorage.Instance.neverifikovaniLekovi.Remove(lek);
            LekoviStorage.Instance.Save();
        }
        public Lek GetLek(Lek lek)
        {
            foreach (Lek l in LekoviStorage.Instance.lekovi)
            {
                if(l.IdLeka == lek.IdLeka)
                {
                    return l;
                }
            }
            return null;
        }
        public String GenID()
        {
            int a = 0;
            if (LekoviStorage.Instance.lekovi.Count == 0)
            {
                a = 1;
            }
            else
            {
                a = int.Parse(LekoviStorage.Instance.lekovi[LekoviStorage.Instance.lekovi.Count - 1].IdLeka) + 1;

            }
            return a.ToString();
        }
    }
}
