using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson23
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> name = new List<string> { "Андрей", "Вася", "Иван", "Настя", "Лена" };
            PeopleList(name);
            PeopleList(name, 5);
            Console.ReadKey();
        }
        static void PeopleList(List<string> name)
        {
            string line = "";
            foreach (string name_list in name)
            {
                line += name_list + ", ";
            }
            Console.WriteLine(line);
        }
        static void PeopleList(List<string> name, int numbers)
        {
            string line = "";

            foreach (string name_list in name)
            {
                    line += name_list + numbers + ", ";
            }
            Console.WriteLine(line);
        }
    }
}
