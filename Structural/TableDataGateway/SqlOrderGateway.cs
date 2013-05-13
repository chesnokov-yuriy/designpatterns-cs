using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TableDataGateway
{
        class SqlOrderGateway : IOrderGateway
        {
                public SqlOrderGateway(string connectionString)
                {
                        this.connectionString = connectionString;
                }

                public Order Find(int id)
                {
                        Console.WriteLine("find '{0}' order from sql database", id);
                        return null;
                }

                public void Add(Order order)
                {
                        Console.WriteLine("add '{0}' order from sql database", order.Id);
                }

                string connectionString;
        }
}
