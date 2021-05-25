using BolnicaSims.Model;
using BolnicaSims.Storage;
using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        public void dodajLek(String naziv, String proizvodjac, String doza, String alergen, String kolicina, ObservableCollection<Doktor> doktori)
        {
            
            Lek tempLek = new Lek(naziv, proizvodjac, doza, alergen, kolicina, GenID(), false);
            DoktorService.Instance.dodajNevalidanLek(tempLek, doktori);
            LekoviStorage.Instance.lekovi.Add(tempLek);
            LekoviStorage.Instance.lekoviImena.Add(naziv + doza);
            LekoviStorage.Instance.neverifikovaniLekovi.Add(tempLek);
            LekoviStorage.Instance.Save();
        }
        public void validacijaLeka(Lek lek)
        {
            GetLek(lek).Verifikovan = true;
            LekoviStorage.Instance.neverifikovaniLekovi.Remove(lek);
            DoktorService.Instance.ukloniNevalidanLek(lek);
            LekoviStorage.Instance.Save();
        }

        public void odbijanjeLeka(Lek lek, String komentar)
        {
            NotificationService.Instance.rejectedDrugsNotification(KorisniciStorage.Instance.ulogovaniKorisnik, lek, komentar);
            LekoviStorage.Instance.neverifikovaniLekovi.Remove(lek);
            DoktorService.Instance.ukloniNevalidanLek(lek);
            LekoviStorage.Instance.Save();
        }
        public void izmeniLek(Lek lek)
        {
            foreach (Lek l in LekoviStorage.Instance.lekovi)
            {
                if (l.IdLeka == lek.IdLeka)
                {
                    l.ImeLeka = lek.ImeLeka;
                    l.Proizvodjac = lek.Proizvodjac;
                    l.Kolicina = lek.Kolicina;
                    l.Alergija = lek.Alergija;
                    l.Doza = lek.Doza;
                    l.Verifikovan = lek.Verifikovan;
                }    
            }
            LekoviStorage.Instance.Save();
        }
        public void ukloniLek(Lek lek)
        {
            LekoviStorage.Instance.lekovi.Remove(lek);
            LekoviStorage.Instance.neverifikovaniLekovi.Remove(lek);
            DoktorService.Instance.ukloniNevalidanLek(lek);
            LekoviStorage.Instance.Save();
        }
        public void dodajAlternativu(String alternativa)
        {
            GetLek(LekoviStorage.Instance.selektovanLek).Alternative.Add(GetLek(alternativa));
            LekoviStorage.Instance.Save();
        }
        public void ukloniAlternativu(Lek alternativa)
        {
            GetLek(LekoviStorage.Instance.selektovanLek).Alternative.Remove(GetLek(alternativa));
            LekoviStorage.Instance.Save();
        }
        public string getAlternative(Lek lek)
        {
            string alt = "";
            foreach (Lek l in lek.Alternative)
            {
                if (alt == "")
                {
                    alt += l.ToString();
                }
                else
                {
                   alt += ", " + l.ToString();
                }
            }
            if (alt == "")
            {
                alt = "Nema alternativa :(";
            }
            return alt;
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
        public Lek GetLek(String lek)
        {
            foreach (Lek l in LekoviStorage.Instance.lekovi)
            {
                if (l.ImeLeka + " " + l.Doza == lek)
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
        public ObservableCollection<Lek> getLekovi()
        {
            return LekoviStorage.Instance.lekovi;
        }
        public ObservableCollection<String> getLekoviImena()
        {
            return LekoviStorage.Instance.lekoviImena;
        }
        public ObservableCollection<Lek> getNeverifikovaniLekovi()
        {
            return LekoviStorage.Instance.neverifikovaniLekovi;
        }
        public Lek getSelektovanLek()
        {
            return LekoviStorage.Instance.selektovanLek;
        }
        public void setSelektovanLek(Lek lek)
        {
            LekoviStorage.Instance.selektovanLek = lek;
        }
    }
}
