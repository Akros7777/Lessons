using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            double c, s, a = 5, b = 7;
            s = (a * b) / 2;
            Console.WriteLine("площадь прямоугольного триугольника =" + s);
            //c = Math.Sqrt(Math.Pow(a,2) + Math.Pow(b,2)); 
            c = Math.Sqrt(a ^ 2) + Math.Pow(b, 2));
            Console.WriteLine("длина гепотинузы по теореме Пифагора=" + c);
            c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2) - 2 * a * b * Math.Cos(90 * Math.PI / 180));
            Console.WriteLine("длина гепотинузы по теореме косинусов=" + c);
            Console.ReadLine();
        }
    }
}
