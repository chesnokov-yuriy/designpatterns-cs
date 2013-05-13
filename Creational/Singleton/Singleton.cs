using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
        class Singleton
        {
                private Singleton() { }

                public static Singleton Instance
                {
                        get
                        {
                                if (instance == null)
                                        instance = new Singleton();
                                return instance;
                        }
                }

                private static Singleton instance;
        }
}
