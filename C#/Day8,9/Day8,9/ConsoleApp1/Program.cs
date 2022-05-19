using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> DName = new Dictionary<string, int>();
            DName.Add("a", 0);
            DName.Add("b", 1);
            DName.Add("c", 2);
            DName["d"] = 3;

            foreach (KeyValuePair<string, int> kvp in DName)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            Console.WriteLine(DName["b"]);

            Console.WriteLine(DName.Count);

            Dictionary<string, int>.KeyCollection keys = DName.Keys;
            foreach (string s in keys) Console.WriteLine(s);

            Dictionary<string, int>.ValueCollection values = DName.Values;
            foreach (int i in values) Console.WriteLine(i);


            Console.WriteLine(DName.ContainsKey("a")); // true
            Console.WriteLine(DName.ContainsValue(5)); // false
            DName.Remove("d");
            DName.Clear();
        }
    }
}
