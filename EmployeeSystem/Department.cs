using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSystem
{
    internal class Department
    {
        public string departmentName;
        public Employee[] employeesDep;

        public override string ToString()
        {
            return departmentName;
        }
    }
}
