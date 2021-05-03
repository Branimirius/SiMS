using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BolnicaSims.Model
{
    [Serializable]
    public class Anketa
    {
        public Pacijent Pacijent { get; set; }

        public Doktor Doktor { get; set; }

        public String Ocena { get; set; }

        public String Komentar { get; set; }





        public Anketa(Pacijent pacijent, Doktor doktor, String ocena, String komentar)
        {
            Pacijent = pacijent;
            Doktor = doktor;
            Ocena = ocena;
            Komentar = komentar;
        }
    }
}
