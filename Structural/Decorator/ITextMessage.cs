using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
        interface ITextMessage
        {
                void Print(string message);
                void NewLine();
        }
}
