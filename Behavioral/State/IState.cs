using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
        interface IState
        {
                void Coin(Turnstile context);
                void Pass(Turnstile context);
        }
}
