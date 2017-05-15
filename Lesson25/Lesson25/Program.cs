using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson25
{
    class Money
    {
        public double Amount { get; set; }
        public string Unit { get; set; }
        public Money(double amount, string unit)
        {
            Amount = amount;
            Unit = unit;
        }
        public static Money operator +(Money a, Money b)
        {

            if (a.Unit.Contains("RUR") || b.Unit.Contains("USD"))
            {
                return new Money((a.Amount / 28.5) + b.Amount, "USD");
            }
            else if (a.Unit.Contains("USD") || b.Unit.Contains("RUR"))
            {
                return new Money(a.Amount + (b.Amount / 28.5), "USD");
            }
            else
            {
                return new Money(a.Amount + b.Amount, "USD");
            }
        }
        public static bool operator ==(Money a, Money b)
        {
            if (a.Unit == b.Unit)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public static bool operator !=(Money a, Money b)
        {
            if (a.Unit != b.Unit)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Money myMoney = new Money(255, "USD");
            Money yourMoney = new Money(2500, "RUR");
            Money hisMoney = new Money(550, "USD");
            Money sum1 = myMoney + yourMoney;
            Console.WriteLine(sum1.Amount + " " + sum1.Unit);
            Money sum2 = yourMoney + hisMoney;
            Console.WriteLine(sum2.Amount + " " + sum2.Unit);
            Console.ReadKey();
        }
    }
}
