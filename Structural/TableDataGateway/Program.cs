using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TableDataGateway
{
        class Program
        {
                static void Main(string[] args)
                {
                        Order order = new Order() { Id = 1, Name = "flowers", Price = 100 };

                        IOrderGateway db = new SqlOrderGateway("connection string");
                        db.Add(order);
                        order = db.Find(1);                        
                }
        }
}
