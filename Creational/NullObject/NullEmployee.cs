using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NullObject
{
        class NullEmployee : IEmployee
        {
                public override bool IsPayDay()
                {                        
                        return false;
                }

                public override void Pay()
                {
                        return;
                }
        }
}
