using System;
using System.Collections.Generic;
using System.Text;
using BolnicaSims.Service;


namespace BolnicaSims.Controller
{
    class KorisnikController
    {
        private static KorisnikController instance = null;
        public static KorisnikController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new KorisnikController();
                }
                return instance;
            }
        }
         public int Login(string username, string password)
        {
            return KorisnikService.Instance.Login(username, password);
        }
    }
}
