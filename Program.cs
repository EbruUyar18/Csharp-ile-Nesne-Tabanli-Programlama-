using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //boolean
            int x = 5;
            int y = 22;
            Console.WriteLine(x > y);
            Console.WriteLine(x < y);
            Console.WriteLine(3 < 5);

            Console.WriteLine(x == 10);
            Console.WriteLine(y != 22);
            if (x < y) 
            { 
                Console.WriteLine("x is less than y"); 
            }
            

            if (20 > 18) 
            {
                Console.WriteLine("20 is greater than 18");
            }

            if (x + y == 27) 
            {
                Console.WriteLine("true");
            }
            else if (x + y != 8)
            {
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine("error");
            }
            // veriable=(condition)?true:false;
            int time = 20;
            string result = (time < 18) ? "Good day" : "Good evening";
            Console.WriteLine(result);

        }
    }
}
