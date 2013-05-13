using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
        class TurnstileUnlockedState : IState
        {
                public void Coin(Turnstile context)
                {
                        context.ReturnCoin();
                }

                public void Pass(Turnstile context)
                {                        
                        context.Lock();
                        context.ChangeState(new TurnstileLockedState());
                }
        }
}
