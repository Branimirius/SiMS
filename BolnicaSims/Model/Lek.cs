using System;
using System.Collections.Generic;
using System.Text;

namespace BolnicaSims.Model
{
    [Serializable]
    class Lek
    {
        public String ImeLeka { get; set; }
        
        public String Proizvodjac { get; set; }

        public String Doza { get; set; }

        public String Alergija { get; set; }

        public int Kolicina { get; set; }

        public String IdLeka { get; set; }

        public Lek (String a, String b, String c, String aa, String d, String Id)
        {
            ImeLeka = a;
            Proizvodjac = b;
            Doza = c;
            Alergija = aa;
            if(d == "0" || d == "")
            {
                Kolicina = 0;
            }
            else
            {
                Kolicina = int.Parse(d);
            }
            IdLeka = Id;
        }

    }
}
