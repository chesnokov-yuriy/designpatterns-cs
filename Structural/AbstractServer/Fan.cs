using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractServer
{
        class Fan : ISwitchable
        {
                public void TurnOn()
                {
                        Console.WriteLine("fan turn on");
                }

                public void TurnOff()
                {
                        Console.WriteLine("fan turn off");
                }
        }
}
