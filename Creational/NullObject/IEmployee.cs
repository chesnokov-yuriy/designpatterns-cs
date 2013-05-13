using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NullObject
{
        abstract class IEmployee
        {
                public string Name { get; set; }
                public abstract bool IsPayDay();
                public abstract void Pay();
        }
}
