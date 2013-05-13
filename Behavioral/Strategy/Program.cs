using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
        class Program
        {
                static void Main(string[] args)
                {
                        Random random = new Random();

                        int[] ints = new int[10];
                        for (int i = 0; i < ints.Length; i++)
                                ints[i] = random.Next(-100, 100);

                        ISortHandler intSorter = new IntSortHandler();

                        BubbleSorter bubbleSorter = new BubbleSorter(intSorter);
                        bubbleSorter.Sort(ints);

                        Console.WriteLine("bubble sorter on ints:");
                        for (int i = 0; i < ints.Length; i++)
                                Console.WriteLine(ints[i].ToString());
                }
        }
}
