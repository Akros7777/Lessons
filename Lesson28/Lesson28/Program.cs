using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson28
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime[] date = new DateTime[5];
            date[0] = new DateTime(2017, 6, 30, 9, 31, 0);
            date[1] = new DateTime(2017, 6, 30, 10, 31, 0);
            date[2] = new DateTime(2017, 6, 30, 11, 31, 0);
            date[3] = new DateTime(2017, 6, 30, 12, 31, 0);
            date[4] = new DateTime(2017, 6, 30, 13, 31, 0);

            double[] temps = new double[5] { 26.3, 27.1, 30.0, 24.7, 25.0 };

            string output;
            for (int i = 0; i < 5; i++)
            {
                output = String.Format("{0:MMM dd(dddd) hh:mm > }" + temps[i] + "°C", date[i]);
                Console.WriteLine(output);
            }
            Console.ReadLine();
        }
    }
}
