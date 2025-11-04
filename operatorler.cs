using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 5;
            double number2 = 9.99;
            bool mybool = false;
            Console.WriteLine(Convert.ToString(number));
            Console.WriteLine(Convert.ToDouble(number));
            Console.WriteLine(Convert.ToInt32(number2));
            Console.WriteLine(Convert.ToString(mybool));
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("What is your name?  ");
            string name = Console.ReadLine();
            Console.WriteLine("Name is:" + name);

            /*
            
            Console.Write("Enter your age");
            int age = Console.Readline();
            Console.WriteLine("Your age is:"+age);
            //syntax error çünkü readline int e çevrilemez. !!!!!
            */

            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is:" + age);

            //yanlış bir girdi alırsak system.FormatExpection hatası alırız.

            // OPERATÖRLER
            int x = 11+19;
            int sum1=1;
            int sum2 = sum1 + 1;
            int sum3 = sum2 + sum1;
            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            Console.WriteLine(sum3);

            //ATAMA

            Console.WriteLine(number += 2);
            Console.WriteLine(10 % number);
            Console.WriteLine(10++);
            Console.WriteLine(sum3--);
            
            Console.WriteLine(sum2<number);
            Console.WriteLine(sum3!=sum3);
            Console.WriteLine(sum3==number);




        }
    }
}
