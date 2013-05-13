using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
        interface ISubject
        {
                void Attach(IObserver observer);
                void Detach(IObserver observer);
                void Notify();

                void Dispose();
        }
}
