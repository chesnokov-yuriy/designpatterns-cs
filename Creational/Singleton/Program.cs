using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Singleton
{
        class Program
        {
                static void Main(string[] args)
                {
                        Singleton s1 = Singleton.Instance;
                        Singleton s2 = Singleton.Instance;
                        Console.WriteLine("s1 = s2 is {0}", s1 == s2);
                        Debug.Assert(s1 == s2);
                }
        }
}
