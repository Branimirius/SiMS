/***********************************************************************
 * Module:  ZdravstveniKarton.cs
 * Author:  temerin
 * Purpose: Definition of the Class ZdravstveniKarton
 ***********************************************************************/

using System;

namespace Model
{
    [Serializable]
    public class ZdravstveniKarton
   {
      public String ImeRoditelja { get; set; }

      public String BrojKartona { get; set; }

      public String BrojZdravstveneKnjizice { get; set; }
       
      public String Anamneza { get; set; }

      public String Alergije { get; set; }

      public TipPola Pol { get; set; }

      public ZdravstveniKarton(String imeRoditelja, String brojKartona, String brojknjizice, String pol, String anamneza, String alergije)
      {
            ImeRoditelja = imeRoditelja;
            BrojKartona = brojKartona;
            BrojZdravstveneKnjizice = BrojZdravstveneKnjizice;
            if (pol == "M" || pol == "muski" || pol == "Muski")
            {
                Pol = TipPola.M;
            }
            else
            {
                Pol = TipPola.Z;
            }
            Anamneza = anamneza;
            Alergije = alergije;
      }
      
      public String getPol()
        {
            if(this.Pol == TipPola.M)
            {
                return "M";
            }
            return "Z";
        }
    }
}