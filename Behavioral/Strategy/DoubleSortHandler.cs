using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
        class DoubleSortHandler : ISortHandler
        {
                public void SetArray(object array)
                {
                        this.array = (double[])array;
                }

                public int Length()
                {
                        return array.Length;
                }

                public bool OutOfOrder(int index)
                {
                        return (array[index] > array[index + 1]);
                }

                public void Swap(int index)
                {
                        double temp = array[index];
                        array[index] = array[index + 1];
                        array[index + 1] = temp;
                }

                private double[] array = null;
        }
}
