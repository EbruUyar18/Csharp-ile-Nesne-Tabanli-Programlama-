using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            System.Linq ad alanı
            min, max gibi yararlı dizi yöntemleri bulunur. 
            */
            int[] myNum = { 1, 2, 3, 4, 5, };
            Console.WriteLine(myNum.Max());
            Console.WriteLine(myNum.Min());
            Console.WriteLine(myNum.Sum());
        }
    }
}
