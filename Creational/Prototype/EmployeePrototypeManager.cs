using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype
{        
        class EmployeePrototypeManager
        {
                public EmployeePrototypeManager()
                {                                                
                        Prototypes.Add("bob", new Employee() { Name = "bob", Country = "USA", Fingerprint = new EmployeeFingerprint() });
                        Prototypes.Add("marry", new Employee() { Name = "marry", Country = "UK", Fingerprint = new EmployeeFingerprint() });
                        Prototypes.Add("alice", new Employee() { Name = "alice", Country = "EU", Fingerprint = new EmployeeFingerprint() });
                }

                public IDictionary<string, Employee> Prototypes = new Dictionary<string, Employee>();
        }
}
