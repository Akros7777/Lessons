using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson31
{
    class Human
    {
        public string Name { get; set; }
        public int? Children { get; set; }

        public Human(string name, int? children)
        {
            Name = name;
            Children = children;
        }


        public void InfOfChildren()
        {
            String childInfo = (Children == null) ? "неизвестно cколько детей" : (Children == 0 ? "нет детей" : Children + " детей");
            Console.WriteLine("У персоны " + Name + childInfo);
            Console.ReadKey();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Human tempHuman = new Human("Анатолий", null);

            tempHuman.InfOfChildren();

        }
    }
}
