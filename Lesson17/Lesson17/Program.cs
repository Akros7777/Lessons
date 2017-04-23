using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17
{
    class Geometricfigure
    {
        public int coordinatesX;
        public int coordinatesY;
        public int coordinatesZ;
        public Geometricfigure(int X, int Y)
        {
            this.coordinatesX = X;
            this.coordinatesY = Y;
        }
    }
    class Triangle : Geometricfigure
    {
        public int Perimeter;
        public Triangle(int X, int Y, int perimeter) : base(X, Y)
        {
            this.Perimeter = perimeter;
        }

        public void DrawTriangle()
        {
            Console.WriteLine("Рисуем треугольник");
        }
    }

        class Circle : Geometricfigure
        {
            public int Radius;
            public Circle(int X, int Y, int radius) : base(X, Y)
            {
                this.Radius = radius;
            }
            public void DrawCircle()
            {
                Console.WriteLine("Рисуем круг");
            }
        }

    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle1 = new Triangle(5, 8, 24);
            triangle1.DrawTriangle();
            Circle circle1 = new Circle(5, 7, 64);
            circle1.DrawCircle();
            Console.ReadKey();
        }
    }
}
