using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program.ex1();
            Program.Numbers1();
            Console.ReadKey();
        }
        static void ex1()
        {
            int[] numbers = { 5, 7, 9, 21, 23, 35, 39, 42, 49, 55, 68, 78, 99 };
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = -1 * numbers[i];
                Console.WriteLine(numbers[i]);
            }
        }

        static int GetMin(int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }

            }
            return min;
        }

        public static void Numbers1()
        {
            int[] numbers1 = { 7, 2, 88, 14 };
            int min;
            min = GetMin(numbers1);
            Console.WriteLine(GetMin(numbers1));
        }
    }
}
