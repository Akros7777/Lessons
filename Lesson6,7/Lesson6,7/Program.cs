using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program.ex1();
            //Program.ex2();
            //Program.ex3();
            Program.ex4();

            Console.ReadKey();
        }


        static void ex1()
        {
            int sum = 1;
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(sum);
                sum += 3;
            }
            Console.ReadLine();
        }

        static void ex2()
        {
            string password = "";
            do
            {
                Console.WriteLine("ВВедите пароль");
                password = Console.ReadLine();
            } while (password != "root");
            Console.WriteLine("Пароль верный");
        }

        static void ex3()
        {
            int[] numbers1 = { 3, 5, 7, 9, 11, 13, 15, 17, 19, 21 };

            int[] numbers2 = { 4, 8, 12, 16, 20, 24, 28, 32, 36, 40 };

            int[] numbersSum = new int[10];

            for (int i = 0; i < 10; i++)
            {
                numbersSum[i] = numbers1[i] + numbers2[i];
                Console.WriteLine(numbersSum[i]);
            }
        }

        static void ex4()
        {

            int[] numbers = { 3, 5, 8, 15, 58, 815, 15, 22, 48, 17, 35, 23, 41, 40, 98, 12 };

            foreach (int num in numbers)
            {
                if (num > 20 && num < 50)
                {
                    Console.WriteLine(num);
                }
            }

        }
    }
}
