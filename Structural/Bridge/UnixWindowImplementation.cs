using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
        class UnixWindowImplementation : IWindowImplementation
        {
                public void DrawText(string text)
                {
                        Console.WriteLine("Linux DrawText(): {0}", text);
                }
        }
}
