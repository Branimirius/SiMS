using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BolnicaSims.MVVM.Models
{
    class TerminModel
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
        public TerminModel(String idTermina, String datum, String doktor)
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
        public TerminModel(String idTermina, DateTime datum, String doktor, int trajanje)
        {
            IdTermina = idTermina;
            VremeTermina = datum;
            ImePrezimeDoktora = doktor;
            KrajTermina = VremeTermina.AddMinutes(trajanje);
        }
        public TerminModel(String idTermina, DateTime vremeTermina, DateTime krajTermina, Doktor doktor)
        {
            this.IdTermina = idTermina;
            this.VremeTermina = vremeTermina;
            this.KrajTermina = krajTermina;
            this.doktor = doktor;
            this.pacijent = pacijent;
            this.ImePrezimeDoktora = doktor.korisnik.ImePrezime;
        }
        public TerminModel(String idTermina, DateTime vremeTermina, int trajanje, Pacijent pacijent, Doktor doktor, Prostorija prostorija)
        {
            this.IdTermina = idTermina;
            this.VremeTermina = vremeTermina;
            this.TrajanjeMin = trajanje;
            this.pacijent = pacijent;
            this.doktor = doktor;
            this.prostorija = prostorija;
        }

        //public ObservableCollection<Doktor> doktori = new ObservableCollection<Doktor>();


        public TerminModel() { }

    }
}
