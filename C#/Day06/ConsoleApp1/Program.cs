using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex(2, 3);
            Complex c2 = new Complex(4, 5);

            Console.WriteLine(c1 + c2);
            Console.WriteLine(c2 + 5);
            Console.WriteLine(++c1);
            Console.WriteLine(c2++);
            Console.WriteLine(c1.Magnitude);
            Console.WriteLine(c2.Magnitude);
            Console.WriteLine(c1 > c2);
            Console.WriteLine(c1 < c2);
        }
    }
}
