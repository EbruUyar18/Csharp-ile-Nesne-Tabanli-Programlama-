using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Kapalı Dönüşüm(otomatik): küçük  bir türü dabah büyük bir tür boyutuna 
            çevirmedir(char -> int -> long -> float -> double)

            Açık Dönüşüm(manuel): büyük bir türü küçük bir daha küçük bir tür boyutuna
            çevirmedir(double -> float -> long -> int -> char)

            */

            // Kapalı Dönüşüm
            int myInt = 9;
            double myDouble = myInt;
            Console.WriteLine(myInt); // output 9
            Console.WriteLine(myDouble); //output 9

            //Açık Dönüşüm
            int num = 9.6D;
            int newNum = (int)num;
            Console.WriteLine(newNum); // output 9.6
            Console.WriteLine(num); //output 9

        }
    }
}
