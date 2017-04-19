using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("забито голов хозяевами");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("забито голов гостями");
            b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
                Console.WriteLine("победили хозяева");
            else if (a < b)
                Console.WriteLine("победили гости");
            else
                Console.WriteLine("ничья");
            Console.ReadKey();
        }
    }
}
