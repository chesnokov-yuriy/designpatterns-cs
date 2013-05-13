using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
        class LightAdapter : ISwitchable
        {
                public void TurnOn()
                {
                        this.light.On();
                }

                public void TurnOff()
                {
                        this.light.Off();
                }

                Light light = new Light();
        }
}
