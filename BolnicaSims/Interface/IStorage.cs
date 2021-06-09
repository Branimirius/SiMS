using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BolnicaSims.Interface
{
    interface IStorage
    {
        public void Load();

        public void Save();
    }
}
