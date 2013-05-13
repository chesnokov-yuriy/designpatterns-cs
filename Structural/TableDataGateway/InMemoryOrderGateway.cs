using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TableDataGateway
{
        class InMemoryOrderGateway : IOrderGateway
        {                 
                public Order Find(int id)
                {
                        Console.WriteLine("find '{0}' order from in-mem database", id);
                        return this.orders.FirstOrDefault(o => o.Id == id);
                }

                public void Add(Order order)
                {
                        Console.WriteLine("add '{0}' order to in-mem database", order.Id);
                        this.orders.Add(order);
                }

                IList<Order> orders = new List<Order>();
        }
}
