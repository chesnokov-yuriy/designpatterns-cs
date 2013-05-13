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
                        SubjectProxy subject = new SubjectProxy();
                        subject.Request();
                        subject.Request();
                }
        }
}
