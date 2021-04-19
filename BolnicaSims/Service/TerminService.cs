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
        public void izmeniTermin(Termin termin)
        {
            for (int i = 0; i < TerminStorage.Instance.termini.Count; i++)
            {
                if (TerminStorage.Instance.termini[i].IdTermina == termin.IdTermina)
                {
                    if (termin.IdTermina != "" && termin.IdTermina != " ")
                    {
                        TerminStorage.Instance.termini[i].IdTermina = termin.IdTermina;
                    }
                    if (termin.VremeTermina.ToString() != "")
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

        public String GenID()
        {
            int a = int.Parse(TerminStorage.Instance.termini[TerminStorage.Instance.termini.Count - 1].IdTermina) + 1;
            return a.ToString();
        }
    }
}
