using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson22
{
    interface ISwitchable
    {
        void switchON();
        void switchOFF();
    }
    class TV : ISwitchable
    {
        public void switchON()
        {
            Console.WriteLine("Включить TV!");
        }
        public void switchOFF()
        {
            Console.WriteLine("Выключить TV!");
        }
    }
    class PC : ISwitchable
    {
        public void switchON()
        {
            Console.WriteLine("Включить PC!");
        }
        public void switchOFF()
        {
            Console.WriteLine("Выключить PC!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List <ISwitchable> swit = new List<ISwitchable>();
            swit.Add(new TV());
            swit.Add(new PC());

            foreach (ISwitchable s in swit)
            {
                s.switchON();
                s.switchOFF();
            }
            Console.ReadKey();
        }
    }
}
