/***********************************************************************
 * Module:  ZdravstveniKarton.cs
 * Author:  temerin
 * Purpose: Definition of the Class ZdravstveniKarton
 ***********************************************************************/

using System;

namespace Model
{
   public class ZdravstveniKarton
   {
      private String ImeRoditelja { get; set; }
      
      private String BrojKartona { get; set; }
   
      private String BrojZdravstveneKnjizice { get; set; }
   
      private TipPola Pol { get; set; }
    
   }
}