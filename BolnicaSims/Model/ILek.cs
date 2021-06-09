using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BolnicaSims.Model
{
    
    public interface ILek
    {
        public void setContext(StanjaLeka context);
        public bool isValid();
        public String stringValid();
    }
}
