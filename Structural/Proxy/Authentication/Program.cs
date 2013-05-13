using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxy
{
        class Program
        {
                static void Main(string[] args)
                {
                        ProtectedSubjectProxy subject = new ProtectedSubjectProxy();
                        subject.Request();
                        subject.Authenticate("hhjad");
                        subject.Request();
                        subject.Authenticate("hello");
                        subject.Request();
                }
        }
}
