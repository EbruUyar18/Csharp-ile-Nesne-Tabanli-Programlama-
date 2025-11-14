using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ARRAY
            //tek değişkende birden fazla değer depolamak için kullanılır.
            string[] cars = { "volvo", "BMW", "Audi" };
            int[] nyNum = { 10, 20, 30, 40, 50 };
            Console.WriteLine(cars[0]);
            cars[0] = "opel";
            Console.WriteLine(cars[0]);
            Console.WriteLine(cars.Length);

            string[] names = new string[] { "Ebru", "Elif", "Betül"} ;
            
            names = new string[] { "Ebru", "Elif", "Betül" };

            for (int i=0; i<names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            string[] surname = { "Uyar", "Giray", "Gürleyen" };
            Array.Sort(surname);
            foreach (string i in surname)
            {
                Console.WriteLine(i);
            }

            int[] myNum = { 5, 3, 2 };
            Array.Sort(nyNum);
            foreach (int i in myNum)
            {
                Console.WriteLine(i);
            }


        }
    }
}
