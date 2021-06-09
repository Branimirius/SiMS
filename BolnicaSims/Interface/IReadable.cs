using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BolnicaSims.Interface
{
    interface IReadable
    {
        public ObservableCollection<object> Read();
    }
}
