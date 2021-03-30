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

      private TipPola Pol { get; set; }

        public ZdravstveniKarton(String imeRoditelja, String brojKartona, String brojknjizice, String pol)
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
        }
    }
}