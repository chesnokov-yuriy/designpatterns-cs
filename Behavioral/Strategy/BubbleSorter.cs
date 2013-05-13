using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
        class BubbleSorter
        {
                public BubbleSorter(ISortHandler sortHandler)
                {
                        this.sortHandler = sortHandler;
                }

                public void Sort(object array)
                {
                        this.sortHandler.SetArray(array);

                        if (this.sortHandler.Length() <= 1)
                                return;
                        for (int nextToLast = this.sortHandler.Length() - 2; nextToLast >= 0; nextToLast--)
                        {
                                for (int index = 0; index <= nextToLast; index++)
                                {
                                        if (this.sortHandler.OutOfOrder(index))
                                                this.sortHandler.Swap(index);
                                }
                        }
                }
                
                ISortHandler sortHandler;
        }
}
