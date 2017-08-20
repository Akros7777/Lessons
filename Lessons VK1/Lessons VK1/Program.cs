using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_VK1
{
    class Human
    {
        public string Name { get; set; }
        public int Growth { get; set; }
        public int Weight { get; set; }
        public string Sex { get; set; }
        public string Profession { get; set; }
        public Human(string name, int growth, int weight, string sex, string profession)
        {
            Name = name;
            Growth = growth;
            Weight = weight;
            Sex = sex;
            Profession = profession;
        }
        public virtual void Movement()
        {
            Console.WriteLine(Name + " (пол- " + Sex + ", рост- " + Growth + "см" + ", вес- " + Weight + "кг)" + " начал передвижение");
        }
    }
    class Runner : Human
    {
        public Runner (string name, int growth, int weight, string sex, string profession) : base (name, growth, weight, sex, profession)
        {}
        public override void Movement()
        {
            Console.WriteLine(Profession + " " + Name + " (пол- " + Sex + ", рост- " + Growth + "см" + ", вес- " + Weight + "кг)" + " начал бежать");
        }
    }
    class Cyclist : Human
    {
        public Cyclist(string name, int growth, int weight, string sex, string profession) : base (name, growth, weight, sex, profession)
        {}
        public override void Movement()
        {
            Console.WriteLine(Profession + " " + Name + " (пол- " + Sex + ", рост- " + Growth + "см" + ", вес- " + Weight + "кг)" + " начал ехать");
        }
    }
    class Swimmer : Human
    {
        public Swimmer(string name, int growth, int weight, string sex, string profession) : base(name, growth, weight, sex, profession)
        { }
        public override void Movement()
        {
            Console.WriteLine(Profession + " " + Name + " (пол- " + Sex + ", рост- " + Growth + "см" + ", вес- " + Weight + "кг)" + " начал плыть");
        }
    }
    class Jumper : Human
    {
        public int HeightJump { get; set; }
        public int DistanceJump { get; set; }
        public Jumper(string name, int growth, int weight, string sex, string profession, int heightJump, int distanceJump) : base(name, growth, weight, sex, profession)
        {
            HeightJump = heightJump;
            DistanceJump = distanceJump;
        }
        public override void Movement()
        {
            Console.WriteLine(Profession + " " + Name + " (пол- " + Sex + ", рост- " + Growth + "см" + ", вес- " + Weight + "кг)" + " начал прыгать " + "(высота прыжка- " + HeightJump + "м" + ", расстояние- " + DistanceJump + "м" + ")");
        }
    }
    class Animal
    {
        public string Kind { get; set; }
        public int Speed { get; set; }
        public Animal(string kind, int speed)
        {
            Kind = kind;
            Speed = speed;
        }
        public virtual void Movement()
        {
            Console.WriteLine();
        }
    }
    class Dog : Animal
    {
        public Dog(string kind, int speed) : base(kind, speed)
        {
            Kind = kind;
            Speed = speed;
        }
        public override void Movement()
        {
            Console.WriteLine(Kind + " бежит со скоростью " + Speed + " км/ч");
        }
    }
    class Parrot : Animal
    {
        public Parrot(string kind, int speed) : base(kind, speed)
        {
            Kind = kind;
            Speed = speed;
        }
        public override void Movement()
        {
            Console.WriteLine(Kind + " летит со скоростью " + Speed + " км/ч");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Object> humAnm = new List<Object>();
            humAnm.Add(new Human("Василий", 189, 88, "мужской", ""));
            humAnm.Add(new Runner("Андрей", 165, 58, "мужской", "Бегун"));
            humAnm.Add(new Cyclist("Кирил", 177, 71, "мужской", "Велосипедист"));
            humAnm.Add(new Dog("Рекс", 44));
            humAnm.Add(new Parrot("Кеша", 99));
            humAnm.Add(new Swimmer("Иван", 205, 102, "мужской", "Пловец"));
            humAnm.Add(new Jumper("Руслан", 205, 102, "мужской", "Прыгун", 1, 3));
            humAnm.Reverse();

            foreach (Object ha in humAnm)
            {
                Type haType = ha.GetType();
                if (haType.IsSubclassOf(typeof(Human)) || haType.IsAssignableFrom(typeof(Human)))
                {
                    Human helpHuman = ha as Human;
                    Console.WriteLine(helpHuman.Name);
                }
                else if (haType.IsSubclassOf(typeof(Animal)) || haType.IsAssignableFrom(typeof(Animal)))
                {
                    Animal helpAnimal = ha as Animal;
                    Console.WriteLine(helpAnimal.Kind);
                }
            }
            Console.ReadKey();
        }
    }
}
