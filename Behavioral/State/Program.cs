using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
        class Program
        {
                static void Main(string[] args)
                {
                        Turnstile turnstile = new Turnstile(new TurnstileLockedState());
                        turnstile.Pass();
                        turnstile.Coin();
                        turnstile.Coin();
                        turnstile.Pass();
                }
        }
}
