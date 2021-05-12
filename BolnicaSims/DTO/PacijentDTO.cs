using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BolnicaSims.DTO
{
    public class PacijentDTO
    {
        //Korisnik
        public KorisnikDTO korisnik { get; set; }

        //Zdravstveni karton
        public String ImeRoditelja { get; set; }

        public String BrojKartona { get; set; }

        public String BrojZdravstveneKnjizice { get; set; }

        public String Anamneza { get; set; }

        public String Alergije { get; set; }

        public TipPola Pol { get; set; }
        public String PolString { get; set; }

        public PacijentDTO(KorisnikDTO korisnik, string imeRoditelja, string brojZdravstveneKnjizice, string anamneza, string alergije, TipPola pol)
        {
            this.korisnik = korisnik;
            ImeRoditelja = imeRoditelja;            
            BrojZdravstveneKnjizice = brojZdravstveneKnjizice;
            Anamneza = anamneza;
            Alergije = alergije;
            Pol = pol;
            if (pol == TipPola.M)
            {
                PolString = "M";
            }
            else
            {
                PolString = "Z";
            }
        }
    }
}
