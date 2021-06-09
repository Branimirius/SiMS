using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BolnicaSims.Model.LekStates
{
    [Serializable]
    class ValidanState : ILek
    {
        public bool isValid()
        {
            return true;
        }

        public void setContext(StanjaLeka context)
        {
            throw new NotImplementedException();
        }

        public string stringValid()
        {
            return "Da";
        }
    }
}
