using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BolnicaSims.Model
{
    [Serializable]
    public class Recept
    {
        public Pacijent Pacijent { get; set; }

        public Doktor Doktor { get; set; }

        public String Lek { get; set; }

        public DateTime Kreni { get; set; }

        public String NaSati { get; set; }

        public String KolikoPuta { get; set; }



        public Recept(Pacijent pacijent, Doktor doktor, String lek, DateTime kreni, String naSati, String kolikoPuta)
        {
            Pacijent = pacijent;
            Doktor = doktor;
            Lek = lek;
            Kreni = kreni;
            NaSati = naSati;
            KolikoPuta = kolikoPuta;
        }
    }
}
