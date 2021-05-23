using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BolnicaSims.Model
{
    [Serializable]
    public class Notifikacija
    {
        public String Tekst { get; set; }
        public String Posiljalac { get; set; }
        public String Naslov { get; set; }

        public DateTime VremeNotifikacije { get; set; }
        public Notifikacija(String naslov, String posiljalac, String tekst)
        {
            Naslov = naslov;
            Posiljalac = posiljalac;
            Tekst = tekst;
        }

        public Notifikacija(String naslov, String posiljalac, String tekst,DateTime vremeNotifikacije)
        {
            Naslov = naslov;
            Posiljalac = null;
            Tekst = null;
            VremeNotifikacije = vremeNotifikacije;
        }
   
    }
}
