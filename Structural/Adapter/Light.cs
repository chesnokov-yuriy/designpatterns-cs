using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
        class Light
        {
                public void On()
                {
                        Console.WriteLine("light on");
                }

                public void Off()
                {
                        Console.WriteLine("light off");
                }
        }
}
