using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BolnicaSims.Service
{
    class BanovanjeService
    {
        private static BanovanjeService instance = null;
        public static BanovanjeService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BanovanjeService();
                }
                return instance;
            }
        }
        public void banujPacijenta(DateTime vreme, Pacijent pacijent)
        {
            pacijent.isBanned = true;
            pacijent.vremeBanovanja = vreme;
            PacijentiStorage.Instance.Save();

        }
        public Boolean proveriBan(DateTime trenutnoVreme, Pacijent pacijent)
        {
            if (pacijent.vremeBanovanja == null)
            {
                return false;
            }
            if (trenutnoVreme > pacijent.vremeBanovanja.AddDays(1))
            {
                return false;
            }
            return true;
        }
    }
}
