using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NullObject
{
        static class EmployeeDatabase
        {
                static public void AddEmployee(string name)
                {
                        IEmployee employee = new Employee() { Name = name };
                        employees.Add(employee);
                }

                static public IEmployee GetEmployee(string name)
                {
                        IEmployee employee = employees.FirstOrDefault(e => e.Name == name);
                        if (employee != null)
                                return employee;
                        else
                                return new NullEmployee();                        
                }

                static IList<IEmployee> employees = new List<IEmployee>();
        }
}
