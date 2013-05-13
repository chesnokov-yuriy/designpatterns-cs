using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
        class ExclamationTextMessage : ITextMessageDecorator
        {
                public ExclamationTextMessage(ITextMessage textMessage)
                        : base(textMessage)
                {                        
                }

                public override void Print(string message)
                {                        
                        base.textMessage.Print(message);
                        Console.Write("!!!");
                }                
        }
}
