using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("введите число");
            a = Convert.ToInt32(Console.ReadLine());

            bool check3 = a % 3 == 0;
            bool check7 = a % 7 == 0;

            Console.WriteLine((check3 ? "число кратное трём \n" : "") + (check7 ? "число кратное семи" : ""));
            Console.WriteLine((!check3 && !check7) ? "число не кратное трём \nчисло не кратно семи" : "");

            Console.ReadKey();
        }
    }
}
