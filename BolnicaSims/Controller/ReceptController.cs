using BolnicaSims.Model;
using BolnicaSims.Service;
using BolnicaSims.Storage;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BolnicaSims.Controller
{
    class ReceptController
    {
        private static ReceptController instance = null;
        public static ReceptController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ReceptController();
                }
                return instance;
            }
        }
        public ObservableCollection<Recept> getRecepti()
        {
            return ReceptService.Instance.getRecepti();
        }
    }
}
