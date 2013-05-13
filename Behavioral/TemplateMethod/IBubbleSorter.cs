using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethod
{
        abstract class IBubbleSorter
        {
                protected int Length { get; set; }

                protected void Sort()
                {
                        if (Length <= 1)
                                return;
                        for (int nextToLast = Length - 2; nextToLast >= 0; nextToLast--)
                        {
                                for (int index = 0; index <= nextToLast; index++)
                                {
                                        if (OutOfOrder(index))
                                                Swap(index);                                        
                                }
                        }
                }

                protected abstract bool OutOfOrder(int index);
                protected abstract void Swap(int index);                
        }
}
