using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractServer
{
        class Switch
        {
                public Switch(ISwitchable switchable)
                {
                        this.switchable = switchable;
                }

                public void Click()
                {
                        this.switchable.TurnOn();
                        this.switchable.TurnOff();
                }                

                ISwitchable switchable;
        }
}
