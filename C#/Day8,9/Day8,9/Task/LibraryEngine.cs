using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class LibraryEngine
    {
        public static void ProcessBooks_UserDefined(List<Book> bList, MyDelegate fPtr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        }
        public static void ProcessBooks_BuiltIn(List<Book> bList, Func<Book, string> func)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(func(B));
            }
        }
        public static void ProcessBooks_Date(List<Book> bList, Func<Book, DateTime> func)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(func(B));
            }
        }
    }
}
