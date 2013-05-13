using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
        class Program
        {
                static void Main(string[] args)
                {                        
                        ITextMessage simpleMessage = new TextMessage();
                        simpleMessage.Print("hello");
                        simpleMessage.NewLine();

                        ITextMessage exclamationMessage = new ExclamationTextMessage(simpleMessage);
                        exclamationMessage.Print("hello");
                        exclamationMessage.NewLine();

                        ITextMessage bracketedExclamationMessage = new BracketedTextMessage(exclamationMessage);
                        bracketedExclamationMessage.Print("hello");
                        bracketedExclamationMessage.NewLine();

                        ITextMessage exclamationBracketsMessage = new ExclamationTextMessage(new BracketedTextMessage(new TextMessage()));
                        exclamationBracketsMessage.Print("hello");
                }
        }
}
