using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
        class SaveCommand : ICommand
        {
                public void Execute()
                {
                        Console.WriteLine("save command execute");
                }

                public void Undo()
                {
                        Console.WriteLine("save command undo");
                }
        }
}
