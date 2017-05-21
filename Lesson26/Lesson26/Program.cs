using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson26
{
    class Circle
    {
        public int Coordinates_X {get; set;}
        public int Coordinates_Y {get; set;}
        public int Radious {get; set;}

        public Circle (int X, int Y, int rad)
        {
            Coordinates_X = X;
            Coordinates_Y = Y;
            Radious = rad;
        }
        public bool Equals(Circle obj)
        {
            if (obj == null)
                return false;
            Circle c = obj as Circle;
            if (c as Circle == null)
                return false;

            return c.Coordinates_X == this.Coordinates_X && c.Coordinates_Y == this.Coordinates_Y && c.Radious == this.Radious;
        }
        public override int GetHashCode()
        {
            int unitCode;
            if (Radious >= 20)
                unitCode = 1;
            else unitCode = 2;
            return (int)unitCode;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(7, 8, 25);
            Circle c2 = new Circle(5, 4, 19);
            Circle c3 = new Circle(7, 8, 25);
            Circle c4 = new Circle(4, 4, 20);

            Console.WriteLine(c1.Equals(c3));
            Console.WriteLine(c2.Equals(c4));
            Console.WriteLine(c1.GetHashCode());
            Console.WriteLine(c2.GetHashCode());
            Console.WriteLine(c3.GetHashCode());
            Console.WriteLine(c4.GetHashCode());
            Console.ReadKey();
        }
    }
}
