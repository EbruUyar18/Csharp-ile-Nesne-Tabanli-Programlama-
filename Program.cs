using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir sayı gir: ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        if (sayi % 2 == 0)
        {
            Console.WriteLine($"{sayi} çift bir sayıdır.");
        }
        else
        {
            Console.WriteLine($"{sayi} tek bir sayıdır.");
        }
    }
}
