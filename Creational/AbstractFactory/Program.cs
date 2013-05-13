using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
        class Program
        {
                static void Main(string[] args)
                {
                        IEmployeeFactory factory = new FaltFileEmployeeFactory();
                        IEmployee employee = factory.CreateEmployee();

                        factory = new SqlEmployeeFactory();
                        employee = factory.CreateEmployee();
                }
        }
}
