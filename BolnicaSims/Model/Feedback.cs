using System;
using System.Collections.Generic;
using System.Text;

namespace BolnicaSims.Model
{
    [Serializable]
    public class Feedback
    {
        public String Primedbe { get; set; }
        public String Bagovi { get; set; }

        public int Ocena { get; set; }

        public Feedback(string primedbe, string bagovi, int ocena)
        {
            Primedbe = primedbe;
            Bagovi = bagovi;
            Ocena = ocena;
        }
    }
}
