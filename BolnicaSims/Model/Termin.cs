/***********************************************************************
 * Module:  Termin.cs
 * Author:  piwneuh
 * Purpose: Definition of the Class Model.Termin
 ***********************************************************************/

using System;
using System.Collections.ObjectModel;

namespace Model
{

    [Serializable]
    public class Termin
    {

        
        public DateTime VremeTermina
        {
            get
            ;
            set
            ;
        }

        /*public Doktor[] get_doktor()
        ;

        public void set_doktor(Doktor[] value)
        ;

        public Pacijent[] get_pacijent()
        ;

        public void set_pacijent(Pacijent[] value)
        ;

        public Prostorija get_MestoTermina()
        ;

        public void set_MestoTermina(Prostorija value)
        ;*/

        
        public Doktor doktor;
        public Prostorija prostorija;
        public Pacijent pacijent;
        public String ImePrezimeDoktora
        {
            get;
            set;
        }
        public String ImePrezimePacijenta
        {
            get;
            set;
        }


        /// <pdGenerated>default parent getter</pdGenerated>
        public Prostorija GetProstorija()
      {
         return prostorija;
      }
      
      /// <pdGenerated>default parent setter</pdGenerated>
      /// <param>newProstorija</param>
      /*public void SetProstorija(Prostorija newProstorija)
      {
         if (this.prostorija != newProstorija)
         {
            if (this.prostorija != null)
            {
               Prostorija oldProstorija = this.prostorija;
               this.prostorija = null;
               oldProstorija.RemoveTermin(this);
            }
            if (newProstorija != null)
            {
               this.prostorija = newProstorija;
               this.prostorija.AddTermin(this);
            }
         }
      }*/
   
   
      
      private TipTermina TipTermina
      {
         get
         ;
         set
         ;
      }
      
      private Inventar PotrebanInventar
      {
         get
         ;
         set
         ;
      }

        public String IdTermina
      {
         get
         ;
         set
         ;
      }
      
      private StatusTermina StatusTermina
      {
         get
         ;
         set
         ;
      }
        public Termin(String idTermina, String datum, String doktor)
        {
            IdTermina = idTermina;
            if (datum != "")
            {
                VremeTermina = DateTime.Parse(datum);
            }
            else
            {
                VremeTermina = default;
            }
            ImePrezimeDoktora = doktor;
        }

        public ObservableCollection<Termin> termini = new ObservableCollection<Termin>();
        public ObservableCollection<Doktor> doktori = new ObservableCollection<Doktor>();


        public Termin() { }

    }
}