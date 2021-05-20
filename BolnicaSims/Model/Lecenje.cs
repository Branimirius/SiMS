using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BolnicaSims.Model
{
    [Serializable]
    class Lecenje
    {
        public Pacijent Pacijent { get; set; }

        public DateTime Pocetak { get; set; }

        public DateTime Kraj { get; set; }

        public Prostorija Prostorija { get; set; }

        public Lecenje(Pacijent pacijent, DateTime pocetak, DateTime kraj, Prostorija prostorija)
        {
            Pacijent = pacijent;
            Pocetak = pocetak;
            Kraj = kraj;
            Prostorija = prostorija;
        }

    }
}
