using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Imy = new List<string>();
            Imy.Add("Андрей");
            Imy.Add("Иван");
            Imy.Add("Вася");
            Imy.Add("Петя");
            Imy.Add("Настя");
            Imy.Add("Лена");
            Imy_to_string_proc(Imy);
            Imy_to_string_proc(Imy, ",");
            Imy_to_string_proc(Imy, 9);
            Console.ReadKey();
        }
        public static void Imy_to_string_proc(List<string> imy, int separator)
        {
            string stroka = "";
            foreach (string imy_item in imy)
            { stroka = stroka + imy_item + separator; }
            Console.WriteLine(stroka);
        }
        public static void Imy_to_string_proc(List<string> imy, string separator)
        {
            string stroka = "";
            foreach (string imy_item in imy)
            { stroka = stroka + imy_item + separator; }
            Console.WriteLine(stroka);
        }
        public static void Imy_to_string_proc(List<string> imy)
        {
            string stroka = "";
            foreach (string imy_item in imy)
            { stroka = stroka + imy_item + "[]"; }
            Console.WriteLine(stroka);
        }
    }
}
