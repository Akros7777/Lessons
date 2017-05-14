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
        public Ukrain (string name): base (name)
        {}

        public override void sayHello()
        {
            Console.WriteLine(Name + " говорить: Привiт!");
        }
    }

    class Russian : Human
    {
        public Russian(string name): base (name)
        {}

        public override void sayHello()
        {
            Console.WriteLine(Name + " говорит: Привет!");
        }
    }

    class American : Human
    {
        public American(string name): base (name)
        {}

        public override void sayHello()
        {
            Console.WriteLine(Name + " say: Hello!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Human> humans = new List<Human>();
            humans.Add(new Ukrain("Iван"));
            humans.Add(new Russian("Антон"));
            humans.Add(new American("Maykl"));

            foreach (Human human in humans)
                human.sayHello();

            Console.ReadLine();
        }
    }
}
