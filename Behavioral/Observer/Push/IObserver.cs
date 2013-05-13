using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
        interface IObserver
        {
                void Update(Object hint);

                void Dispose();
        }
}
