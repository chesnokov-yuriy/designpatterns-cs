using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
        class QuitCommand : ICommand
        {
                public void Execute()
                {
                        Console.WriteLine("quit command execute");
                }

                public void Undo()
                {
                        Console.WriteLine("quit command undo");
                }
        }
}
