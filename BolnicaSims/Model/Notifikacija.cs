using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BolnicaSims.Model
{
    public class Notifikacija
    {
        public String Tekst;
        public String Posiljalac;
        public String Naslov;
        public Notifikacija(String naslov, String posiljalac, String tekst)
        {
            Naslov = naslov;
            Posiljalac = posiljalac;
            Tekst = tekst;
        }
    }
}
