using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string txt = "abC";
            Console.WriteLine(txt.Length);
            Console.WriteLine(txt.ToLower());
            Console.WriteLine(txt.ToUpper());

            string a = "A";
            string b = "B";
            string c = string.Concat(a, b);
            Console.WriteLine(c);
            Console.WriteLine(a + b);
            Console.WriteLine(b + c);

            //string interpolasyonu
            string name = $"the name: {a}, {b}";
            Console.WriteLine(name);

            //dizeleri erişim
            Console.WriteLine(name[2]);
            Console.WriteLine(name[name.Length - 1]);
            Console.WriteLine(name.IndexOf("a"));

            int charPos = txt.IndexOf("C");
            Console.WriteLine(charPos);

            string info = "my name is \"EBRU\".";
            Console.WriteLine(info);

            string txt2 = "It\'s a beautiful day.";
            string t = "the character \\ is called backslash";
            /*
            \n : new line
            \t : tab
            \r : carriage return
            \b : backspace
             */


        }
    }
}
