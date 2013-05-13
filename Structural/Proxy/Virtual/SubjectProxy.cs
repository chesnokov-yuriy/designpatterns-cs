using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxy
{
        class SubjectProxy : ISubject
        {
                public void Request()
                {
                        if (subject == null)
                        {
                                Console.WriteLine("Subject inactive");
                                subject = new Subject();
                        }
                        Console.WriteLine("Subject active");
                        Console.Write("Proxy call to: ");
                        subject.Request();
                }
                ISubject subject = null;
        }
}
