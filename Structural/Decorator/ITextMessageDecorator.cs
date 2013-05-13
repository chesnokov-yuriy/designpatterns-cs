using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
        abstract class ITextMessageDecorator : ITextMessage
        {
                public ITextMessageDecorator(ITextMessage textMessage)
                {
                        this.textMessage = textMessage;
                }

                public abstract void Print(string message);

                public void NewLine()
                {
                        Console.WriteLine();
                }

                protected ITextMessage textMessage;
        }
}
