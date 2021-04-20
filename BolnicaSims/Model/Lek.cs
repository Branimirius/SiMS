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

        public Lek (String a, String b, String c, String aa)
        {
            ImeLeka = a;
            Proizvodjac = b;
            Doza = c;
            Alergija = a;
        }

    }
}
