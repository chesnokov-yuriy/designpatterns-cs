using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
        class MacWindowImplementation : IWindowImplementation
        {
                public void DrawText(string text)
                {
                        Console.WriteLine("Mac DrawText(): {0}", text);
                }
        }
}
