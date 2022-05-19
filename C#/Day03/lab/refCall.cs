using System;

namespace lab
{
    class refCall
    {
        static void Main(string[] args)
        {
            //int[] arr = new int[3];
            //Console.WriteLine("Size of array before call: " + arr.Length);
            //Console.WriteLine();
            //changeSize(ref arr);
            //Console.WriteLine("Size of array after call: " + arr.Length);
            int x = 10, y = 5;
            if (x > y)
                if (x == y)
                    Console.WriteLine("True");
            else
                    Console.WriteLine("False");
        }
        //static void changeSize(ref int[] arr)
        //{
        //    arr = new int[5];
        //}
    }
}
