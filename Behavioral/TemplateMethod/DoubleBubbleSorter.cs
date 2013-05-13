using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethod
{
        class DoubleBubbleSorter : IBubbleSorter
        {
                public void Sort(double[] array)
                {
                        this.array = array;
                        Length = array.Length;
                        base.Sort();
                }

                protected override bool OutOfOrder(int index)
                {
                        return array[index] > array[index + 1];
                }

                protected override void Swap(int index)
                {
                        double temp = array[index];
                        array[index] = array[index + 1];
                        array[index + 1] = temp;
                }

                double[] array;
        }
}
