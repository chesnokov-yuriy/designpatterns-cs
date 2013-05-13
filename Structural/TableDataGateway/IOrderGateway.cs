using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TableDataGateway
{
        interface IOrderGateway
        {
                Order Find(int id);
                void Add(Order order);
        }
}
