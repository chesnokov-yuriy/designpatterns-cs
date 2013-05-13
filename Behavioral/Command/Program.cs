using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
        class Program
        {
                static void Main(string[] args)
                {
                        IList<ICommand> commands = new List<ICommand>() 
                        { 
                                new PasteCommand(),
                                new SaveCommand(),
                                new QuitCommand()
                        };

                        commands.ToList().ForEach(c => c.Execute());
                }
        }
}
