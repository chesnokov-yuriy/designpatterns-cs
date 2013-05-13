using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxy
{
        class ProtectedSubjectProxy : ISubject
        {
                public void Authenticate(string password)
                {
                        if (password == this.password)
                                this.subject = new Subject();
                        else
                                Console.WriteLine("Authentication failed");
                }

                public void Request()
                {
                        if (subject == null)
                        {
                                Console.WriteLine("Subject needs authentication");
                                return;
                        }
                        Console.WriteLine("Subject is authenticated");
                        Console.Write("Proxy call to: ");
                        subject.Request();
                }

                string password = "hello";
                ISubject subject = null;
        }
}
