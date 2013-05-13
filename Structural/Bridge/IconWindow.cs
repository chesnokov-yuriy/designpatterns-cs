using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
        class IconWindow : Window
        {
                public IconWindow(IWindowImplementation windowImplementation)
                        : base(windowImplementation)
                {
                }

                public void DrawIconText(string text)
                {
                        DrawText(text.ToLower());
                }
        }
}
