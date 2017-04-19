using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program.ex1();
            //Program.ex2();
            Program.ex3();
        }
        static void ex1()
        {
            File.Delete("d:\\numbers.txt");
            FileStream numbers = new FileStream("d:\\numbers.txt", FileMode.CreateNew);
            StreamWriter writer = new StreamWriter(numbers);
            for (int i = 1; i <= 500; i++)
            {
                string tempString = i.ToString();
                writer.Write(tempString + (i == 500 ? "" : ", "));
            }
            writer.Close();
        }

        static void ex2()
        {
            List<string> list = new List<string>() { "red", "green", "black", "white", "blue" };
            File.Delete("d:\\list.txt");
            FileStream listFile = new FileStream("d:\\list.txt", FileMode.CreateNew);
            StreamWriter writer = new StreamWriter(listFile);
            foreach (string tempString in list)
            {
                writer.WriteLine(tempString);
            }
            writer.Close();
        }

        static void ex3()
        {
            FileStream listFile = new FileStream("d:\\list.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(listFile);
            string line = "";
            string biggestLine = line;
            int counter = 0;
            while ((line = reader.ReadLine()) != null)
            {
                if (line.Length > biggestLine.Length)
                {
                    biggestLine = line;
                }
            }
            Console.WriteLine(biggestLine);
            Console.ReadLine();
        }
    }
}
