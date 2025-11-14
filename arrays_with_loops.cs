using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i=0; i<=10; i=i+2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            for (int j=1; j<=2; ++j)
            {
                Console.WriteLine("out"+ j);

            }
            Console.WriteLine();
            for (int k=1; k<=3; k++)
            {
                Console.WriteLine("inner" + k);
            }
            int[] numList ={ 1,2,3,4,5,};
            Console.WriteLine();
            foreach (int num in numList)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();
            int x = 0;
            while (x<10)
            {
                Console.WriteLine(x);
                x++;
                if (x==4)
                {
                    break;
                }
                Console.WriteLine();
             int y = 0;
             while (y<10)
                {
                    if (y==4)
                    {
                        y++;
                        continue;
                    }
                    Console.WriteLine(y);
                    y++;
                }

            }
        }
    }
}
