using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program.ex1();
            //Program.ex2();
            Program.ex3();
            Console.ReadLine();
        }

        public static void ex1()
        {
            string S = "Arsenal, Oleg, Nikolay, Ivan, Nikolay, Ivan, Nikolay";
            Console.WriteLine(S.Replace("Nikolay", "Oleg"));
        }

        public static void ex2()
        {
            string s = "Сегодня мы свами рассмотрели, как работать со строками в Си-шарп. Были описаны основные операторы и методы, которые используются для работы со строками";
            Console.WriteLine(s.Remove(0, 66));
        }

        public static void ex3()
        {
            string SS = "Login1,LOgin2,login3,loGin4".ToLower();

            string[] us = SS.Split(',');
            for (int i = 0; i < us.Length; i++)
            {
                Console.WriteLine(us[i]);
            }
        }

    }
}
