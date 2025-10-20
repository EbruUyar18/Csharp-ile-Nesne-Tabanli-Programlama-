using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("I am learning C#");
            Console.WriteLine("I am so excited");
            Console.WriteLine("18+2");
            const int = 6;
            //int =7; dersek syntax error verir cünkü const sabit demektir.
            Console.WriteLine(int);
            //Değer atamadan önce değişken tanımlanamaz.

            string Name = "ebru";
            Console.WriteLine("My name is " + Name);

            string firstName = "Ebru";
            string surNAme = "UYAR";
            string Fullname = firstName + "" + surNAme;
            Console.WriteLine(Fullname);




        }
    }
}
