using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlyWeight
{
        class FlyweightFactory
        {                
                public IFlyweight this[char index]
                {
                        get
                        {
                                if (!this.flyweights.ContainsKey(index))
                                        this.flyweights[index] = new Character(index);
                                return this.flyweights[index];
                        }
                }

                IDictionary<char, IFlyweight> flyweights = new SortedDictionary<char, IFlyweight>();
        }
}
