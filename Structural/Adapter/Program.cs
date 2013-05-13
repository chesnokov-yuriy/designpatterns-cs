using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
        class Program
        {
                static void Main(string[] args)
                {
                        Switch sw = new Switch(new LightAdapter());
                        sw.Click();
                }
        }
}
