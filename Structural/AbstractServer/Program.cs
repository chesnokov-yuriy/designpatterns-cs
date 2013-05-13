using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractServer
{
        class Program
        {
                static void Main(string[] args)
                {                        
                        Switch sw = new Switch(new Light());
                        sw.Click();

                        sw = new Switch(new Fan());
                        sw.Click();
                }
        }
}
