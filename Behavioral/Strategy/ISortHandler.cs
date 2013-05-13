using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
        interface ISortHandler
        {
                void SetArray(object array);
                int Length();                
                bool OutOfOrder(int index);
                void Swap(int index);                                
        }
}
