using System;

namespace EmployeeSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department[] deparments = new Department[0];
            Employee[] employees = new Employee[0];

        l3:
            Console.WriteLine("Adding employee -> 1 || Adding department -> 2");
            bool success = int.TryParse(Console.ReadLine(), out int menuNumber);

            if (success && menuNumber == 1)
            {
                if (deparments.Length == 0)
                {
                l1:
                    Console.WriteLine("There are no any departments, please add a department.");

                    Department department = new Department();
                    Console.Write("Department name: ");
                    department.departmentName = Console.ReadLine();
                    Array.Resize(ref deparments, deparments.Length + 1);
                    deparments[deparments.Length - 1] = department;

                    Console.WriteLine("Now, you can add employee...");

                    Employee employee = new Employee();

                    Console.Write("Employee name: ");
                    employee.fullName = Console.ReadLine();

                    Console.Write("Position: ");
                    employee.position = Console.ReadLine();

                    Console.Write("Salary amount: ");
                    string value = Console.ReadLine();
                    employee.salary = Convert.ToDouble(value);

                    Array.Resize(ref employees, employees.Length + 1);
                    employees[employees.Length - 1] = employee;

                    Console.WriteLine("Do you want to add new employee? If yes, please click <5>");
                    bool successnNew = int.TryParse(Console.ReadLine(), out int menuNumberNew);
                    if (successnNew && menuNumberNew == 5)
                    {
                        goto l1;
                    }

                    foreach (Employee item in employees)
                    {
                        Console.WriteLine("***************5");
                        Console.WriteLine(item);
                    }
                }
                else
                {
                    Console.WriteLine("**** List of departments ****");
                    foreach (Department item in deparments)
                    {
                        Console.WriteLine(item);
                    }
                }
                Console.WriteLine("_____________");
                l4:
                
                Department choosenDepartament = new Department();
                l7:
                Console.Write("Enter the Departament Name: ");
                choosenDepartament.departmentName = Console.ReadLine();
                for (int i = 0; i < deparments.Length; i++)
                {
                    if (choosenDepartament.departmentName != deparments[i].departmentName)
                    {
                        Console.WriteLine("Please, write the correct department name");
                        goto l4;
                    }
                    else
                    {
                        break;
                    }
                }
                l8:
                Employee newEmployee = new Employee();
                Console.Write("FullName: ");
                newEmployee.fullName = Console.ReadLine();

                Console.Write("Position: ");
                newEmployee.position = Console.ReadLine();

                Console.Write("Salary amount: ");
                string newValue = Console.ReadLine();
                newEmployee.salary = Convert.ToDouble(newValue);

                 choosenDepartament.employeesDep=employees;

                Array.Resize(ref employees, employees.Length + 1);
                employees[employees.Length - 1] = newEmployee;

                Console.Write("Do You Want add new Student, If Yes, click ==>5 / If you want change Department Name click ==>9 / No,Click ==> Any Pres Key");
                bool successDep1 = int.TryParse(Console.ReadLine(), out int menuNumberDep1);
                

                if (successDep1 && menuNumberDep1 == 5)
                {
                    goto l8;
                }
                else if (successDep1 && menuNumberDep1 == 9)
                {
                    goto l7;
                }


                Console.WriteLine("************");
                foreach (var item in employees)
                {
                    Console.WriteLine(item);
                }
                

            }
            else if (success && menuNumber == 2)
            {
            l2:
                Department department = new Department();

                Console.Write("Department name: ");
                department.departmentName = Console.ReadLine();

                Array.Resize(ref deparments, deparments.Length + 1);
                deparments[deparments.Length - 1] = department;

                Console.WriteLine("Department is created, if you want to add new department, click <5>");
                bool successDep = int.TryParse(Console.ReadLine(), out int menuNumberDep);

                if (successDep && menuNumberDep == 5)
                {
                    goto l2;
                }
                goto l3;
            }
        }
    }
}
