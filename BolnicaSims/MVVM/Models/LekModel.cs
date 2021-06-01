using System;
using System.Collections.Generic;
using System.Text;

namespace BolnicaSims.MVVM.Models
{
    public class LekModel
    {
        public String ImeLeka { get; set; }

        public String Proizvodjac { get; set; }

        public String Doza { get; set; }

        //public String Alergija { get; set; }

        public int Kolicina { get; set; }

        public String IdLeka { get; set; }

        public Boolean Verifikovan { get; set; }

        public String StringValid
        {
            get { return Verifikovan ? "Da" : "Ne"; }
        }

        //public ObservableCollection<Lek> Alternative { get; set; }
        public LekModel (String naziv, String proizvodjac, String doza, String kolicina, String Id, Boolean verifikovan)
        {
            ImeLeka = naziv;
            Proizvodjac = proizvodjac;
            Doza = doza;
            if (kolicina == "0" || kolicina == "")
            {
                Kolicina = 0;
            }
            else
            {
                Kolicina = int.Parse(kolicina);
            }
            IdLeka = Id;
            Verifikovan = verifikovan;
        }

        public override string ToString()
        {
            return ImeLeka + " " + Doza;
        }
    }
}
