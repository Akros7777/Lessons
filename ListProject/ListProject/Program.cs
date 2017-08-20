using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListProject
{

    class Program
    {
        static void Main(string[] args)
        {
            MyList stringList = new MyList();
            for(int i = 0; i<10; i++)
            {
                string tempString = "My string " + i;
                stringList.addObject(tempString);
            }
            Iterator tempIterator = stringList.newIterator();
            for (int i = 0; i < 10; i++)
            {
                Object temp = tempIterator.next();
                string helpString = temp as string;
                Console.WriteLine(helpString);
            }
            
            Object obj = stringList.objectAtIndex(3);
            string objString = obj as string;
            Console.WriteLine(objString);

            Console.ReadKey();
        }
    }
}
