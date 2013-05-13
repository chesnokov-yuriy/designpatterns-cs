using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Monostade
{
        class Program
        {
                static void Main(string[] args)
                {
                        Monostade m1 = new Monostade();
                        Monostade m2 = new Monostade();
                        for (int i = 0; i < 10; i++)
                        {
                                m1.X = i;
                                Console.WriteLine("m1.X = {0}, m2.X = {1}", m1.X, m2.X);
                                Debug.Assert(m1.X == m2.X);       
                        }
                }
        }
}
