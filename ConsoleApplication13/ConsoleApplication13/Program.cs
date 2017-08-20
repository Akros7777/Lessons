using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{

    
    class Employee
    {

        public int age;

        public string name;

        public string surname;

        public string sex;

        public double salary;

    }
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> newEmployee = new List<Employee>()
            {
                new Employee {name = "Igor", surname = "Perk", sex = "male", age = 28, salary = 2000.88},
                new Employee {name = "Anton", surname = "Kirpa", sex = "male", age = 48, salary = 2557.14},
                new Employee {name = "Inga", surname = "Kata", sex = "female", age = 39, salary = 3088.88}
            };


            List<Employee> listMans = new List<Employee>()
            {
                new Employee {name = "Ivan", surname = "Perkin", sex = "male", age = 20, salary = 2500.88},
                new Employee {name = "Ruslan", surname = "Krinko", sex = "male", age = 50, salary = 2777.14},
                new Employee {name = "Irina", surname = "Kahuta", sex = "female", age = 32, salary = 3588.88},
            };

            newEmployee.AddRange(listMans);
            List<Employee> result = Program.SortList(newEmployee);

            List<Employee> resultListMans = Program.SortList(listMans);
        

            Program.PrintEmloyeeList(result);
            Program.PrintEmloyeeList(resultListMans);
            Program.PrintEmloyeeList(listMans);
            Console.ReadLine();
        }

        static List<Employee> SortList(List<Employee> rawList)
        {
            var result = from employee in rawList
                         orderby employee.age descending
                         select employee;
            return result.ToList();
        }

        static void PrintEmloyeeList(List<Employee> list)
        {
            foreach (Employee tempEmployee in list)
            {
                Console.WriteLine("Name " + tempEmployee.name + " Surname " + tempEmployee.surname + " Sex " + tempEmployee.sex + " Age " + tempEmployee.age + " Salary " + tempEmployee.salary + "$$");
            }
            Console.WriteLine("");
        }
    }

}