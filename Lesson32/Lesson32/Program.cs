using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson32
{
    public struct Circle
    {
        public void AverageRad(double[] radius)
        {
            double summ = 0;
            double raznost = Int32.MaxValue;
            int position = 0;
            for (int i = 0; i < radius.Length; i++)
            {
                summ += radius[i];
            }
            double mid = summ / radius.Length;
            for (int i = 0; i < radius.Length; i++)
            {
                if (Math.Abs((radius[i] - mid)) < raznost)
                {
                    raznost = Math.Abs((radius[i] - mid));
                    position = i;
                }
            }
            Console.WriteLine("максимально близкий к среднему значению радиусов окружностей из списка " + position + " элемент массива");
        }
    } 
    class Program
    {
        static void Main(string[] args)
        {
            double[] radius = {16.12, 19.16, 12, 21.8};
            Circle Cir;
            Cir.AverageRad(radius);
            Console.ReadKey();
        }
    }
}
