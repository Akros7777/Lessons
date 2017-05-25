using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson29
{
    enum Food
    {
        fish = 35,
        mouse = 75,
        bird = 50,
    }
    class Cat
    {
        public int satiety_level { get; set; }
        public void Eat_Something(Food eat)
        {
            satiety_level = satiety_level + (int)eat;
            if (satiety_level < 50)
            {
                Console.WriteLine("кот все еще голоден");
            }
            else
            {
                Console.WriteLine("кот cыт");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cat myCat = new Cat();
            myCat.Eat_Something(Food.fish);
            myCat.Eat_Something(Food.mouse);
            Console.ReadKey();
        }
    }
}
