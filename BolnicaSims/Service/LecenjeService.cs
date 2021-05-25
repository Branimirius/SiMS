using System;
using System.Collections.Generic;
using System.Text;

namespace BolnicaSims.Service
{
    class LecenjeService
    {
        private static LecenjeService instance = null;
        public static LecenjeService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LecenjeService();
                }
                return instance;
            }
        }
    }
}
