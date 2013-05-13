using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
        class FaltFileEmployeeFactory : IEmployeeFactory
        {
                public IEmployee CreateEmployee()
                {
                        return new FlatFileEmployee();
                }
        }
}
