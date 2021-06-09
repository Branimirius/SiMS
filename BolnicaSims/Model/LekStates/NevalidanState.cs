using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BolnicaSims.Model.LekStates
{
    [Serializable]
    class NevalidanState : ILek
    {
        public bool isValid()
        {
            return false;
        }

        public void setContext(StanjaLeka context)
        {
            throw new NotImplementedException();
        }

        public string stringValid()
        {
            return "Ne";
        }
    }
}
