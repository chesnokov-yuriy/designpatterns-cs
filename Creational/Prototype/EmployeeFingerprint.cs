using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype
{
        [Serializable]
        class EmployeeFingerprint
        {
                public EmployeeFingerprint()
                {
                        Data = Guid.NewGuid();
                }

                public Guid Data { get; set; }

                public override string ToString()
                {
                        return String.Format("{0}", Data.ToString());
                }
        }
}
