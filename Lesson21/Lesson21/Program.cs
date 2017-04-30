using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson21
{
    abstract class Human
    {
        public string Name { get; set; }

        public Human (string name)
        {
            Name = name;
        }
        public abstract void sayHello();
    }

    class Ukrain : Human
    {
        public string Nation { get; set; }

        public Ukrain (string name, string nation): base (name)
        {
            Nation = nation;
        }

        public override void sayHello()
        {
            Console.WriteLine("{1} {0} говорит: Привiт!", Name, Nation);
        }
    }

    class Russian : Human
    {
        public string Nation { get; set; }
        public Russian(string name, string nation): base (name)
        {
            Nation = nation;
        }

        public override void sayHello()
        {
            Console.WriteLine("{1} {0} говорит: Привет!", Name, Nation);
        }
    }

    class American : Human
    {
        public string Nation { get; set; }
        public American(string name, string nation): base (name)
        {
            Nation = nation;
        }

        public override void sayHello()
        {
            Console.WriteLine("{1} {0} говорит: Hello!", Name, Nation);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ukrain ukrMan = new Ukrain("Иван", "Украинец");
            ukrMan.sayHello();
            Russian rusMan = new Russian("Антон", "Россиянин");
            rusMan.sayHello();
            American americMan = new American("Кирил", "Американец");
            americMan.sayHello();
            Console.ReadLine();
        }
    }
}
