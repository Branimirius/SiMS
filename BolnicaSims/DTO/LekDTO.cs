using System;
using System.Collections.Generic;
using System.Text;

namespace BolnicaSims.DTO
{
    class LekDTO
    {
        public String Naziv { get; set; }
        public String Proizvodjac { get; set; }
        public String Doza { get; set; }
        public String Alergen { get; set; }
        public String Kolicina { get; set; }
        public Boolean Validan { get; set; }

        public LekDTO(string naziv, string proizvodjac, string doza, string alergen, string kolicina, bool validan)
        {
            Naziv = naziv;
            Proizvodjac = proizvodjac;
            Doza = doza;
            Alergen = alergen;
            Kolicina = kolicina;
            Validan = validan;
        }
    }
}
