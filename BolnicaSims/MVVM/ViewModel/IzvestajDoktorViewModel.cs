using BolnicaSims.Model;
using BolnicaSims.MVVM.Models;
using BolnicaSims.Storage;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BolnicaSims.MVVM.ViewModel
{
    class IzvestajDoktorViewModel
    {
        public System.Collections.ObjectModel.ObservableCollection<ReceptModel> Recepti;
        public string Anamneza;
        public IzvestajDoktorViewModel()
        {
            LoadRecepti();
            LoadAnamneza();
        }

        public void LoadRecepti()
        {
            System.Collections.ObjectModel.ObservableCollection<ReceptModel> recepti = new System.Collections.ObjectModel.ObservableCollection<ReceptModel>();
            foreach(Recept r in ReceptiStorage.Instance.recepti)
            {
                if(r.Pacijent != null) { 
                    if(r.Pacijent.korisnik.ImePrezime == PacijentiStorage.Instance.selektovanPacijent.korisnik.ImePrezime)
                    {
                        ReceptModel temp = new ReceptModel(r.Pacijent, r.Doktor, r.Lek, r.Kreni, r.PutaDnevno, r.KolikoDana);
                        recepti.Add(temp);
                    }
                }

            }
            Recepti = recepti;
        }

        public void LoadAnamneza()
        {
            Anamneza = "\n" + PacijentiStorage.Instance.selektovanPacijent.zdravstveniKarton.Anamneza;
        }
    }
}
