using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13
{
    class Car
    {
        public string Name;

        protected string Engine_type;

        internal string Drive_unit_car;

        protected int Max_speed;

        protected internal int Quantite_placas;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car Car = new Car();
            Car.Name = "Mitsubishi";
            Car.Engine_type = "Electro";
            Car.Drive_unit_car = "Front";
            Car.Max_speed = 210;
            Car.Quantite_placas = 7;

            Console.WriteLine("Name - " + Car.Name + "; Engine type - " + Car.Engine_type + "; Drive unit car - " + Car.Drive_unit_car + "; Max speed - " + Car.Max_speed.ToString() + "km/h" + "; Quantite placas - " + Car.Quantite_placas.ToString());

            Console.ReadLine();
        }
    }
}