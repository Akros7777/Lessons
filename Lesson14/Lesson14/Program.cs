using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14
{
    class TVset
    {
        private int Channel = 1, MaxChannel = 100;

        public void UpChannel()
        {
            if (Channel >= MaxChannel)
            {
                Channel = 1;
            }
            else
            {
                Channel++;
            }
        }
        public void DownChannel()
        {
            if (Channel <= 1)
            {
                Channel = MaxChannel;
            }
            else
            {
                Channel--;
            }
        }
        public void SetChannel(int i)
        {
            if (i < 1 || i > 100)
            {
                Channel = 100;
            }
            else
            {
                Channel = i;
            }
        }
        public int GetChannel()
        {
            return Channel;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TVset TV = new TVset();
            Console.WriteLine("Кнопка управления:\r\n 1 +1 канал;\r\n 2 -1канал; \r\n 3 ручной выбор канала; \r\n 4 выключение телевизора\r\n");
            while (true)
            {
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        TV.UpChannel();
                        break;
                    case 2:
                        TV.DownChannel();
                        break;
                    case 3:
                        TV.SetChannel(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case 4:
                        return;
                        break;
                    default:
                        break;
                }
                Console.Clear();
                Console.WriteLine(TV.GetChannel());
            }
        }
    }
}