using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BolnicaSims.Service
{
    class TerminService
    {
        private static TerminService instance = null;
        public static TerminService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TerminService();
                }
                return instance;
            }
        }
        public void izmeniTermin(Termin termin, String vreme)
        {
            for (int i = 0; i < TerminStorage.Instance.termini.Count; i++)
            {
                if (TerminStorage.Instance.termini[i].IdTermina == termin.IdTermina)
                {
                    if (termin.IdTermina != "" && termin.IdTermina != " ")
                    {
                        TerminStorage.Instance.termini[i].IdTermina = termin.IdTermina;
                    }
                    if (vreme != "")
                    {
                        TerminStorage.Instance.termini[i].VremeTermina = termin.VremeTermina;
                    }
                    if (termin.ImePrezimeDoktora != "")
                    {
                        TerminStorage.Instance.termini[i].ImePrezimeDoktora = termin.ImePrezimeDoktora;
                    }

                }

            }
            TerminStorage.Instance.Save();
            SekretarView.Instance.refreshTermini();
        }
    }
}
