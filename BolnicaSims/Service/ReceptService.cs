using BolnicaSims.Model;
using BolnicaSims.Storage;
using System;
using System.Collections.Generic;
using System.Text;

namespace BolnicaSims.Service
{
    class ReceptService
    {
        private static ReceptService instance = null;
        public static ReceptService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ReceptService();
                }
                return instance;
            }
        }

        public List<DateTime> vremeUzimanja(Recept recept)
        {
            List<DateTime> vreme = new List<DateTime>();
            DateTime vreme1 = recept.Kreni.AddHours(-2);
            vreme.Add(vreme1);
            double sati = (24 / int.Parse(recept.PutaDnevno));
            for (int j = 1; j <= int.Parse(recept.KolikoDana); j++)
            {
                for (int i = 1; i < int.Parse(recept.PutaDnevno); i++)
                {

                    DateTime vremeTemp = vreme1.AddHours(sati * i);
                    vreme.Add(vremeTemp);
                }
                vreme1 = vreme1.AddDays(1);
            }
            return vreme;
        }

       public void notifikacijaLek(Recept recept)
        {
         
            if (DateTime.Now >= recept.Kreni && DateTime.Now <= recept.Kreni.AddDays(int.Parse(recept.KolikoDana)))
            {
                foreach(DateTime d in vremeUzimanja(recept))
                {
                    if(DateTime.Now >= d && DateTime.Now <= d.AddHours(2))
                    {
                        NotificationService.Instance.sendDrugsNotification(KorisniciStorage.Instance.ulogovaniKorisnik, recept);
                    }
                }
            }
        }

        public Recept getRecept(Recept recept)
        {
            foreach (Recept r in ReceptiStorage.Instance.recepti)
            {
                if(r.Lek == recept.Lek && r.KolikoDana==recept.KolikoDana)
                {
                    return r;
                }
               
            }
            return null;
        }

    }
}
