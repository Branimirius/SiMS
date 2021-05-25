using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BolnicaSims.DTO
{
    public class TerminDTO
    {
        public DateTime VremeTermina { get; set; }
        
        public DateTime KrajTermina { get; set; }
        public Doktor doktor { get; set; }
        public Prostorija prostorija { get; set; }
        public Pacijent pacijent { get; set; }
        public String ImePrezimeDoktora { get; set; }
            
        public String ImePrezimePacijenta { get; set; }
        public TipTermina TipTermina { get; set; }
        public String IdTermina { get; set; }

        public TerminDTO(DateTime vremeTermina, DateTime krajTermina, Doktor doktor, Prostorija prostorija, Pacijent pacijent, string imePrezimeDoktora, string imePrezimePacijenta, TipTermina tipTermina, string idTermina)
        {
            VremeTermina = vremeTermina;
            KrajTermina = krajTermina;
            this.doktor = doktor;
            this.prostorija = prostorija;
            this.pacijent = pacijent;
            ImePrezimeDoktora = imePrezimeDoktora;
            ImePrezimePacijenta = imePrezimePacijenta;
            TipTermina = tipTermina;
            IdTermina = idTermina;
        }
        public TerminDTO(Termin termin)
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
