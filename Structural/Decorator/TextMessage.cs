using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
        class TextMessage : ITextMessage
        {               
                public void Print(string message)
                {
                        Console.Write(message);
                }

                public void NewLine()
                {
                        Console.WriteLine();
                }
        }
}
