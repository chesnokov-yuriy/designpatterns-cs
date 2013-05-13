using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
        class Window
        {
                public Window(IWindowImplementation windowImplementation)
                {
                        this.windowImplementation = windowImplementation;
                }

                public void DrawText(string text)
                {
                        this.windowImplementation.DrawText(text);
                }

                IWindowImplementation windowImplementation;
        }
}
