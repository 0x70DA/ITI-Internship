using System;

namespace ConsoleApp1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Foo(out x);
            //Bar(ref x);
            Console.WriteLine(x);
        }
        static void Foo(out int x)
        {
            // The variable doesn't have to be initialized
            x = 50;
        }
        static void Bar(ref int x)
        {
            // To use (ref), the variable must be initialized.
            // Gives compilation error.
            x = 60;
        }
    }
}
