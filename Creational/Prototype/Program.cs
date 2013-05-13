using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype
{
        class Program
        {
                static void Main(string[] args)
                {
                        EmployeePrototypeManager manager = new EmployeePrototypeManager();
                        Employee bob = manager.Prototypes["bob"].Clone();
                        Console.WriteLine("{0} {1} {2}", bob.Name, bob.Country, bob.Fingerprint.ToString());
                        Employee marry = manager.Prototypes["marry"].DeepCopy();
                        Console.WriteLine("{0} {1} {2}", marry.Name, marry.Country, marry.Fingerprint.ToString());
                }
        }
}
