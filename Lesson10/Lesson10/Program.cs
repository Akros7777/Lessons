using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = "";
            string Number = "";
            Console.WriteLine("Введите порядковые номера (числа) элементов массива");
            int[] numbers = { 88, 11, 27, 14, 98, 75, 68, 235, 27, 84 };
            try
            {
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                int numbersSum = numbers[a] + numbers[b];
                Number = "Вы ввели номера элементов массива " + a + " и " + b;
                Console.WriteLine(Number);
                Console.WriteLine("сумма = " + numbersSum);
            }
            catch (FormatException)
            {
                result = "Вы ввели не число";
                Console.WriteLine(result);
            }
            catch (IndexOutOfRangeException)
            {
                result = "элемент вне рамок массива";
                Console.WriteLine(result);
            }
            Console.ReadLine();
        }
    }
}
