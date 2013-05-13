using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
        abstract class IEquipment
        {                
                public string Name { get; set; }
                public abstract int Price { get; set; }

                public abstract void Add(IEquipment equipment);
                public abstract void Remove(IEquipment equipment);
                public abstract void Run();
        }
}
