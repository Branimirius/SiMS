﻿using BolnicaSims.Controller;
using BolnicaSims.MVVM.Models;
using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BolnicaSims.MVVM.ViewModel
{
    class IzvestajPacijentViewModel
    {
        public System.Collections.ObjectModel.ObservableCollection<TerminModel> Termini;

        public IzvestajPacijentViewModel()
        {
            LoadTermini();

        }
        public void LoadTermini()
        {
            System.Collections.ObjectModel.ObservableCollection<TerminModel> termini =
                new System.Collections.ObjectModel.ObservableCollection<TerminModel>();
            foreach (Termin t in PacijentController.Instance.getUlogovaniPacijent().termini)
            {
                TerminModel temp = new TerminModel(t.IdTermina, t.VremeTermina, t.KrajTermina, t.doktor);
                termini.Add(temp);
                //TODO: da upadaju samo oni iz vremenskog intervala
            }

            Termini = termini;


            
        }
        
    }
}
