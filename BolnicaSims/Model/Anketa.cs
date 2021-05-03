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

        public String Doktor { get; set; }

        public String Ocena { get; set; }

        public String Komentar { get; set; }





        public Anketa(String doktor, String ocena, String komentar,Pacijent pacijent)
        {
            Pacijent = pacijent;
            Doktor = doktor;
            Ocena = ocena;
            Komentar = komentar;
        }
        public Anketa (String ocena, String komentar, Pacijent pacijent)
        {
            Pacijent = pacijent;
            Doktor = null;
            Ocena = ocena;
            Komentar = komentar;
        }
    }
}
