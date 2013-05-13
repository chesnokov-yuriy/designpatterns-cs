using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
        class ApplicationWindow : Window
        {
                public ApplicationWindow(IWindowImplementation windowImplementation)
                        : base(windowImplementation)
                {
                }

                public void DrawApplicationText(string text)
                {
                        DrawText(text.ToUpper());
                }
        }
}
