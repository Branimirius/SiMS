using BolnicaSims.Controller;
using BolnicaSims.MVVM.Models;
using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BolnicaSims.MVVM.ViewModel
{
    public class IzvestajPacijentViewModel
    {
        public ObservableCollection<TerminModel> Termini;

        public IzvestajPacijentViewModel()
        {
            LoadTermini();

        }
        public void LoadTermini()
        {
            ObservableCollection<TerminModel> termini =
                new ObservableCollection<TerminModel>();
            foreach (Termin t in PacijentController.Instance.getUlogovaniPacijent().termini)
            {
                TerminModel temp = new TerminModel(t.IdTermina, t.VremeTermina, t.KrajTermina, t.doktor);
                termini.Add(temp);
    
            }

            Termini = termini;


            
        }
        public ObservableCollection<TerminModel> getTermini(DateTime datumOd, DateTime datumDo)
        {
            ObservableCollection<TerminModel> retTermini = new ObservableCollection<TerminModel>();
            foreach (TerminModel tm in Termini)
            {
                if(tm.VremeTermina >= datumOd && tm.VremeTermina <= datumDo)
                {
                    retTermini.Add(tm);
                }
            }
            return retTermini;

            
        }


    }
}
