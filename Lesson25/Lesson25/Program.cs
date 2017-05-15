using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson25
{

    enum Units
    {
        USD = 1,
        RUR = 2
    }

    class Money
    {
        public double Amount { get; set; }
        public Units Unit { get; set; }
        public Money(double amount, Units unit)
        {
            Amount = amount;
            Unit = unit;
        }
        public static Money operator +(Money a, Money b)
        {
            if (a.Unit == b.Unit) 
            {
                return new Money(a.Amount + b.Amount, a.Unit);
            }

            double aValue = a.Unit == Units.USD ? a.Amount : (a.Amount / 28.5);
            double bValue = b.Unit == Units.USD ? b.Amount : (b.Amount / 28.5);
            return new Money(aValue + bValue, Units.USD);
        }
        public static bool operator ==(Money a, Money b)
        {
            return ((a.Unit == b.Unit) && (a.Amount.Equals(b.Amount)));
        }

        public static bool operator !=(Money a, Money b)
        {
            return !(a == b);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Money myMoney = new Money(255, Units.USD);
            Money yourMoney = new Money(2500, Units.USD);
            Money hisMoney = new Money(550, Units.USD);
            Money sum1 = myMoney + yourMoney;
            Console.WriteLine(sum1.Amount + " " + sum1.Unit);
            Money sum2 = yourMoney + hisMoney;
            Console.WriteLine(sum2.Amount + " " + sum2.Unit);

            Money doll1 = new Money(20, Units.USD);
            Money doll2 = new Money(10, Units.USD);

            Money temp = doll1 + doll2;
            Console.WriteLine("summ doll1 + doll2 = " + temp.Amount + " " + temp.Unit);

            Console.ReadKey();
        }
    }
}
