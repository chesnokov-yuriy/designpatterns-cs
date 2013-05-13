using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractServer
{
        class Light : ISwitchable
        {
                public void TurnOn()
                {
                        Console.WriteLine("light turn on");
                }

                public void TurnOff()
                {
                        Console.WriteLine("light turn off");
                }
        }
}
