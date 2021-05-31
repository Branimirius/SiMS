using BolnicaSims.Model;
using BolnicaSims.MVVM.Models;
using BolnicaSims.MVVM.Views;
using BolnicaSims.Storage;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BolnicaSims.MVVM.ViewModel
{
    public class IzvestajUpravnikViewModel : BindableBase
    {
        public ObservableCollection<LekModel> Lekovi;
        
        public IzvestajUpravnikViewModel()
        {
            LoadLekovi();
            
        }
        public void LoadLekovi()
        {
            ObservableCollection<LekModel> lekovi =
                new ObservableCollection<LekModel>();
            foreach (Lek l in LekoviStorage.Instance.lekovi)
            {
                LekModel temp = new LekModel(l.ImeLeka, l.Proizvodjac, l.Doza, l.Kolicina.ToString(), l.IdLeka, l.Verifikovan);
                if (lekovi.Contains(temp))
                {
                    AddKolicinaLekovi(temp, lekovi);
                }
                lekovi.Add(temp);
            }
            

            Lekovi = lekovi;
        }
        public void AddKolicinaLekovi(LekModel lek, ObservableCollection<LekModel> lekovi)
        {
            foreach (LekModel l in lekovi)
            {
                if(l.ToString() == lek.ToString())
                {
                    l.Kolicina += lek.Kolicina;
                }
            }
        }
        
    }
}
