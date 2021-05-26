/***********************************************************************
 * Module:  Termin.cs
 * Author:  piwneuh
 * Purpose: Definition of the Class Model.Termin
 ***********************************************************************/

using BolnicaSims.DTO;
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
        public DateTime KrajTermina { get; set; }
        public int TrajanjeMin { get; set; }
        

        
        public Doktor doktor { get; set; }
        public Prostorija prostorija { get; set; }
        public Pacijent pacijent { get; set; }
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


        
        public Prostorija GetProstorija()
      {
         return prostorija;
      }
       
   
      
      public TipTermina TipTermina
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
        public Termin(String idTermina, DateTime datum, String doktor, int trajanje)
        {
            IdTermina = idTermina;                                   
            VremeTermina = datum;         
            ImePrezimeDoktora = doktor;
            KrajTermina = VremeTermina.AddMinutes(trajanje);
        }
        public Termin(String idTermina, DateTime vremeTermina, DateTime krajTermina, Doktor doktor, Pacijent pacijent, String imeDoktora, String imePacijenta)
        {
            this.IdTermina = idTermina;
            this.VremeTermina = vremeTermina;
            this.KrajTermina = krajTermina;
            this.doktor = doktor;
            this.pacijent = pacijent;
            this.ImePrezimeDoktora = imeDoktora;
            this.ImePrezimePacijenta = imePacijenta;
        }
        public Termin(String idTermina, DateTime vremeTermina, int trajanje, Pacijent pacijent, Doktor doktor, Prostorija prostorija)
        {
            this.IdTermina = idTermina;
            this.VremeTermina = vremeTermina;
            this.TrajanjeMin = trajanje;
            this.pacijent = pacijent;
            this.doktor = doktor;
            this.prostorija = prostorija;
        }

        public ObservableCollection<Doktor> doktori = new ObservableCollection<Doktor>();


        public Termin() { }

        public Termin(TerminDTO termin)
        {
            VremeTermina = termin.VremeTermina;
            KrajTermina = termin.KrajTermina;
            this.doktor = termin.doktor;
            this.prostorija = termin.prostorija;
            this.pacijent = termin.pacijent;
            ImePrezimeDoktora = termin.ImePrezimeDoktora;
            ImePrezimePacijenta = termin.ImePrezimePacijenta;
            TipTermina = termin.TipTermina;
            IdTermina = termin.IdTermina;
        }
    }
}