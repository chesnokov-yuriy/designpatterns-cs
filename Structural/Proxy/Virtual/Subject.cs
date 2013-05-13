using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxy
{
        class Subject : ISubject
        {
                public void Request()
                {
                        Console.WriteLine("subject request: do some action");
                }
        }
}
