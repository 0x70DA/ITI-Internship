using System;
using System.Collections.Generic;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> list = new LinkedList<string>();

            list.AddFirst("Mahmoud");
            list.AddLast("Ali");
            LinkedListNode<string> current = list.Find("Ali");
            list.AddAfter(current, "Mostafa");
            list.AddBefore(current, "Omar");
            // Mahmoud --> Omar --> Ali --> Mostafa

            foreach (string s in list)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine(list.Count); // 4
        }
    }
}
