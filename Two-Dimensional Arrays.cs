using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //İki Boyutlu Dizi
            int[,] number = { { 1, 2, 3 }, { 3, 4, 8 } };
            // int[,,] üç boyutlu dizi
            Console.WriteLine(number[1, 1]);
            number[0, 0] = 17;
            Console.WriteLine(number[0, 0]);

            foreach (int i in number)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < number.GetLength(0); i++)
            {
                for (int j = 0; j < number.GetLength(1); j++)
                {
                    Console.WriteLine(number[i,j]);
                   
                }
            }

        }
    }
}
