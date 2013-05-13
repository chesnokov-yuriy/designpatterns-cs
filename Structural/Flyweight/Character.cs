using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlyWeight
{
        class Character : IFlyweight
        {
                public Character(char c)
                {
                        this.character = c;
                }

                public void Print()
                {
                        Console.Write(this.character);
                }

                char character;
        }
}
