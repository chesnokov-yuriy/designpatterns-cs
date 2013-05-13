using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
        class TurnstileLockedState : IState
        {
                public void Coin(Turnstile context)
                {
                        context.Unlock();
                        context.ChangeState(new TurnstileUnlockedState());
                }

                public void Pass(Turnstile context)
                {
                        context.Alarm();
                }
        }
}
