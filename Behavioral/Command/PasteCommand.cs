using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
        class PasteCommand : ICommand
        {
                public void Execute()
                {
                        Console.WriteLine("paste command execute");
                }

                public void Undo()
                {
                        Console.WriteLine("paste command undo");
                }
        }
}
