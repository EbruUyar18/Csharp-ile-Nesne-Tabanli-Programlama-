using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void myMethod(string fname, int age)
        {
            Console.WriteLine(fname + " is " + age +" years old");
        }
        static void Main(string[] args)
        {
            myMethod("Ebru",20);
            myMethod("Ahmet", 30);
            myMethod("zeynep", 22);
        }
    }
}
