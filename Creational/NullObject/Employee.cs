using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NullObject
{
        class Employee : IEmployee
        {
                public override bool IsPayDay()
                {                        
                        return true;
                }

                public override void Pay()
                {
                        Console.WriteLine("paid to {0}", base.Name);
                }                
        }
}
