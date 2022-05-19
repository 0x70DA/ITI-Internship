using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            // IO test. 
            Console.Write("Enter Your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}. :)");

            // Formating output.
            Console.Write("Enter your salary: ");
            double salary = double.Parse(Console.ReadLine());
            Console.WriteLine($"Your salary is {salary:c}");
            // Print the contents of an array.
            int[] arr = { 1, 2, 3, 4 };
            Array.ForEach(arr, Console.WriteLine);
        }
    }
}
