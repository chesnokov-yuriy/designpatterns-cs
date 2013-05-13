using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype
{
        [Serializable]
        class Employee : IPrototype<Employee>
        {
                public string Name { get; set; }
                public string Country { get; set; }
                public EmployeeFingerprint Fingerprint { get; set; }
        }
}
