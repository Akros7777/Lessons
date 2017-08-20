using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace caesar.c
{
    class Program
    {
        static void Main(string[] args)
        {
            byte code = 0;
            do
            {
                Console.WriteLine("Введите код \n");
                code = Convert.ToByte(Console.ReadLine());
            }
            while (code <= 0);
            Text(code);
            Console.ReadKey();
        }

        static void Text (int c)
        {
            string text = null;
            Regex myReg = new Regex(@"^[а-яА-Я ]+$");
            do
            {
                Console.WriteLine("Введите текст:");
                text = Convert.ToString(Console.ReadLine());
            }
            while (!myReg.IsMatch(text));
            Encoding encoding = Encoding.GetEncoding("windows-1251");
            byte[] bytes = encoding.GetBytes(text);
            for (int i = 0; i < text.Length; ++i)
            {
                int val = bytes[i];
                val = val + c;
                if (val > 255)
                {
                    val = (val - 255) + 192;
                    Console.Write("{0}", val);
                }
                else
                Console.Write("{0}", val);
            }
        }
    }
}
