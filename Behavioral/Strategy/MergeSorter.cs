using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
        class MergeSorter
        {
                public MergeSorter(ISortHandler sortHandler)
                {
                        this.sortHandler = sortHandler;
                }

                public void Sort(object array)
                {
                        this.sortHandler.SetArray(array);

                        if (this.sortHandler.Length() <= 1)
                                return;
                        
                        // another sorting algorythm
                }
                
                ISortHandler sortHandler;
        }
}
