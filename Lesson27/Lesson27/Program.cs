using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegulaR
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.ex1();
            //Program.ex2();
        }
        static void ex1()
        {
            Console.WriteLine("Введите логин от 2-х до 10-ти символов (допускаются буквы и цифры, цифра не может быть первой)");
            string stroka = Console.ReadLine();
            Regex login = new Regex(@"^\D[A-Za-z0-9]{1,9}$");
            while (!login.IsMatch(stroka))
            {
                Console.WriteLine("Ошибка, логин должен быть от 2-х до 10- символов и начинаться с буквы. Повторите ввод");
                stroka = Console.ReadLine();
            }
            Console.WriteLine("Логин {0} введен правильно", stroka);
            Console.ReadKey();
        }

        static void ex2()
        {
            string[] badWords = { "жопа", "срака", "пердак" };
            Regex shabMat;
            Console.WriteLine("Введите фразу в которой есть слова жопа срака или пердак");
            string fraza = Console.ReadLine();
            string zamena = "ЦЕНЗУРА";

            foreach (string rep in badWords)
            {
                shabMat = new Regex(@"\w*" + rep + @"\w*");
                fraza = shabMat.Replace(fraza, zamena);
            }
            Console.WriteLine(fraza);
            Console.ReadKey();
        }
    }
}
