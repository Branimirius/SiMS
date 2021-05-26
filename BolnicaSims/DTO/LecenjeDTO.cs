using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BolnicaSims.DTO
{
    class LecenjeDTO
    {
        public Pacijent pacijent { get; set; }
        public Prostorija prostorija { get; set; }
        public DateTime pocetak { get; set; }
        
        public DateTime kraj { get; set; }

        public LecenjeDTO(Pacijent pac, DateTime poc, DateTime k, Prostorija pr)
        {
            prostorija = pr;
            pocetak = poc;
            kraj = k;
            pacijent = pac;

        }
    }
}
