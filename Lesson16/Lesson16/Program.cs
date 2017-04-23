using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16
{
    class TV
    {
        private int vol;
        public int Vol
        {
            get             
            {
                return vol;
            }
            set             
            {
                if (value > 100) vol = 100;
                else if (value < 0) vol = 0;
                else vol = value;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            TV myTV = new TV();
            Console.WriteLine("Кнопки управление телевизором: \r\n   1 уменьшение громкости \r\n   2 увеличение громкости \r\n   3 ручной ввод уровня громкости \r\n4   выключение телевизора");
            while (true)   
            {
                switch (Convert.ToInt16(Console.ReadLine()))
                {
                    case 1:
                        {
                            myTV.Vol = myTV.Vol - 1;
                            break;
                        }
                    case 2:
                        {
                            myTV.Vol = myTV.Vol + 1;
                            break;
                        }
                    case 3:
                        {
                            myTV.Vol = Convert.ToInt16(Console.ReadLine());
                            break;
                        }
                    case 4:
                        {
                            return;
                            break;
                        }
                    default:
                        {

                            break;
                        }
                }
                Console.Clear();
                Console.WriteLine(myTV.Vol);
            }
        }
    }
}