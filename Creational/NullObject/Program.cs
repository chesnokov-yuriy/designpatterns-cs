using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NullObject
{
        class Program
        {
                static void Main(string[] args)
                {                        
                        EmployeeDatabase.AddEmployee("bob");
                        EmployeeDatabase.AddEmployee("marry");
                        IEmployee employee = EmployeeDatabase.GetEmployee("bob");
                        Console.WriteLine("bob = {0}", employee.Name);
                        employee.Pay();
                        employee = EmployeeDatabase.GetEmployee("marry");
                        Console.WriteLine("marry = {0}", employee.Name);
                        employee.Pay();
                        employee = EmployeeDatabase.GetEmployee("john");
                        Console.WriteLine("john = {0}", employee.Name);
                        employee.Pay();
                }
        }
}
