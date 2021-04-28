using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BolnicaSims.Model
{
    [Serializable]
    public class Renoviranje
    {
        public DateTime Pocetak { get; set; }
        public DateTime Kraj { get; set; }
        public Prostorija Prostorija { get; set; }

        public Renoviranje(DateTime pocetak, DateTime kraj, Prostorija prostorija)
        {
            Pocetak = pocetak;
            Kraj = kraj;
            Prostorija = prostorija;
        }
    }
}
