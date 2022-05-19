using System;

namespace lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1- Prompt user for an array of integers of 5 numbers and output the max and min values in the array.
            int[] arr = new int[5];
            Console.WriteLine("Enter 5 numbers>> ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            // Sort the array in ascending order.
            //Array.Sort(arr);
            //Console.WriteLine($"The max value is: {arr[arr.Length - 1]}");
            //Console.WriteLine($"The min value is: {arr[0]}");
            // Another method.
            int maxIndex = 0;
            int minIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > arr[maxIndex])
                {
                    maxIndex = i;
                }
                if (arr[i] < arr[minIndex])
                {
                    minIndex = i;
                }
            }
            Console.WriteLine($"The max value is: {arr[maxIndex]}");
            Console.WriteLine($"The min value is: {arr[minIndex]}");
            Console.WriteLine();

            // 2- Keep accepting input from user untill the sum of input numbers excceds 100 or the user enters 0.
            int sum = 0;
            while (true)
            {
                Console.WriteLine("Enter a number>> ");
                int num = Convert.ToInt32(Console.ReadLine());
                sum += num;
                if (sum > 100 || num == 0)
                {
                    Console.WriteLine($"The sum is: {sum}");
                    break;
                }
            }

            // 3- Prompt the user for a string of two words and swap the two words.
            Console.WriteLine("Enter a string of two words: ");
            string word = Console.ReadLine().Trim();
            string[] wordSplit = word.Split();
            Console.WriteLine($"{wordSplit[1]} {wordSplit[0]}");
        }
    }
}
