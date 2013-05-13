using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
        class BracketedTextMessage : ITextMessageDecorator
        {
                public BracketedTextMessage(ITextMessage textMessage)
                        : base(textMessage)
                {                        
                }

                public override void Print(string message)
                {
                        Console.Write("[");
                        base.textMessage.Print(message);
                        Console.Write("]");
                }                
        }
}
