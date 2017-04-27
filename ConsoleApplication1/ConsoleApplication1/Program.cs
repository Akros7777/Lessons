using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Warrior
    {
        public double heaalth;
        public double armor;
        public double koefficientDamage;
        public Warrior(double h, double arm, double kdmg)
        {
            heaalth = h;
            armor = arm;
            koefficientDamage = kdmg;
        }
        public virtual void GetDamage(double dmg)
        {
            if (dmg > 0)
            {
                armor = armor - (dmg * koefficientDamage);
                heaalth = heaalth + armor;
            }
            else
                armor = armor * 1;
                heaalth = heaalth * 1;
            Console.WriteLine("жизней после нанесенного урона " + heaalth + " брони после нанесенного урона " + armor);
        }
    }

    class WarriorLight : Warrior
    {
        public WarriorLight (double h, double arm, double kdmg) : base(h,arm,kdmg)
        {
        }
        public override void GetDamage(double dmg)
        {
            if (dmg > 0)
            {
                armor = armor - (dmg * koefficientDamage);
                heaalth = heaalth + armor;
            }
            else
                armor = armor * 1;
                heaalth = heaalth * 1;
                Console.WriteLine("жизней после нанесенного урона " + heaalth + " брони после нанесенного урона " + armor);
        }
    }

    class WarriorHigh : Warrior
    {
        public WarriorHigh(double h, double arm, double kdmg) : base(h, arm, kdmg)
        {
        }
        public override void GetDamage(double dmg)
        {
            if (dmg > 0)
            {
                armor = armor - (dmg * koefficientDamage);
                heaalth = heaalth + armor;
            }
            else 
                armor = armor * 1;
                heaalth = heaalth * 1;
                Console.WriteLine("жизней после нанесенного урона " + heaalth + " брони после нанесенного урона " + armor);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double dmg = 150f;
            Warrior W = new Warrior(150f, 100f, 1f);
            Console.WriteLine("Воин в обычной броне: " + "жизней " + W.heaalth + ", брони " + W.armor);
            W.GetDamage(dmg);
            WarriorLight WL = new WarriorLight(100f, 30f, 1.5f);
            Console.WriteLine("Воин в легкой броне: " + "жизней - " + WL.heaalth + ", брони " + WL.armor);
            WL.GetDamage(dmg);
            WarriorHigh WH = new WarriorHigh(300f, 150f, 0.4f);
            Console.WriteLine("Воин в тяжелой броне: " + "жизней " + WH.heaalth + ", брони " + WH.armor);
            WH.GetDamage(dmg);
            Console.ReadLine();
        }
    }
}
