using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSystem
{
    internal class Employee
    {
        public int id;
        public string fullName;
        public string position;
        public double salary;
        public static int counter = 1000;


        //public Employee()
        //{
        //    counter++;

        //    string letters = "";
        //    for (int i = 0; i < 2; i++)
        //    {
        //        letters = letters + departmentName[i];
        //    }
        //    id = letters + counter;
        //}

        public Employee()
        {
            
            counter++;
            //this.departmentName = depName;
            //this.id = depName[0].ToString().ToUpper() + depName[1].ToString().ToUpper() + counter.ToString();
            id = counter;
        }

        //public string GetInfo()
        //{
        //    string output = $"No: {id}\n" +
        //        $"Full name: {fullName}\n" +
        //        $"Position:  {position} \n" +
        //        $"Salary: {salary} \n" +
        //        $"Department: {departmentName}";
        //    return output;
        //}

        public override string ToString()
        {
            return $"No: {id}\n" +
                $"Full name: {fullName}\n" +
                $"Position:  {position} \n" +
                $"Salary: {salary} \n";
        }
    }
}
