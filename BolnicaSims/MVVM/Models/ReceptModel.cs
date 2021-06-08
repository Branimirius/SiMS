using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BolnicaSims.MVVM.Models
{
    public class ReceptModel
    {
        public Pacijent Pacijent { get; set; }

        public Doktor Doktor { get; set; }

        public String Lek { get; set; }

        public DateTime Kreni { get; set; }

        public String PutaDnevno { get; set; }

        public String KolikoDana { get; set; }



        public ReceptModel(Pacijent pacijent, Doktor doktor, String lek, DateTime kreni, String naSati, String kolikoPuta)
        {
            Pacijent = pacijent;
            Doktor = doktor;
            Lek = lek;
            Kreni = kreni;
            PutaDnevno = naSati;
            KolikoDana = kolikoPuta;
        }
    }
}
