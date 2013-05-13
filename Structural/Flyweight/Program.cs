using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlyWeight
{
        class Program
        {
                static void Main(string[] args)
                {
                        string text = "there is a message to display";
                        
                        FlyweightFactory factory = new FlyweightFactory();
                        foreach (char c in text)
                                factory[c].Print();
                }
        }
}
