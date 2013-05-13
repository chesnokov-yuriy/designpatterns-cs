using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethod
{
        class Program
        {
                static void Main(string[] args)
                {
                        Random random = new Random();

                        int[] ints = new int[10];
                        for (int i = 0; i < ints.Length; i++)
                                ints[i] = random.Next(-100, 100);
                        
                        IntBubbleSorter intSorter = new IntBubbleSorter();
                        intSorter.Sort(ints);

                        Console.WriteLine("int bubble sorter:");
                        for (int i = 0; i < ints.Length; i++)
                                Console.WriteLine(ints[i].ToString());

                        double[] doubles = new double[10];
                        for (int i = 0; i < ints.Length; i++)
                                doubles[i] = random.NextDouble();

                        DoubleBubbleSorter doubleSorter = new DoubleBubbleSorter();
                        doubleSorter.Sort(doubles);

                        Console.WriteLine("double bubble sorter:");
                        for (int i = 0; i < doubles.Length; i++)
                                Console.WriteLine(doubles[i].ToString());
                }
        }
}
