using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento
{
        class Program
        {
                static void Main(string[] args)
                {
                        Stack<Memento> caretaker = new Stack<Memento>();

                        Originator originator = new Originator();
                        
                        originator.DoWork("1st string to add");
                        caretaker.Push(originator.CreateMemento());
                        originator.DoWork("2nd string to add");
                        caretaker.Push(originator.CreateMemento());
                        originator.DoWork("3rd string to add");
                        
                        originator.PrintMe();

                        Console.WriteLine("Cancel last Originator operation:");
                        originator.SetMemento(caretaker.Pop());

                        originator.PrintMe();
                }
        }
}
