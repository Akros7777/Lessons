using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Warrior
    {
        private int _heaalth;
        private int _armor;
        public int heaalth
        {
            get { return _heaalth; }
            set { _heaalth = (value < 0) ? 0 : value; }
        }
        public int armor
        {
            get { return _armor; }
            set { _armor = (value < 0) ? 0 : value; }
        }
        public Warrior(int h, int arm)
        {
            heaalth = h;
            armor = arm;
        }
        public virtual void GetDamage(int damage)
        {
            if (damage >= 0)
            {
                int totalDamage = this.CalculateTotalDamage(damage);
                heaalth = heaalth - ((totalDamage - armor) < 0 ? 0 : (totalDamage - armor));
                armor = (armor - totalDamage) < 0 ? 0 : (armor - totalDamage);
                Console.WriteLine("Наносимый урон воину - " + damage + "\nЖизней после нанесенного урона " + heaalth + ", \nБрони после нанесенного урона " + armor + "\n");
            }
        }

        public void PrintWarrior()
        {
            Console.WriteLine("Воин: " + this.GetType().Name + " жизней " + this.heaalth + ", брони " + this.armor);
        }

        public virtual int CalculateTotalDamage(int damage)
        {
            return damage;
        }

    }

    class WarriorLight : Warrior
    {
        public WarriorLight (int h, int arm) : base(h,arm) {}

        public override int CalculateTotalDamage(int damage)
        {
            return damage * 2;
        }
    }

    class WarriorHigh : Warrior
    {
        public WarriorHigh(int h, int arm) : base(h, arm) {}
 
        public override int CalculateTotalDamage(int damage)
        {
            return damage / 2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int dmg = 150;
            Warrior warrior = new Warrior(150, 100);
            WarriorLight warriorLight = new WarriorLight(150, 100);
            WarriorHigh warriorHigh = new WarriorHigh(150, 100);

            List < Warrior > warriorsList = new List<Warrior> { warrior, warriorLight, warriorHigh };
            warriorsList.ForEach((war) =>
            {
                war.PrintWarrior();
                war.GetDamage(dmg);
            });

            Console.ReadLine();
        }
    }
}
