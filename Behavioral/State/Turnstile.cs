using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
        class Turnstile
        {
                public Turnstile(IState state)
                {
                        ChangeState(state);
                }

                public void ChangeState(IState state)
                {
                        this.state = state;
                        Console.WriteLine("{0}", state.GetType());
                }

                public void Coin()
                {
                        Console.Write(" inserting coin... ");
                        this.state.Coin(this);
                }

                public void Pass()
                {
                        Console.Write(" passing through turnstile... ");
                        this.state.Pass(this);
                }

                internal void Lock()
                {
                        this.isLocked = true;
                        Console.WriteLine("turnstile is locked");
                }

                internal void Unlock()
                {
                        this.isLocked = false;
                        Console.WriteLine("turnstile is open");
                }

                internal void Alarm()
                {
                        Console.WriteLine("passing alarm");
                }

                internal void ReturnCoin()
                {
                        if (!this.isLocked)
                                Console.WriteLine("coin returned as turnstile is already open");
                }

                bool isLocked = true;
                IState state;
        }
}
